﻿namespace VisaPlus
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUrlSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonUrlSave
            // 
            this.buttonUrlSave.Location = new System.Drawing.Point(360, 37);
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
            // Form_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUrlSave);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_setting";
            this.Text = "Стандартные настрокий";
            this.Load += new System.EventHandler(this.Form_setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUrlSave;
        private System.Windows.Forms.Label label1;
    }
}