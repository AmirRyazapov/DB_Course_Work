namespace DBCourseWork
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaintiffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defendantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTableDefendantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteDefendantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDefendantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputCourtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCourtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputCommentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCommentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCommentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseLitigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numOfCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plaintiffsToolStripMenuItem,
            this.defendantsToolStripMenuItem,
            this.casesToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.courtsToolStripMenuItem,
            this.commentsToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.tablesToolStripMenuItem.Text = "Таблицы";
            // 
            // plaintiffsToolStripMenuItem
            // 
            this.plaintiffsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputTableToolStripMenuItem,
            this.addNoteToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.plaintiffsToolStripMenuItem.Name = "plaintiffsToolStripMenuItem";
            this.plaintiffsToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.plaintiffsToolStripMenuItem.Text = "Истцы";
            // 
            // outputTableToolStripMenuItem
            // 
            this.outputTableToolStripMenuItem.Name = "outputTableToolStripMenuItem";
            this.outputTableToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.outputTableToolStripMenuItem.Text = "Вывод таблицы";
            this.outputTableToolStripMenuItem.Click += new System.EventHandler(this.outputTableToolStripMenuItem_Click);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.addNoteToolStripMenuItem.Text = "Добавить запись";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.searchToolStripMenuItem.Text = "Поиск по полям";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // defendantsToolStripMenuItem
            // 
            this.defendantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputTableDefendantsToolStripMenuItem,
            this.addNoteDefendantsToolStripMenuItem,
            this.searchDefendantsToolStripMenuItem});
            this.defendantsToolStripMenuItem.Name = "defendantsToolStripMenuItem";
            this.defendantsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defendantsToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.defendantsToolStripMenuItem.Text = "Ответчики";
            // 
            // outputTableDefendantsToolStripMenuItem
            // 
            this.outputTableDefendantsToolStripMenuItem.Name = "outputTableDefendantsToolStripMenuItem";
            this.outputTableDefendantsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.outputTableDefendantsToolStripMenuItem.Text = "Вывод таблицы";
            this.outputTableDefendantsToolStripMenuItem.Click += new System.EventHandler(this.outputTableDefendantsToolStripMenuItem_Click);
            // 
            // addNoteDefendantsToolStripMenuItem
            // 
            this.addNoteDefendantsToolStripMenuItem.Name = "addNoteDefendantsToolStripMenuItem";
            this.addNoteDefendantsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.addNoteDefendantsToolStripMenuItem.Text = "Добавить запись";
            this.addNoteDefendantsToolStripMenuItem.Click += new System.EventHandler(this.addNoteDefendantsToolStripMenuItem_Click);
            // 
            // searchDefendantsToolStripMenuItem
            // 
            this.searchDefendantsToolStripMenuItem.Name = "searchDefendantsToolStripMenuItem";
            this.searchDefendantsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.searchDefendantsToolStripMenuItem.Text = "Поиск по полям";
            this.searchDefendantsToolStripMenuItem.Click += new System.EventHandler(this.searchDefendantsToolStripMenuItem_Click);
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCasesToolStripMenuItem,
            this.addCasesToolStripMenuItem,
            this.searchCasesToolStripMenuItem});
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.casesToolStripMenuItem.Text = "Судебные дела";
            // 
            // outputCasesToolStripMenuItem
            // 
            this.outputCasesToolStripMenuItem.Name = "outputCasesToolStripMenuItem";
            this.outputCasesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.outputCasesToolStripMenuItem.Text = "Вывод таблицы";
            this.outputCasesToolStripMenuItem.Click += new System.EventHandler(this.outputCasesToolStripMenuItem_Click);
            // 
            // addCasesToolStripMenuItem
            // 
            this.addCasesToolStripMenuItem.Name = "addCasesToolStripMenuItem";
            this.addCasesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.addCasesToolStripMenuItem.Text = "Добавить запись";
            this.addCasesToolStripMenuItem.Click += new System.EventHandler(this.addCasesToolStripMenuItem_Click);
            // 
            // searchCasesToolStripMenuItem
            // 
            this.searchCasesToolStripMenuItem.Name = "searchCasesToolStripMenuItem";
            this.searchCasesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.searchCasesToolStripMenuItem.Text = "Поиск по полям";
            this.searchCasesToolStripMenuItem.Click += new System.EventHandler(this.searchCasesToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputExpensesToolStripMenuItem,
            this.addExpenseToolStripMenuItem,
            this.searchExpenseToolStripMenuItem});
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.expensesToolStripMenuItem.Text = "Судебные расходы";
            // 
            // outputExpensesToolStripMenuItem
            // 
            this.outputExpensesToolStripMenuItem.Name = "outputExpensesToolStripMenuItem";
            this.outputExpensesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.outputExpensesToolStripMenuItem.Text = "Вывод таблицы";
            this.outputExpensesToolStripMenuItem.Click += new System.EventHandler(this.outputExpensesToolStripMenuItem_Click);
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.addExpenseToolStripMenuItem.Text = "Добавить запись";
            this.addExpenseToolStripMenuItem.Click += new System.EventHandler(this.addExpenseToolStripMenuItem_Click);
            // 
            // searchExpenseToolStripMenuItem
            // 
            this.searchExpenseToolStripMenuItem.Name = "searchExpenseToolStripMenuItem";
            this.searchExpenseToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.searchExpenseToolStripMenuItem.Text = "Поиск по полям";
            this.searchExpenseToolStripMenuItem.Click += new System.EventHandler(this.searchExpenseToolStripMenuItem_Click);
            // 
            // courtsToolStripMenuItem
            // 
            this.courtsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCourtsToolStripMenuItem,
            this.addCourtToolStripMenuItem,
            this.searchCourtsToolStripMenuItem});
            this.courtsToolStripMenuItem.Name = "courtsToolStripMenuItem";
            this.courtsToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.courtsToolStripMenuItem.Text = "Суды";
            // 
            // outputCourtsToolStripMenuItem
            // 
            this.outputCourtsToolStripMenuItem.Name = "outputCourtsToolStripMenuItem";
            this.outputCourtsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.outputCourtsToolStripMenuItem.Text = "Вывод таблицы";
            this.outputCourtsToolStripMenuItem.Click += new System.EventHandler(this.outputCourtsToolStripMenuItem_Click);
            // 
            // addCourtToolStripMenuItem
            // 
            this.addCourtToolStripMenuItem.Name = "addCourtToolStripMenuItem";
            this.addCourtToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.addCourtToolStripMenuItem.Text = "Добавить запись";
            this.addCourtToolStripMenuItem.Click += new System.EventHandler(this.addCourtToolStripMenuItem_Click);
            // 
            // searchCourtsToolStripMenuItem
            // 
            this.searchCourtsToolStripMenuItem.Name = "searchCourtsToolStripMenuItem";
            this.searchCourtsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.searchCourtsToolStripMenuItem.Text = "Поиск по полям";
            this.searchCourtsToolStripMenuItem.Click += new System.EventHandler(this.searchCourtsToolStripMenuItem_Click);
            // 
            // commentsToolStripMenuItem
            // 
            this.commentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCommentsToolStripMenuItem,
            this.addCommentsToolStripMenuItem,
            this.searchCommentsToolStripMenuItem});
            this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.commentsToolStripMenuItem.Text = "Комментарии";
            // 
            // outputCommentsToolStripMenuItem
            // 
            this.outputCommentsToolStripMenuItem.Name = "outputCommentsToolStripMenuItem";
            this.outputCommentsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.outputCommentsToolStripMenuItem.Text = "Вывод таблицы";
            this.outputCommentsToolStripMenuItem.Click += new System.EventHandler(this.outputCommentsToolStripMenuItem_Click);
            // 
            // addCommentsToolStripMenuItem
            // 
            this.addCommentsToolStripMenuItem.Name = "addCommentsToolStripMenuItem";
            this.addCommentsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.addCommentsToolStripMenuItem.Text = "Добавить запись";
            this.addCommentsToolStripMenuItem.Click += new System.EventHandler(this.addCommentsToolStripMenuItem_Click);
            // 
            // searchCommentsToolStripMenuItem
            // 
            this.searchCommentsToolStripMenuItem.Name = "searchCommentsToolStripMenuItem";
            this.searchCommentsToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.searchCommentsToolStripMenuItem.Text = "Поиск по полям";
            this.searchCommentsToolStripMenuItem.Click += new System.EventHandler(this.searchCommentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfCasesToolStripMenuItem,
            this.expenseLitigationToolStripMenuItem,
            this.numOfCasesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // listOfCasesToolStripMenuItem
            // 
            this.listOfCasesToolStripMenuItem.Name = "listOfCasesToolStripMenuItem";
            this.listOfCasesToolStripMenuItem.Size = new System.Drawing.Size(521, 30);
            this.listOfCasesToolStripMenuItem.Text = "Число судебных дел в срок с ... по ...";
            this.listOfCasesToolStripMenuItem.Click += new System.EventHandler(this.listOfCasesToolStripMenuItem_Click);
            // 
            // expenseLitigationToolStripMenuItem
            // 
            this.expenseLitigationToolStripMenuItem.Name = "expenseLitigationToolStripMenuItem";
            this.expenseLitigationToolStripMenuItem.Size = new System.Drawing.Size(602, 30);
            this.expenseLitigationToolStripMenuItem.Text = "Судебные дела, в которых расходы больше(меньше), чем ...";
            this.expenseLitigationToolStripMenuItem.Click += new System.EventHandler(this.expenseLitigationToolStripMenuItem_Click);
            // 
            // numOfCasesToolStripMenuItem
            // 
            this.numOfCasesToolStripMenuItem.Name = "numOfCasesToolStripMenuItem";
            this.numOfCasesToolStripMenuItem.Size = new System.Drawing.Size(521, 30);
            this.numOfCasesToolStripMenuItem.Text = "Количество судебных дел для каждого суда";
            this.numOfCasesToolStripMenuItem.Click += new System.EventHandler(this.numOfCasesToolStripMenuItem_Click);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGV.Location = new System.Drawing.Point(0, 33);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.Size = new System.Drawing.Size(800, 417);
            this.dGV.TabIndex = 1;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellContentClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plaintiffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defendantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        public System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.ToolStripMenuItem outputTableDefendantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteDefendantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDefendantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputCourtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCourtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputCommentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCommentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCommentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseLitigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numOfCasesToolStripMenuItem;
    }
}

