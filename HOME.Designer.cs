namespace OutlookMail
{
    partial class HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.btn_LOGIN = new System.Windows.Forms.Button();
            this.btn_SIGNUP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LOGIN
            // 
            this.btn_LOGIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LOGIN.BackgroundImage")));
            this.btn_LOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LOGIN.Location = new System.Drawing.Point(1140, 0);
            this.btn_LOGIN.Name = "btn_LOGIN";
            this.btn_LOGIN.Size = new System.Drawing.Size(112, 55);
            this.btn_LOGIN.TabIndex = 0;
            this.btn_LOGIN.Text = "LOGIN";
            this.btn_LOGIN.UseVisualStyleBackColor = true;
            this.btn_LOGIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SIGNUP
            // 
            this.btn_SIGNUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SIGNUP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SIGNUP.BackgroundImage")));
            this.btn_SIGNUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SIGNUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SIGNUP.Location = new System.Drawing.Point(1251, 0);
            this.btn_SIGNUP.Name = "btn_SIGNUP";
            this.btn_SIGNUP.Size = new System.Drawing.Size(111, 55);
            this.btn_SIGNUP.TabIndex = 1;
            this.btn_SIGNUP.Text = "SIGN_UP";
            this.btn_SIGNUP.UseVisualStyleBackColor = false;
            this.btn_SIGNUP.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(293, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 81);
            this.label1.TabIndex = 2;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SIGNUP);
            this.Controls.Add(this.btn_LOGIN);
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LOGIN;
        private System.Windows.Forms.Button btn_SIGNUP;
        private System.Windows.Forms.Label label1;

    }
}

