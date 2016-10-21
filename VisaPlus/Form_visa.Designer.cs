namespace VisaPlus
{
    partial class Form_visa
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewVisa = new System.Windows.Forms.DataGridView();
            this.idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientstatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visitdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportexpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проксиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonManagerClean = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchClean = new System.Windows.Forms.Button();
            this.buttonTabClose = new System.Windows.Forms.Button();
            this.buttonNewTab = new System.Windows.Forms.Button();
            this.tabControlGecko = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSelectDate = new System.Windows.Forms.Button();
            this.buttonPeople = new System.Windows.Forms.Button();
            this.buttonDepType = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonWeb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVisa
            // 
            this.dataGridViewVisa.AllowUserToAddRows = false;
            this.dataGridViewVisa.AllowUserToDeleteRows = false;
            this.dataGridViewVisa.AllowUserToResizeRows = false;
            this.dataGridViewVisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclient,
            this.clientstatus,
            this.visitdate,
            this.firstname,
            this.lastname,
            this.dob,
            this.passport,
            this.passportexpire,
            this.clientticket,
            this.payed,
            this.username});
            this.dataGridViewVisa.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewVisa.Name = "dataGridViewVisa";
            this.dataGridViewVisa.ReadOnly = true;
            this.dataGridViewVisa.RowHeadersVisible = false;
            this.dataGridViewVisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVisa.Size = new System.Drawing.Size(923, 82);
            this.dataGridViewVisa.TabIndex = 0;
            this.dataGridViewVisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVisa_CellDoubleClick);
            // 
            // idclient
            // 
            this.idclient.DataPropertyName = "idclient";
            this.idclient.HeaderText = "";
            this.idclient.Name = "idclient";
            this.idclient.ReadOnly = true;
            this.idclient.Width = 50;
            // 
            // clientstatus
            // 
            this.clientstatus.DataPropertyName = "status";
            this.clientstatus.FalseValue = "0";
            this.clientstatus.HeaderText = "Статус";
            this.clientstatus.Name = "clientstatus";
            this.clientstatus.ReadOnly = true;
            this.clientstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clientstatus.TrueValue = "1";
            this.clientstatus.Width = 50;
            // 
            // visitdate
            // 
            this.visitdate.DataPropertyName = "visitdate";
            this.visitdate.HeaderText = "Дата";
            this.visitdate.Name = "visitdate";
            this.visitdate.ReadOnly = true;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "firstname";
            this.firstname.HeaderText = "Имя";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "Фамилия";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Width = 150;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "День рождения";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // passport
            // 
            this.passport.DataPropertyName = "passport";
            this.passport.HeaderText = "Паспорт";
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            // 
            // passportexpire
            // 
            this.passportexpire.DataPropertyName = "passportexpire";
            this.passportexpire.HeaderText = "Срок действия";
            this.passportexpire.Name = "passportexpire";
            this.passportexpire.ReadOnly = true;
            // 
            // clientticket
            // 
            this.clientticket.DataPropertyName = "clientticket";
            this.clientticket.HeaderText = "Квитанция";
            this.clientticket.Name = "clientticket";
            this.clientticket.ReadOnly = true;
            // 
            // payed
            // 
            this.payed.DataPropertyName = "payed";
            this.payed.HeaderText = "Оплачено";
            this.payed.Name = "payed";
            this.payed.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Менеджер";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(330, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(224, 8);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(8, 6);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "Новый";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(89, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Ред";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общиеToolStripMenuItem,
            this.проксиToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // общиеToolStripMenuItem
            // 
            this.общиеToolStripMenuItem.Name = "общиеToolStripMenuItem";
            this.общиеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.общиеToolStripMenuItem.Text = "Общие";
            this.общиеToolStripMenuItem.Click += new System.EventHandler(this.общиеToolStripMenuItem_Click);
            // 
            // проксиToolStripMenuItem
            // 
            this.проксиToolStripMenuItem.Name = "проксиToolStripMenuItem";
            this.проксиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.проксиToolStripMenuItem.Text = "Прокси";
            this.проксиToolStripMenuItem.Click += new System.EventHandler(this.проксиToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonManagerClean);
            this.splitContainer1.Panel1.Controls.Add(this.buttonManager);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxManager);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearchClean);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewVisa);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEdit);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNew);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonTabClose);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNewTab);
            this.splitContainer1.Panel2.Controls.Add(this.tabControlGecko);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSelectDate);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPeople);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDepType);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStop);
            this.splitContainer1.Panel2.Controls.Add(this.buttonClient);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEmail);
            this.splitContainer1.Panel2.Controls.Add(this.buttonTicket);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReload);
            this.splitContainer1.Panel2.Controls.Add(this.buttonWeb);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.geckoWebBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(931, 403);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 6;
            // 
            // buttonManagerClean
            // 
            this.buttonManagerClean.Location = new System.Drawing.Point(750, 6);
            this.buttonManagerClean.Name = "buttonManagerClean";
            this.buttonManagerClean.Size = new System.Drawing.Size(75, 23);
            this.buttonManagerClean.TabIndex = 7;
            this.buttonManagerClean.Text = "Очистить";
            this.buttonManagerClean.UseVisualStyleBackColor = true;
            this.buttonManagerClean.Click += new System.EventHandler(this.buttonManagerClean_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(669, 6);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(75, 23);
            this.buttonManager.TabIndex = 8;
            this.buttonManager.Text = "Выбор";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // textBoxManager
            // 
            this.textBoxManager.Location = new System.Drawing.Point(537, 8);
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.ReadOnly = true;
            this.textBoxManager.Size = new System.Drawing.Size(126, 20);
            this.textBoxManager.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск";
            // 
            // buttonSearchClean
            // 
            this.buttonSearchClean.Location = new System.Drawing.Point(411, 6);
            this.buttonSearchClean.Name = "buttonSearchClean";
            this.buttonSearchClean.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchClean.TabIndex = 5;
            this.buttonSearchClean.Text = "Очистить";
            this.buttonSearchClean.UseVisualStyleBackColor = true;
            this.buttonSearchClean.Click += new System.EventHandler(this.buttonSearchClean_Click);
            // 
            // buttonTabClose
            // 
            this.buttonTabClose.Location = new System.Drawing.Point(165, 3);
            this.buttonTabClose.Name = "buttonTabClose";
            this.buttonTabClose.Size = new System.Drawing.Size(75, 23);
            this.buttonTabClose.TabIndex = 18;
            this.buttonTabClose.Text = "Закрыть";
            this.buttonTabClose.UseVisualStyleBackColor = true;
            this.buttonTabClose.Click += new System.EventHandler(this.buttonTabClose_Click);
            // 
            // buttonNewTab
            // 
            this.buttonNewTab.Location = new System.Drawing.Point(3, 3);
            this.buttonNewTab.Name = "buttonNewTab";
            this.buttonNewTab.Size = new System.Drawing.Size(75, 23);
            this.buttonNewTab.TabIndex = 7;
            this.buttonNewTab.Text = "Поиск даты";
            this.buttonNewTab.UseVisualStyleBackColor = true;
            this.buttonNewTab.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControlGecko
            // 
            this.tabControlGecko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlGecko.Location = new System.Drawing.Point(3, 32);
            this.tabControlGecko.Name = "tabControlGecko";
            this.tabControlGecko.SelectedIndex = 0;
            this.tabControlGecko.Size = new System.Drawing.Size(923, 243);
            this.tabControlGecko.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.Location = new System.Drawing.Point(735, 6);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDate.TabIndex = 7;
            this.buttonSelectDate.Text = "Дата";
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            this.buttonSelectDate.Visible = false;
            this.buttonSelectDate.Click += new System.EventHandler(this.buttonSelectDate_Click);
            // 
            // buttonPeople
            // 
            this.buttonPeople.Location = new System.Drawing.Point(411, 6);
            this.buttonPeople.Name = "buttonPeople";
            this.buttonPeople.Size = new System.Drawing.Size(75, 23);
            this.buttonPeople.TabIndex = 15;
            this.buttonPeople.Text = "Люди Катег";
            this.buttonPeople.UseVisualStyleBackColor = true;
            this.buttonPeople.Visible = false;
            this.buttonPeople.Click += new System.EventHandler(this.buttonPeople_Click);
            // 
            // buttonDepType
            // 
            this.buttonDepType.Location = new System.Drawing.Point(330, 5);
            this.buttonDepType.Name = "buttonDepType";
            this.buttonDepType.Size = new System.Drawing.Size(75, 23);
            this.buttonDepType.TabIndex = 14;
            this.buttonDepType.Text = "Пункт Цель";
            this.buttonDepType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonDepType.UseVisualStyleBackColor = true;
            this.buttonDepType.Visible = false;
            this.buttonDepType.Click += new System.EventHandler(this.buttonDepType_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(441, 35);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 13;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(654, 6);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(75, 23);
            this.buttonClient.TabIndex = 12;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Visible = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(573, 6);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonEmail.TabIndex = 11;
            this.buttonEmail.Text = "Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Visible = false;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Location = new System.Drawing.Point(492, 6);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonTicket.TabIndex = 10;
            this.buttonTicket.Text = "Квитанции";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Visible = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(84, 3);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 9;
            this.buttonReload.Text = "Обновить";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonWeb
            // 
            this.buttonWeb.Location = new System.Drawing.Point(279, 35);
            this.buttonWeb.Name = "buttonWeb";
            this.buttonWeb.Size = new System.Drawing.Size(75, 23);
            this.buttonWeb.TabIndex = 7;
            this.buttonWeb.Text = "Веб";
            this.buttonWeb.UseVisualStyleBackColor = true;
            this.buttonWeb.Visible = false;
            this.buttonWeb.Click += new System.EventHandler(this.buttonWeb_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(622, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(258, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Прокси - ";
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser1.Location = new System.Drawing.Point(825, 6);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(89, 23);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.Visible = false;
            this.geckoWebBrowser1.Navigating += new System.EventHandler<Gecko.Events.GeckoNavigatingEventArgs>(this.geckoWebBrowser1_Navigating_1);
            this.geckoWebBrowser1.NavigationError += new System.EventHandler<Gecko.Events.GeckoNavigationErrorEventArgs>(this.geckoWebBrowser1_NavigationError);
            this.geckoWebBrowser1.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser1_DocumentCompleted);
            this.geckoWebBrowser1.ProgressChanged += new System.EventHandler<Gecko.GeckoProgressEventArgs>(this.geckoWebBrowser1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(478, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(341, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 30000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // Form_visa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 442);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form_visa";
            this.Text = "VisaPlus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_visa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisa;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проксиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonWeb;
        private System.Windows.Forms.Button buttonSearchClean;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.ToolStripMenuItem общиеToolStripMenuItem;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Button buttonManagerClean;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonDepType;
        private System.Windows.Forms.Button buttonPeople;
        private System.Windows.Forms.Button buttonSelectDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clientstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportexpire;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn payed;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.TabControl tabControlGecko;
        private System.Windows.Forms.Button buttonNewTab;
        private System.Windows.Forms.Button buttonTabClose;
        private System.Windows.Forms.Timer timerUpdate;
    }
}