﻿namespace WindowsFormsApp.Views
{
    partial class RegistrationForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lastNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passwordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailAddressMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mobileNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(59, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(78, 22);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(59, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(59, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(59, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mobile number";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(38, 420);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(293, 46);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choose date of birth";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthPicker.Location = new System.Drawing.Point(38, 260);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(293, 27);
            this.dateOfBirthPicker.TabIndex = 18;
            // 
            // firstNameMaskedTextBox
            // 
            this.firstNameMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameMaskedTextBox.Location = new System.Drawing.Point(36, 34);
            this.firstNameMaskedTextBox.Name = "firstNameMaskedTextBox";
            this.firstNameMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.firstNameMaskedTextBox.TabIndex = 19;
            //this.firstNameMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameMaskedTextBox_Validating);
            // 
            // lastNameMaskedTextBox
            // 
            this.lastNameMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.lastNameMaskedTextBox.Location = new System.Drawing.Point(36, 89);
            this.lastNameMaskedTextBox.Name = "lastNameMaskedTextBox";
            this.lastNameMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.lastNameMaskedTextBox.TabIndex = 20;
            // 
            // userNameMaskedTextBox
            // 
            this.userNameMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.userNameMaskedTextBox.Location = new System.Drawing.Point(36, 144);
            this.userNameMaskedTextBox.Name = "userNameMaskedTextBox";
            this.userNameMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.userNameMaskedTextBox.TabIndex = 21;
            // 
            // passwordMaskedTextBox
            // 
            this.passwordMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(38, 199);
            this.passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            this.passwordMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.passwordMaskedTextBox.TabIndex = 22;
            // 
            // emailAddressMaskedTextBox
            // 
            this.emailAddressMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.emailAddressMaskedTextBox.Location = new System.Drawing.Point(36, 320);
            this.emailAddressMaskedTextBox.Name = "emailAddressMaskedTextBox";
            this.emailAddressMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.emailAddressMaskedTextBox.TabIndex = 23;
            // 
            // mobileNumberMaskedTextBox
            // 
            this.mobileNumberMaskedTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.mobileNumberMaskedTextBox.Location = new System.Drawing.Point(36, 375);
            this.mobileNumberMaskedTextBox.Name = "mobileNumberMaskedTextBox";
            this.mobileNumberMaskedTextBox.Size = new System.Drawing.Size(293, 27);
            this.mobileNumberMaskedTextBox.TabIndex = 24;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(92, 472);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(179, 32);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 515);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.mobileNumberMaskedTextBox);
            this.Controls.Add(this.emailAddressMaskedTextBox);
            this.Controls.Add(this.passwordMaskedTextBox);
            this.Controls.Add(this.userNameMaskedTextBox);
            this.Controls.Add(this.lastNameMaskedTextBox);
            this.Controls.Add(this.firstNameMaskedTextBox);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLabel);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.MaskedTextBox firstNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox lastNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox userNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox passwordMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox emailAddressMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox mobileNumberMaskedTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}