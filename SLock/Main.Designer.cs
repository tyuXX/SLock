
namespace SLock
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Unslock = new System.Windows.Forms.Button();
            this.timeleft = new System.Windows.Forms.TextBox();
            this.tick2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SLock.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.Location = new System.Drawing.Point(131, 73);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(132, 22);
            this.pass.TabIndex = 1;
            // 
            // Unslock
            // 
            this.Unslock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Unslock.Location = new System.Drawing.Point(131, 105);
            this.Unslock.Margin = new System.Windows.Forms.Padding(4);
            this.Unslock.Name = "Unslock";
            this.Unslock.Size = new System.Drawing.Size(133, 33);
            this.Unslock.TabIndex = 2;
            this.Unslock.Text = "Un SLock";
            this.Unslock.UseVisualStyleBackColor = true;
            this.Unslock.Click += new System.EventHandler(this.Unslock_Click);
            // 
            // timeleft
            // 
            this.timeleft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeleft.Location = new System.Drawing.Point(131, 44);
            this.timeleft.Name = "timeleft";
            this.timeleft.ReadOnly = true;
            this.timeleft.Size = new System.Drawing.Size(132, 22);
            this.timeleft.TabIndex = 3;
            // 
            // tick2
            // 
            this.tick2.Interval = 1000;
            this.tick2.Tick += new System.EventHandler(this.tick2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 251);
            this.Controls.Add(this.timeleft);
            this.Controls.Add(this.Unslock);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SLock";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Unslock;
        private System.Windows.Forms.TextBox timeleft;
        private System.Windows.Forms.Timer tick2;
    }
}

