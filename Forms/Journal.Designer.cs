namespace LibraryCollege.Forms
{
    partial class Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtPassed = new System.Windows.Forms.RadioButton();
            this.rbtDataEnd = new System.Windows.Forms.RadioButton();
            this.rbtDateBegin = new System.Windows.Forms.RadioButton();
            this.btnFilter = new System.Windows.Forms.Button();
            this.rbtWhere = new System.Windows.Forms.RadioButton();
            this.rbtBook = new System.Windows.Forms.RadioButton();
            this.rbtNum = new System.Windows.Forms.RadioButton();
            this.rbtIdTaking = new System.Windows.Forms.RadioButton();
            this.rbtIdStudent = new System.Windows.Forms.RadioButton();
            this.cmbCriteria = new System.Windows.Forms.ComboBox();
            this.useTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_LibraryCollegeDataSet = new LibraryCollege.DB_LibraryCollegeDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.useTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtDateBegin = new System.Windows.Forms.DateTimePicker();
            this.cmbWhereRead = new System.Windows.Forms.ComboBox();
            this.cmbPassed = new System.Windows.Forms.ComboBox();
            this.cmbIdBooks = new System.Windows.Forms.ComboBox();
            this.cmbIdStudents = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtNumInstances = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdTaking = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewJournal = new System.Windows.Forms.DataGridView();
            this.useTableTableAdapter = new LibraryCollege.DB_LibraryCollegeDataSetTableAdapters.UseTableTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.readerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableTableAdapter = new LibraryCollege.DB_LibraryCollegeDataSetTableAdapters.ReaderTableTableAdapter();
            this.booksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableTableAdapter = new LibraryCollege.DB_LibraryCollegeDataSetTableAdapters.BooksTableTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LibraryCollegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useTableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.журналToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1760, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.главнаяToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.книгиToolStripMenuItem.Text = "Книги";
            this.книгиToolStripMenuItem.Click += new System.EventHandler(this.книгиToolStripMenuItem_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.журналToolStripMenuItem.Text = "Журнал";
            this.журналToolStripMenuItem.Click += new System.EventHandler(this.журналToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbCriteria);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(30, 541);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 453);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с таблицей";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtPassed);
            this.groupBox3.Controls.Add(this.rbtDataEnd);
            this.groupBox3.Controls.Add(this.rbtDateBegin);
            this.groupBox3.Controls.Add(this.btnFilter);
            this.groupBox3.Controls.Add(this.rbtWhere);
            this.groupBox3.Controls.Add(this.rbtBook);
            this.groupBox3.Controls.Add(this.rbtNum);
            this.groupBox3.Controls.Add(this.rbtIdTaking);
            this.groupBox3.Controls.Add(this.rbtIdStudent);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(470, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 415);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортировка";
            // 
            // rbtPassed
            // 
            this.rbtPassed.AutoSize = true;
            this.rbtPassed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtPassed.Location = new System.Drawing.Point(35, 299);
            this.rbtPassed.Name = "rbtPassed";
            this.rbtPassed.Size = new System.Drawing.Size(93, 28);
            this.rbtPassed.TabIndex = 53;
            this.rbtPassed.TabStop = true;
            this.rbtPassed.Text = "Сдано";
            this.rbtPassed.UseVisualStyleBackColor = true;
            // 
            // rbtDataEnd
            // 
            this.rbtDataEnd.AutoSize = true;
            this.rbtDataEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtDataEnd.Location = new System.Drawing.Point(35, 262);
            this.rbtDataEnd.Name = "rbtDataEnd";
            this.rbtDataEnd.Size = new System.Drawing.Size(216, 28);
            this.rbtDataEnd.TabIndex = 52;
            this.rbtDataEnd.TabStop = true;
            this.rbtDataEnd.Text = "Дата возвращения";
            this.rbtDataEnd.UseVisualStyleBackColor = true;
            // 
            // rbtDateBegin
            // 
            this.rbtDateBegin.AutoSize = true;
            this.rbtDateBegin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtDateBegin.Location = new System.Drawing.Point(35, 224);
            this.rbtDateBegin.Name = "rbtDateBegin";
            this.rbtDateBegin.Size = new System.Drawing.Size(159, 28);
            this.rbtDateBegin.TabIndex = 51;
            this.rbtDateBegin.TabStop = true;
            this.rbtDateBegin.Text = "Дата выдачи";
            this.rbtDateBegin.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Location = new System.Drawing.Point(97, 349);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(202, 43);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Сортировать";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // rbtWhere
            // 
            this.rbtWhere.AutoSize = true;
            this.rbtWhere.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtWhere.Location = new System.Drawing.Point(35, 188);
            this.rbtWhere.Name = "rbtWhere";
            this.rbtWhere.Size = new System.Drawing.Size(143, 28);
            this.rbtWhere.TabIndex = 50;
            this.rbtWhere.TabStop = true;
            this.rbtWhere.Text = "Вид взятия";
            this.rbtWhere.UseVisualStyleBackColor = true;
            // 
            // rbtBook
            // 
            this.rbtBook.AutoSize = true;
            this.rbtBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtBook.Location = new System.Drawing.Point(35, 116);
            this.rbtBook.Name = "rbtBook";
            this.rbtBook.Size = new System.Drawing.Size(128, 28);
            this.rbtBook.TabIndex = 48;
            this.rbtBook.TabStop = true;
            this.rbtBook.Text = "Код книги";
            this.rbtBook.UseVisualStyleBackColor = true;
            // 
            // rbtNum
            // 
            this.rbtNum.AutoSize = true;
            this.rbtNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtNum.Location = new System.Drawing.Point(35, 154);
            this.rbtNum.Name = "rbtNum";
            this.rbtNum.Size = new System.Drawing.Size(312, 28);
            this.rbtNum.TabIndex = 49;
            this.rbtNum.TabStop = true;
            this.rbtNum.Text = "Кол-во взятых экземпляров";
            this.rbtNum.UseVisualStyleBackColor = true;
            // 
            // rbtIdTaking
            // 
            this.rbtIdTaking.AutoSize = true;
            this.rbtIdTaking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtIdTaking.Location = new System.Drawing.Point(35, 44);
            this.rbtIdTaking.Name = "rbtIdTaking";
            this.rbtIdTaking.Size = new System.Drawing.Size(142, 28);
            this.rbtIdTaking.TabIndex = 46;
            this.rbtIdTaking.TabStop = true;
            this.rbtIdTaking.Text = "Код записи";
            this.rbtIdTaking.UseVisualStyleBackColor = true;
            // 
            // rbtIdStudent
            // 
            this.rbtIdStudent.AutoSize = true;
            this.rbtIdStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtIdStudent.Location = new System.Drawing.Point(35, 78);
            this.rbtIdStudent.Name = "rbtIdStudent";
            this.rbtIdStudent.Size = new System.Drawing.Size(161, 28);
            this.rbtIdStudent.TabIndex = 47;
            this.rbtIdStudent.TabStop = true;
            this.rbtIdStudent.Text = "Код студента";
            this.rbtIdStudent.UseVisualStyleBackColor = true;
            // 
            // cmbCriteria
            // 
            this.cmbCriteria.DataSource = this.useTableBindingSource1;
            this.cmbCriteria.DisplayMember = "Passed";
            this.cmbCriteria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCriteria.FormattingEnabled = true;
            this.cmbCriteria.Location = new System.Drawing.Point(18, 172);
            this.cmbCriteria.Name = "cmbCriteria";
            this.cmbCriteria.Size = new System.Drawing.Size(404, 32);
            this.cmbCriteria.TabIndex = 37;
            this.cmbCriteria.ValueMember = "Passed";
            this.cmbCriteria.SelectedIndexChanged += new System.EventHandler(this.cmbCriteria_SelectedIndexChanged);
            // 
            // useTableBindingSource1
            // 
            this.useTableBindingSource1.DataMember = "UseTable";
            this.useTableBindingSource1.DataSource = this.dB_LibraryCollegeDataSet;
            // 
            // dB_LibraryCollegeDataSet
            // 
            this.dB_LibraryCollegeDataSet.DataSetName = "DB_LibraryCollegeDataSet";
            this.dB_LibraryCollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Критерий:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(18, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Фильтровать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(23, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Поиск:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(18, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(404, 30);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAll.Location = new System.Drawing.Point(246, 231);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(176, 43);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "Показать все";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // useTableBindingSource
            // 
            this.useTableBindingSource.DataMember = "UseTable";
            this.useTableBindingSource.DataSource = this.dB_LibraryCollegeDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDateEnd);
            this.groupBox1.Controls.Add(this.txtDateBegin);
            this.groupBox1.Controls.Add(this.cmbWhereRead);
            this.groupBox1.Controls.Add(this.cmbPassed);
            this.groupBox1.Controls.Add(this.cmbIdBooks);
            this.groupBox1.Controls.Add(this.cmbIdStudents);
            this.groupBox1.Controls.Add(this.Refresh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.txtNumInstances);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdTaking);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(952, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 453);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с записями";
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.CustomFormat = "dd.MM.yyyy";
            this.txtDateEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateEnd.Location = new System.Drawing.Point(254, 348);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(291, 30);
            this.txtDateEnd.TabIndex = 54;
            // 
            // txtDateBegin
            // 
            this.txtDateBegin.CustomFormat = "dd.MM.yyyy";
            this.txtDateBegin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateBegin.Location = new System.Drawing.Point(210, 298);
            this.txtDateBegin.Name = "txtDateBegin";
            this.txtDateBegin.Size = new System.Drawing.Size(335, 30);
            this.txtDateBegin.TabIndex = 53;
            // 
            // cmbWhereRead
            // 
            this.cmbWhereRead.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbWhereRead.FormattingEnabled = true;
            this.cmbWhereRead.Items.AddRange(new object[] {
            "Абонемент",
            "Читальный зал"});
            this.cmbWhereRead.Location = new System.Drawing.Point(210, 249);
            this.cmbWhereRead.Name = "cmbWhereRead";
            this.cmbWhereRead.Size = new System.Drawing.Size(335, 32);
            this.cmbWhereRead.TabIndex = 50;
            // 
            // cmbPassed
            // 
            this.cmbPassed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbPassed.FormattingEnabled = true;
            this.cmbPassed.Items.AddRange(new object[] {
            "Сдано",
            "Не сдано"});
            this.cmbPassed.Location = new System.Drawing.Point(170, 399);
            this.cmbPassed.Name = "cmbPassed";
            this.cmbPassed.Size = new System.Drawing.Size(375, 32);
            this.cmbPassed.TabIndex = 49;
            // 
            // cmbIdBooks
            // 
            this.cmbIdBooks.DataSource = this.booksTableBindingSource;
            this.cmbIdBooks.DisplayMember = "IdBook";
            this.cmbIdBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbIdBooks.FormattingEnabled = true;
            this.cmbIdBooks.Location = new System.Drawing.Point(170, 147);
            this.cmbIdBooks.Name = "cmbIdBooks";
            this.cmbIdBooks.Size = new System.Drawing.Size(375, 32);
            this.cmbIdBooks.TabIndex = 46;
            this.cmbIdBooks.ValueMember = "IdBook";
            // 
            // cmbIdStudents
            // 
            this.cmbIdStudents.DataSource = this.readerTableBindingSource;
            this.cmbIdStudents.DisplayMember = "IdStudent";
            this.cmbIdStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbIdStudents.FormattingEnabled = true;
            this.cmbIdStudents.Location = new System.Drawing.Point(210, 96);
            this.cmbIdStudents.Name = "cmbIdStudents";
            this.cmbIdStudents.Size = new System.Drawing.Size(335, 32);
            this.cmbIdStudents.TabIndex = 45;
            this.cmbIdStudents.ValueMember = "IdStudent";
            // 
            // Refresh
            // 
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.Location = new System.Drawing.Point(697, 381);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(56, 50);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Refresh.TabIndex = 44;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(25, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 24);
            this.label11.TabIndex = 43;
            this.label11.Text = "Сдано:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(25, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Дата возвращения:";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExport.Location = new System.Drawing.Point(568, 293);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(197, 43);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtNumInstances
            // 
            this.txtNumInstances.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumInstances.Location = new System.Drawing.Point(360, 198);
            this.txtNumInstances.Name = "txtNumInstances";
            this.txtNumInstances.Size = new System.Drawing.Size(185, 30);
            this.txtNumInstances.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(25, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Дата выдачи:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Вид взятия*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Код книги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Код записи:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Код студента:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Кол-во взятых экземпляров:";
            // 
            // txtIdTaking
            // 
            this.txtIdTaking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIdTaking.Location = new System.Drawing.Point(175, 44);
            this.txtIdTaking.Name = "txtIdTaking";
            this.txtIdTaking.Size = new System.Drawing.Size(370, 30);
            this.txtIdTaking.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(568, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 43);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(568, 104);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(197, 43);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Редактировать";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(568, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(568, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewJournal
            // 
            this.dataGridViewJournal.AllowUserToAddRows = false;
            this.dataGridViewJournal.AllowUserToDeleteRows = false;
            this.dataGridViewJournal.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewJournal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournal.Location = new System.Drawing.Point(29, 125);
            this.dataGridViewJournal.Name = "dataGridViewJournal";
            this.dataGridViewJournal.ReadOnly = true;
            this.dataGridViewJournal.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewJournal.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewJournal.RowTemplate.Height = 24;
            this.dataGridViewJournal.Size = new System.Drawing.Size(1702, 401);
            this.dataGridViewJournal.TabIndex = 43;
            this.dataGridViewJournal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJournal_CellClick);
            // 
            // useTableTableAdapter
            // 
            this.useTableTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 79);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1636, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬   Журнал записей   ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬";
            // 
            // readerTableBindingSource
            // 
            this.readerTableBindingSource.DataMember = "ReaderTable";
            this.readerTableBindingSource.DataSource = this.dB_LibraryCollegeDataSet;
            // 
            // readerTableTableAdapter
            // 
            this.readerTableTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableBindingSource
            // 
            this.booksTableBindingSource.DataMember = "BooksTable";
            this.booksTableBindingSource.DataSource = this.dB_LibraryCollegeDataSet;
            // 
            // booksTableTableAdapter
            // 
            this.booksTableTableAdapter.ClearBeforeFill = true;
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1760, 1006);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewJournal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1778, 1053);
            this.MinimumSize = new System.Drawing.Size(1778, 1028);
            this.Name = "Journal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Journal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LibraryCollegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useTableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbCriteria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumInstances;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdTaking;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewJournal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.ComboBox cmbPassed;
        private System.Windows.Forms.ComboBox cmbIdBooks;
        private System.Windows.Forms.ComboBox cmbIdStudents;
        private System.Windows.Forms.ComboBox cmbWhereRead;
        private System.Windows.Forms.RadioButton rbtPassed;
        private System.Windows.Forms.RadioButton rbtDataEnd;
        private System.Windows.Forms.RadioButton rbtDateBegin;
        private System.Windows.Forms.RadioButton rbtWhere;
        private System.Windows.Forms.RadioButton rbtBook;
        private System.Windows.Forms.RadioButton rbtNum;
        private System.Windows.Forms.RadioButton rbtIdTaking;
        private System.Windows.Forms.RadioButton rbtIdStudent;
        private DB_LibraryCollegeDataSet dB_LibraryCollegeDataSet;
        private System.Windows.Forms.BindingSource useTableBindingSource;
        private DB_LibraryCollegeDataSetTableAdapters.UseTableTableAdapter useTableTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDateEnd;
        private System.Windows.Forms.DateTimePicker txtDateBegin;
        private System.Windows.Forms.BindingSource useTableBindingSource1;
        private System.Windows.Forms.BindingSource readerTableBindingSource;
        private DB_LibraryCollegeDataSetTableAdapters.ReaderTableTableAdapter readerTableTableAdapter;
        private System.Windows.Forms.BindingSource booksTableBindingSource;
        private DB_LibraryCollegeDataSetTableAdapters.BooksTableTableAdapter booksTableTableAdapter;
    }
}