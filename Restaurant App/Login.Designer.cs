namespace Restaurant_App
{
    partial class Login
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
            this.lgn = new System.Windows.Forms.Button();
            this.lblusr = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.usrbx = new System.Windows.Forms.TextBox();
            this.pwdbx = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lgn
            // 
            this.lgn.Location = new System.Drawing.Point(154, 138);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(75, 23);
            this.lgn.TabIndex = 0;
            this.lgn.Text = "Login";
            this.lgn.UseVisualStyleBackColor = true;
            this.lgn.Click += new System.EventHandler(this.Lgn_Click);
            // 
            // lblusr
            // 
            this.lblusr.AutoSize = true;
            this.lblusr.Location = new System.Drawing.Point(151, 76);
            this.lblusr.Name = "lblusr";
            this.lblusr.Size = new System.Drawing.Size(58, 13);
            this.lblusr.TabIndex = 1;
            this.lblusr.Text = "Username:";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(151, 105);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(56, 13);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "Password:";
            // 
            // usrbx
            // 
            this.usrbx.Location = new System.Drawing.Point(213, 73);
            this.usrbx.Name = "usrbx";
            this.usrbx.Size = new System.Drawing.Size(100, 20);
            this.usrbx.TabIndex = 2;
            this.usrbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usrbx_KeyDown);
            // 
            // pwdbx
            // 
            this.pwdbx.Location = new System.Drawing.Point(213, 102);
            this.pwdbx.Name = "pwdbx";
            this.pwdbx.Size = new System.Drawing.Size(100, 20);
            this.pwdbx.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Castellar", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(434, 48);
            this.Title.TabIndex = 3;
            this.Title.Text = "The Food Palace";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 229);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pwdbx);
            this.Controls.Add(this.usrbx);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblusr);
            this.Controls.Add(this.lgn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lgn;
        private System.Windows.Forms.Label lblusr;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox usrbx;
        private System.Windows.Forms.TextBox pwdbx;
        private System.Windows.Forms.Label Title;
    }
}

