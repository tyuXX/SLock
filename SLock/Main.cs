using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace SLock
{
    public partial class Main : Form
    {
        private string code = "";
        private bool close = false;
        private BigInteger MaxTries = -1;
        private BigInteger tries = 0;
        private TimeSpan UnlockTimeLeft = TimeSpan.Zero;
        private double Fails = 0;
        public Main()
        {
            InitializeComponent();
        }
        private void LogStr(string str)
        {
            File.AppendAllText( @".\log", "\n\n" + str );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(@".\pass"))
                {
                    File.Create( @".\pass" );
                }
                if (!File.Exists(@".\tries"))
                {
                    File.Create( @".\tries" );
                }
                code = File.ReadAllLines( @".\pass" )[0];
                BigInteger.TryParse(File.ReadAllLines( @".\pass" )[1],out MaxTries);
            }
            catch(Exception ex)
            {
                try { LogStr( ex.ToString() ); } catch (Exception) { }
            }
            timeleft.Hide();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            TopMost = true;
            WindowState = FormWindowState.Maximized;
        }

        private void Unslock_Click(object sender, EventArgs e)
        {
            if (pass.Text == code)
            {
                close = true;
                Application.Exit();
            }
            else
            {
                tries++;
                File.AppendAllText(@".\tries",$"[{DateTime.Now}]/[Tries:{tries},Fails:{Fails}]-'{pass.Text}'");
            }
            if(tries == MaxTries)
            {
                Unslock.Enabled = false;
                tick2.Enabled = true;
                timeleft.Show();
                tries = 0;
                Fails++;
                UnlockTimeLeft = TimeSpan.FromMinutes(Fails * 1.75);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!close)
                {
                    Process.Start(Application.ExecutablePath);
                }
            }
            catch(Exception ex)
            {
                try { LogStr( ex.ToString() ); } catch (Exception) { }
            }
        }

        private void pictureBox1_Click( object sender, EventArgs e )
        {

        }

        private void tick2_Tick( object sender, EventArgs e )
        {
            if(UnlockTimeLeft.Seconds < 1)
            {
                Unslock.Enabled = true;
                tick2.Enabled = false;
                timeleft.Hide();
                UnlockTimeLeft = TimeSpan.Zero;
            }
            else
            {
                UnlockTimeLeft = UnlockTimeLeft.Subtract(TimeSpan.FromSeconds(1));
                timeleft.Text = UnlockTimeLeft.ToString();
            }
        }
    }
}
