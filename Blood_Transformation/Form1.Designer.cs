namespace Blood_Transformation
{
    partial class Form1
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
            this.txtbox_email = new System.Windows.Forms.MaskedTextBox();
            this.txt_confirm_password = new System.Windows.Forms.MaskedTextBox();
            this.login = new System.Windows.Forms.Button();
            this.signu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.login_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.signup_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.change_pass_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_email
            // 
            this.txtbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_email.ForeColor = System.Drawing.Color.Black;
            this.txtbox_email.Location = new System.Drawing.Point(320, 98);
            this.txtbox_email.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(298, 27);
            this.txtbox_email.TabIndex = 2;
            this.txtbox_email.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtbox_email_MaskInputRejected);
            this.txtbox_email.Enter += new System.EventHandler(this.txt_emai_Enter);
            this.txtbox_email.Leave += new System.EventHandler(this.txt_emai_Leave);
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_password.ForeColor = System.Drawing.Color.Black;
            this.txt_confirm_password.Location = new System.Drawing.Point(320, 185);
            this.txt_confirm_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(298, 27);
            this.txt_confirm_password.TabIndex = 2;
            this.txt_confirm_password.UseSystemPasswordChar = true;
            this.txt_confirm_password.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_confirm_password_MaskInputRejected);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(322, 248);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(297, 32);
            this.login.TabIndex = 3;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // signu
            // 
            this.signu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signu.Location = new System.Drawing.Point(322, 328);
            this.signu.Margin = new System.Windows.Forms.Padding(2);
            this.signu.Name = "signu";
            this.signu.Size = new System.Drawing.Size(297, 32);
            this.signu.TabIndex = 3;
            this.signu.Text = "SIGNUP";
            this.signu.UseVisualStyleBackColor = true;
            this.signu.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Blood_Transformation.Properties.Resources.drone_final;
            this.pictureBox1.Location = new System.Drawing.Point(11, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(318, 74);
            this.email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(54, 22);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(318, 162);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(89, 22);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(398, 294);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "or create an account";
            // 
            // login_button
            // 
            this.login_button.Depth = 0;
            this.login_button.Location = new System.Drawing.Point(319, 248);
            this.login_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_button.Name = "login_button";
            this.login_button.Primary = true;
            this.login_button.Size = new System.Drawing.Size(300, 32);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.Depth = 0;
            this.signup_button.Location = new System.Drawing.Point(320, 329);
            this.signup_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.signup_button.Name = "signup_button";
            this.signup_button.Primary = true;
            this.signup_button.Size = new System.Drawing.Size(299, 32);
            this.signup_button.TabIndex = 8;
            this.signup_button.Text = "SIGN UP";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // change_pass_button
            // 
            this.change_pass_button.Depth = 0;
            this.change_pass_button.Location = new System.Drawing.Point(318, 409);
            this.change_pass_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.change_pass_button.Name = "change_pass_button";
            this.change_pass_button.Primary = true;
            this.change_pass_button.Size = new System.Drawing.Size(300, 31);
            this.change_pass_button.TabIndex = 9;
            this.change_pass_button.Text = "change password";
            this.change_pass_button.UseVisualStyleBackColor = true;
            this.change_pass_button.Click += new System.EventHandler(this.change_pass_button_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(401, 376);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(144, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "or change password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(642, 467);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.change_pass_button);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.signu);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtbox_email;
        private System.Windows.Forms.MaskedTextBox txt_confirm_password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signu;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton login_button;
        private MaterialSkin.Controls.MaterialRaisedButton signup_button;
        private MaterialSkin.Controls.MaterialRaisedButton change_pass_button;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

