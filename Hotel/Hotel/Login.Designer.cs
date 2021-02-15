
namespace Hotel
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
            this.lb_login = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("FC Home", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_login.Location = new System.Drawing.Point(59, 9);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(163, 70);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Login";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(107, 82);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(115, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(107, 108);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(115, 20);
            this.tb_password.TabIndex = 2;
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(147, 134);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(75, 23);
            this.bt_register.TabIndex = 3;
            this.bt_register.Text = "สมัคสมาชิก";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(66, 134);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "เข้าสู่ระบบ";
            this.bt_login.UseVisualStyleBackColor = true;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(68, 85);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(32, 13);
            this.lb_id.TabIndex = 5;
            this.lb_id.Text = "Mail :";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(41, 111);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(59, 13);
            this.lb_password.TabIndex = 6;
            this.lb_password.Text = "Password :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 200);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_password;
    }
}

