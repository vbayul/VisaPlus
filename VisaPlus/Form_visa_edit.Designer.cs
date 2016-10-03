namespace VisaPlus
{
    partial class Form_visa_edit
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
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.checkBoxSatus = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.maskedTextBoxVisitDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.comboBoxVisaType = new System.Windows.Forms.ComboBox();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDOB = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPassportExpire = new System.Windows.Forms.MaskedTextBox();
            this.textBoxClientTicket = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.numericUpDownTravelLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPayed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPersons = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKids = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.radioButtonNearestDate1 = new System.Windows.Forms.RadioButton();
            this.radioButtonNearestDate2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTravelLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKids)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 107);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(171, 20);
            this.textBoxLastName.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(221, 107);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(171, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // checkBoxSatus
            // 
            this.checkBoxSatus.AutoSize = true;
            this.checkBoxSatus.Location = new System.Drawing.Point(12, 25);
            this.checkBoxSatus.Name = "checkBoxSatus";
            this.checkBoxSatus.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSatus.TabIndex = 2;
            this.checkBoxSatus.Text = "Заявка подана";
            this.checkBoxSatus.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(236, 420);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(317, 420);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // maskedTextBoxVisitDate
            // 
            this.maskedTextBoxVisitDate.Location = new System.Drawing.Point(221, 25);
            this.maskedTextBoxVisitDate.Mask = "00/00/0000";
            this.maskedTextBoxVisitDate.Name = "maskedTextBoxVisitDate";
            this.maskedTextBoxVisitDate.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxVisitDate.TabIndex = 5;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(12, 70);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRegion.TabIndex = 7;
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Location = new System.Drawing.Point(221, 145);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(171, 21);
            this.comboBoxPurpose.TabIndex = 8;
            // 
            // comboBoxVisaType
            // 
            this.comboBoxVisaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisaType.FormattingEnabled = true;
            this.comboBoxVisaType.Location = new System.Drawing.Point(221, 70);
            this.comboBoxVisaType.Name = "comboBoxVisaType";
            this.comboBoxVisaType.Size = new System.Drawing.Size(171, 21);
            this.comboBoxVisaType.TabIndex = 9;
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(12, 374);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(171, 21);
            this.comboBoxTitle.TabIndex = 10;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(221, 374);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(171, 21);
            this.comboBoxNationality.TabIndex = 11;
            // 
            // maskedTextBoxDOB
            // 
            this.maskedTextBoxDOB.Location = new System.Drawing.Point(12, 145);
            this.maskedTextBoxDOB.Mask = "00/00/0000";
            this.maskedTextBoxDOB.Name = "maskedTextBoxDOB";
            this.maskedTextBoxDOB.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDOB.TabIndex = 12;
            this.maskedTextBoxDOB.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(12, 182);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassport.TabIndex = 13;
            // 
            // maskedTextBoxPassportExpire
            // 
            this.maskedTextBoxPassportExpire.Location = new System.Drawing.Point(221, 182);
            this.maskedTextBoxPassportExpire.Mask = "00/00/0000";
            this.maskedTextBoxPassportExpire.Name = "maskedTextBoxPassportExpire";
            this.maskedTextBoxPassportExpire.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPassportExpire.TabIndex = 14;
            this.maskedTextBoxPassportExpire.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxClientTicket
            // 
            this.textBoxClientTicket.Location = new System.Drawing.Point(12, 218);
            this.textBoxClientTicket.Name = "textBoxClientTicket";
            this.textBoxClientTicket.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientTicket.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 257);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(221, 256);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 17;
            // 
            // numericUpDownTravelLength
            // 
            this.numericUpDownTravelLength.Location = new System.Drawing.Point(12, 296);
            this.numericUpDownTravelLength.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownTravelLength.Name = "numericUpDownTravelLength";
            this.numericUpDownTravelLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTravelLength.TabIndex = 18;
            this.numericUpDownTravelLength.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // numericUpDownPayed
            // 
            this.numericUpDownPayed.Location = new System.Drawing.Point(221, 295);
            this.numericUpDownPayed.Name = "numericUpDownPayed";
            this.numericUpDownPayed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPayed.TabIndex = 19;
            // 
            // numericUpDownPersons
            // 
            this.numericUpDownPersons.Location = new System.Drawing.Point(12, 335);
            this.numericUpDownPersons.Name = "numericUpDownPersons";
            this.numericUpDownPersons.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPersons.TabIndex = 20;
            this.numericUpDownPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKids
            // 
            this.numericUpDownKids.Location = new System.Drawing.Point(221, 335);
            this.numericUpDownKids.Name = "numericUpDownKids";
            this.numericUpDownKids.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKids.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Визит назначен на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Регион";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Тип визы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Цель обращения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Паспорт";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Паспорт до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Квитанция";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Пароль";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Длительность поездки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(218, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Оплачено";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Количество взрослых";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(218, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Количество детей";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Национальность";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 358);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Титул";
            // 
            // radioButtonNearestDate1
            // 
            this.radioButtonNearestDate1.AutoSize = true;
            this.radioButtonNearestDate1.Checked = true;
            this.radioButtonNearestDate1.Location = new System.Drawing.Point(217, 221);
            this.radioButtonNearestDate1.Name = "radioButtonNearestDate1";
            this.radioButtonNearestDate1.Size = new System.Drawing.Size(84, 17);
            this.radioButtonNearestDate1.TabIndex = 40;
            this.radioButtonNearestDate1.TabStop = true;
            this.radioButtonNearestDate1.Text = "Ближайшая";
            this.radioButtonNearestDate1.UseVisualStyleBackColor = true;
            // 
            // radioButtonNearestDate2
            // 
            this.radioButtonNearestDate2.AutoSize = true;
            this.radioButtonNearestDate2.Location = new System.Drawing.Point(308, 221);
            this.radioButtonNearestDate2.Name = "radioButtonNearestDate2";
            this.radioButtonNearestDate2.Size = new System.Drawing.Size(81, 17);
            this.radioButtonNearestDate2.TabIndex = 41;
            this.radioButtonNearestDate2.TabStop = true;
            this.radioButtonNearestDate2.Text = "Последняя";
            this.radioButtonNearestDate2.UseVisualStyleBackColor = true;
            // 
            // Form_visa_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 455);
            this.Controls.Add(this.radioButtonNearestDate2);
            this.Controls.Add(this.radioButtonNearestDate1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownKids);
            this.Controls.Add(this.numericUpDownPersons);
            this.Controls.Add(this.numericUpDownPayed);
            this.Controls.Add(this.numericUpDownTravelLength);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxClientTicket);
            this.Controls.Add(this.maskedTextBoxPassportExpire);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.maskedTextBoxDOB);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.comboBoxVisaType);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.maskedTextBoxVisitDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxSatus);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Name = "Form_visa_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.Form_visa_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTravelLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKids)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.CheckBox checkBoxSatus;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVisitDate;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.ComboBox comboBoxVisaType;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDOB;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassportExpire;
        private System.Windows.Forms.TextBox textBoxClientTicket;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.NumericUpDown numericUpDownTravelLength;
        private System.Windows.Forms.NumericUpDown numericUpDownPayed;
        private System.Windows.Forms.NumericUpDown numericUpDownPersons;
        private System.Windows.Forms.NumericUpDown numericUpDownKids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioButtonNearestDate1;
        private System.Windows.Forms.RadioButton radioButtonNearestDate2;
    }
}