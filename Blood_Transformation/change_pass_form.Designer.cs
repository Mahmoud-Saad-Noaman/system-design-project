namespace Blood_Transformation
{
    partial class change_pass_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.new_pass_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.old_pass_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.email_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.change_pass_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.back_button = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Blood_Transformation.Properties.Resources.drone_final1;
            this.pictureBox1.InitialImage = global::Blood_Transformation.Properties.Resources.drone_final;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(320, 74);
            this.email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(54, 22);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "new password";
            // 
            // new_pass_txtbox
            // 
            this.new_pass_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass_txtbox.ForeColor = System.Drawing.Color.Black;
            this.new_pass_txtbox.Location = new System.Drawing.Point(324, 283);
            this.new_pass_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.new_pass_txtbox.Name = "new_pass_txtbox";
            this.new_pass_txtbox.Size = new System.Drawing.Size(298, 27);
            this.new_pass_txtbox.TabIndex = 9;
            this.new_pass_txtbox.UseSystemPasswordChar = true;
            // 
            // old_pass_txtbox
            // 
            this.old_pass_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_pass_txtbox.ForeColor = System.Drawing.Color.Black;
            this.old_pass_txtbox.Location = new System.Drawing.Point(324, 195);
            this.old_pass_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.old_pass_txtbox.Name = "old_pass_txtbox";
            this.old_pass_txtbox.Size = new System.Drawing.Size(298, 27);
            this.old_pass_txtbox.TabIndex = 10;
            this.old_pass_txtbox.UseSystemPasswordChar = true;
            // 
            // email_txtbox
            // 
            this.email_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txtbox.ForeColor = System.Drawing.Color.Black;
            this.email_txtbox.Location = new System.Drawing.Point(324, 98);
            this.email_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(298, 27);
            this.email_txtbox.TabIndex = 11;
            // 
            // change_pass_submit
            // 
            this.change_pass_submit.Depth = 0;
            this.change_pass_submit.Location = new System.Drawing.Point(324, 347);
            this.change_pass_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.change_pass_submit.Name = "change_pass_submit";
            this.change_pass_submit.Primary = true;
            this.change_pass_submit.Size = new System.Drawing.Size(144, 32);
            this.change_pass_submit.TabIndex = 12;
            this.change_pass_submit.Text = "submit";
            this.change_pass_submit.UseVisualStyleBackColor = true;
            this.change_pass_submit.Click += new System.EventHandler(this.chng_pass_submit_Click);
            // 
            // back_button
            // 
            this.back_button.Depth = 0;
            this.back_button.Location = new System.Drawing.Point(474, 347);
            this.back_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_button.Name = "back_button";
            this.back_button.Primary = true;
            this.back_button.Size = new System.Drawing.Size(144, 32);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // change_pass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 410);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.change_pass_submit);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.old_pass_txtbox);
            this.Controls.Add(this.new_pass_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "change_pass_form";
            this.Text = "change_pass_form";
            this.Load += new System.EventHandler(this.change_pass_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox new_pass_txtbox;
        private System.Windows.Forms.MaskedTextBox old_pass_txtbox;
        private System.Windows.Forms.MaskedTextBox email_txtbox;
        private MaterialSkin.Controls.MaterialRaisedButton change_pass_submit;
        private MaterialSkin.Controls.MaterialRaisedButton back_button;
    }
}