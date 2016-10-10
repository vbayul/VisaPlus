namespace VisaPlus
{
    partial class Form_setting
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonUrlSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxVisaType = new System.Windows.Forms.ComboBox();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.textBoxSMTP = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 39);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(283, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // buttonUrlSave
            // 
            this.buttonUrlSave.Location = new System.Drawing.Point(170, 375);
            this.buttonUrlSave.Name = "buttonUrlSave";
            this.buttonUrlSave.Size = new System.Drawing.Size(75, 23);
            this.buttonUrlSave.TabIndex = 1;
            this.buttonUrlSave.Text = "Сохранить";
            this.buttonUrlSave.UseVisualStyleBackColor = true;
            this.buttonUrlSave.Click += new System.EventHandler(this.buttonUrlSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ссылка";
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Location = new System.Drawing.Point(20, 75);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPurpose.TabIndex = 3;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(179, 75);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNationality.TabIndex = 4;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(20, 34);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegion.TabIndex = 5;
            // 
            // comboBoxVisaType
            // 
            this.comboBoxVisaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisaType.FormattingEnabled = true;
            this.comboBoxVisaType.Location = new System.Drawing.Point(179, 34);
            this.comboBoxVisaType.Name = "comboBoxVisaType";
            this.comboBoxVisaType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisaType.TabIndex = 6;
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(179, 122);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTitle.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(20, 122);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Регион";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип визы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Цель обращения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Национальность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Пароль для почты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Титул";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(250, 375);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.textBoxPassword);
            this.groupBoxClient.Controls.Add(this.comboBoxPurpose);
            this.groupBoxClient.Controls.Add(this.label7);
            this.groupBoxClient.Controls.Add(this.comboBoxNationality);
            this.groupBoxClient.Controls.Add(this.label6);
            this.groupBoxClient.Controls.Add(this.comboBoxRegion);
            this.groupBoxClient.Controls.Add(this.label5);
            this.groupBoxClient.Controls.Add(this.comboBoxVisaType);
            this.groupBoxClient.Controls.Add(this.label4);
            this.groupBoxClient.Controls.Add(this.comboBoxTitle);
            this.groupBoxClient.Controls.Add(this.label3);
            this.groupBoxClient.Controls.Add(this.label2);
            this.groupBoxClient.Location = new System.Drawing.Point(12, 78);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(313, 148);
            this.groupBoxClient.TabIndex = 17;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Стандартные настройки";
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.checkBoxSSL);
            this.groupBoxEmail.Controls.Add(this.textBoxPort);
            this.groupBoxEmail.Controls.Add(this.label11);
            this.groupBoxEmail.Controls.Add(this.label8);
            this.groupBoxEmail.Controls.Add(this.label9);
            this.groupBoxEmail.Controls.Add(this.label10);
            this.groupBoxEmail.Controls.Add(this.textBoxPass);
            this.groupBoxEmail.Controls.Add(this.textBoxEmail);
            this.groupBoxEmail.Controls.Add(this.textBoxSMTP);
            this.groupBoxEmail.Location = new System.Drawing.Point(12, 240);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(313, 129);
            this.groupBoxEmail.TabIndex = 18;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Настроки почты";
            // 
            // textBoxSMTP
            // 
            this.textBoxSMTP.Location = new System.Drawing.Point(20, 32);
            this.textBoxSMTP.Name = "textBoxSMTP";
            this.textBoxSMTP.Size = new System.Drawing.Size(121, 20);
            this.textBoxSMTP.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(20, 75);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(179, 75);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(117, 20);
            this.textBoxPass.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "SMTP сервер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Пароль";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Порт";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(179, 32);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(117, 20);
            this.textBoxPort.TabIndex = 23;
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(20, 106);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(46, 17);
            this.checkBoxSSL.TabIndex = 19;
            this.checkBoxSSL.Text = "SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // Form_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 408);
            this.Controls.Add(this.groupBoxEmail);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUrlSave);
            this.Controls.Add(this.textBoxURL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Стандартные настрокий";
            this.Load += new System.EventHandler(this.Form_setting_Load);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonUrlSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxVisaType;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSMTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxSSL;
    }
}