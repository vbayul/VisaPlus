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
            this.idusers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManager
            // 
            this.dataGridViewManager.AllowUserToAddRows = false;
            this.dataGridViewManager.AllowUserToDeleteRows = false;
            this.dataGridViewManager.AllowUserToResizeRows = false;
            this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusers,
            this.status,
            this.username,
            this.idtype,
            this.email});
            this.dataGridViewManager.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewManager.MultiSelect = false;
            this.dataGridViewManager.Name = "dataGridViewManager";
            this.dataGridViewManager.ReadOnly = true;
            this.dataGridViewManager.RowHeadersVisible = false;
            this.dataGridViewManager.Size = new System.Drawing.Size(380, 260);
            this.dataGridViewManager.TabIndex = 0;
            this.dataGridViewManager.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManager_CellDoubleClick);
            // 
            // idusers
            // 
            this.idusers.DataPropertyName = "idusers";
            this.idusers.HeaderText = "";
            this.idusers.Name = "idusers";
            this.idusers.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.FalseValue = "0";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.TrueValue = "1";
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Менеджер";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // idtype
            // 
            this.idtype.DataPropertyName = "idtype";
            this.idtype.HeaderText = "Column1";
            this.idtype.Name = "idtype";
            this.idtype.ReadOnly = true;
            this.idtype.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Column1";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // Form_filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 284);
            this.Controls.Add(this.dataGridViewManager);
            this.Name = "Form_filtr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Менеджеры";
            this.Load += new System.EventHandler(this.Form_filtr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}