namespace VisaPlus
{
    partial class Form_filtr
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
            this.dataGridViewManager = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManager
            // 
            this.dataGridViewManager.AllowUserToAddRows = false;
            this.dataGridViewManager.AllowUserToDeleteRows = false;
            this.dataGridViewManager.AllowUserToResizeRows = false;
            this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManager.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewManager.MultiSelect = false;
            this.dataGridViewManager.Name = "dataGridViewManager";
            this.dataGridViewManager.ReadOnly = true;
            this.dataGridViewManager.RowHeadersVisible = false;
            this.dataGridViewManager.Size = new System.Drawing.Size(380, 260);
            this.dataGridViewManager.TabIndex = 0;
            this.dataGridViewManager.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManager_CellDoubleClick);
            // 
            // Form_filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 284);
            this.Controls.Add(this.dataGridViewManager);
            this.Name = "Form_filtr";
            this.Text = "Менеджеры";
            this.Load += new System.EventHandler(this.Form_filtr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManager;
    }
}