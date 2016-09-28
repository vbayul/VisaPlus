namespace VisaPlus
{
    partial class Form_proxy
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.dataGridViewProxy = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.idproxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxystatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proxyip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCln = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(15, 25);
            this.textBoxIP.MaxLength = 15;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(151, 20);
            this.textBoxIP.TabIndex = 0;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(172, 25);
            this.textBoxPort.MaxLength = 6;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(58, 20);
            this.textBoxPort.TabIndex = 1;
            // 
            // dataGridViewProxy
            // 
            this.dataGridViewProxy.AllowUserToAddRows = false;
            this.dataGridViewProxy.AllowUserToDeleteRows = false;
            this.dataGridViewProxy.AllowUserToResizeRows = false;
            this.dataGridViewProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProxy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproxy,
            this.proxystatus,
            this.proxyip,
            this.proxyport});
            this.dataGridViewProxy.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewProxy.MultiSelect = false;
            this.dataGridViewProxy.Name = "dataGridViewProxy";
            this.dataGridViewProxy.ReadOnly = true;
            this.dataGridViewProxy.RowHeadersVisible = false;
            this.dataGridViewProxy.Size = new System.Drawing.Size(387, 180);
            this.dataGridViewProxy.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(236, 23);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(317, 23);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 4;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP адрес ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Порт";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(15, 51);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 7;
            this.buttonSet.Text = "Выбрать";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // idproxy
            // 
            this.idproxy.DataPropertyName = "idproxy";
            this.idproxy.HeaderText = "";
            this.idproxy.Name = "idproxy";
            this.idproxy.ReadOnly = true;
            this.idproxy.Width = 50;
            // 
            // proxystatus
            // 
            this.proxystatus.DataPropertyName = "proxystatus";
            this.proxystatus.FalseValue = "0";
            this.proxystatus.HeaderText = "Статус";
            this.proxystatus.Name = "proxystatus";
            this.proxystatus.ReadOnly = true;
            this.proxystatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proxystatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.proxystatus.TrueValue = "1";
            this.proxystatus.Width = 50;
            // 
            // proxyip
            // 
            this.proxyip.DataPropertyName = "proxyip";
            this.proxyip.HeaderText = "IP";
            this.proxyip.Name = "proxyip";
            this.proxyip.ReadOnly = true;
            // 
            // proxyport
            // 
            this.proxyport.DataPropertyName = "proxyport";
            this.proxyport.HeaderText = "Port";
            this.proxyport.Name = "proxyport";
            this.proxyport.ReadOnly = true;
            // 
            // buttonCln
            // 
            this.buttonCln.Location = new System.Drawing.Point(96, 51);
            this.buttonCln.Name = "buttonCln";
            this.buttonCln.Size = new System.Drawing.Size(75, 23);
            this.buttonCln.TabIndex = 8;
            this.buttonCln.Text = "Очистить";
            this.buttonCln.UseVisualStyleBackColor = true;
            this.buttonCln.Click += new System.EventHandler(this.buttonCln_Click);
            // 
            // Form_proxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 272);
            this.Controls.Add(this.buttonCln);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewProxy);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Name = "Form_proxy";
            this.Text = "Proxy";
            this.Load += new System.EventHandler(this.Form_proxy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.DataGridView dataGridViewProxy;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproxy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn proxystatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyip;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyport;
        private System.Windows.Forms.Button buttonCln;
    }
}