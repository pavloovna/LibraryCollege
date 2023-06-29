namespace LibraryCollege.Forms
{
    partial class AddJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJournal));
            this.btnFilter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumInstances = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIdStudents = new System.Windows.Forms.ComboBox();
            this.readerTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_LibraryCollegeDataSet = new LibraryCollege.DB_LibraryCollegeDataSet();
            this.readerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibraryCollegeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIdBooks = new System.Windows.Forms.ComboBox();
            this.booksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbWhereRead = new System.Windows.Forms.ComboBox();
            this.cmbPassed = new System.Windows.Forms.ComboBox();
            this.booksTableTableAdapter = new LibraryCollege.DB_LibraryCollegeDataSetTableAdapters.BooksTableTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.readerTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableTableAdapter = new LibraryCollege.DB_LibraryCollegeDataSetTableAdapters.ReaderTableTableAdapter();
            this.booksTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtDateBegin = new System.Windows.Forms.DateTimePicker();
            this.txtDateEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LibraryCollegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryCollegeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Location = new System.Drawing.Point(221, 483);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(176, 43);
            this.btnFilter.TabIndex = 73;
            this.btnFilter.Text = "Сохранить";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(29, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 24);
            this.label11.TabIndex = 89;
            this.label11.Text = "Сдано:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(29, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 24);
            this.label10.TabIndex = 88;
            this.label10.Text = "Дата возврата:";
            // 
            // txtNumInstances
            // 
            this.txtNumInstances.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumInstances.Location = new System.Drawing.Point(366, 222);
            this.txtNumInstances.Name = "txtNumInstances";
            this.txtNumInstances.Size = new System.Drawing.Size(208, 30);
            this.txtNumInstances.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(29, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 83;
            this.label9.Text = "Дата выдачи:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 81;
            this.label6.Text = "Вид выдачи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Код книги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 75;
            this.label4.Text = "Код студента:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(29, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 24);
            this.label7.TabIndex = 77;
            this.label7.Text = "Кол-во взятых экземпляров:";
            // 
            // cmbIdStudents
            // 
            this.cmbIdStudents.DataSource = this.readerTableBindingSource2;
            this.cmbIdStudents.DisplayMember = "IdStudent";
            this.cmbIdStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbIdStudents.FormattingEnabled = true;
            this.cmbIdStudents.Location = new System.Drawing.Point(210, 119);
            this.cmbIdStudents.Name = "cmbIdStudents";
            this.cmbIdStudents.Size = new System.Drawing.Size(364, 32);
            this.cmbIdStudents.TabIndex = 90;
            this.cmbIdStudents.ValueMember = "IdStudent";
            // 
            // readerTableBindingSource2
            // 
            this.readerTableBindingSource2.DataMember = "ReaderTable";
            this.readerTableBindingSource2.DataSource = this.dB_LibraryCollegeDataSet;
            // 
            // dB_LibraryCollegeDataSet
            // 
            this.dB_LibraryCollegeDataSet.DataSetName = "DB_LibraryCollegeDataSet";
            this.dB_LibraryCollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerTableBindingSource
            // 
            this.readerTableBindingSource.DataMember = "ReaderTable";
            this.readerTableBindingSource.DataSource = this.dBLibraryCollegeDataSetBindingSource;
            // 
            // dBLibraryCollegeDataSetBindingSource
            // 
            this.dBLibraryCollegeDataSetBindingSource.DataSource = this.dB_LibraryCollegeDataSet;
            this.dBLibraryCollegeDataSetBindingSource.Position = 0;
            // 
            // cmbIdBooks
            // 
            this.cmbIdBooks.DataSource = this.booksTableBindingSource;
            this.cmbIdBooks.DisplayMember = "IdBook";
            this.cmbIdBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbIdBooks.FormattingEnabled = true;
            this.cmbIdBooks.Location = new System.Drawing.Point(210, 170);
            this.cmbIdBooks.Name = "cmbIdBooks";
            this.cmbIdBooks.Size = new System.Drawing.Size(364, 32);
            this.cmbIdBooks.TabIndex = 91;
            this.cmbIdBooks.ValueMember = "IdBook";
            // 
            // booksTableBindingSource
            // 
            this.booksTableBindingSource.DataMember = "BooksTable";
            this.booksTableBindingSource.DataSource = this.dBLibraryCollegeDataSetBindingSource;
            // 
            // cmbWhereRead
            // 
            this.cmbWhereRead.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbWhereRead.FormattingEnabled = true;
            this.cmbWhereRead.Items.AddRange(new object[] {
            "Абонемент",
            "Читальный зал"});
            this.cmbWhereRead.Location = new System.Drawing.Point(210, 270);
            this.cmbWhereRead.Name = "cmbWhereRead";
            this.cmbWhereRead.Size = new System.Drawing.Size(364, 32);
            this.cmbWhereRead.TabIndex = 92;
            // 
            // cmbPassed
            // 
            this.cmbPassed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbPassed.FormattingEnabled = true;
            this.cmbPassed.Items.AddRange(new object[] {
            "Сдано",
            "Не сдано"});
            this.cmbPassed.Location = new System.Drawing.Point(210, 421);
            this.cmbPassed.Name = "cmbPassed";
            this.cmbPassed.Size = new System.Drawing.Size(364, 32);
            this.cmbPassed.TabIndex = 93;
            // 
            // booksTableTableAdapter
            // 
            this.booksTableTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 100);
            this.panel1.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "▬▬▬▬ Добавление записи ▬▬▬▬";
            // 
            // readerTableBindingSource1
            // 
            this.readerTableBindingSource1.DataMember = "ReaderTable";
            this.readerTableBindingSource1.DataSource = this.dB_LibraryCollegeDataSet;
            // 
            // readerTableTableAdapter
            // 
            this.readerTableTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableBindingSource1
            // 
            this.booksTableBindingSource1.DataMember = "BooksTable";
            this.booksTableBindingSource1.DataSource = this.dB_LibraryCollegeDataSet;
            // 
            // txtDateBegin
            // 
            this.txtDateBegin.CustomFormat = "dd.MM.yyyy";
            this.txtDateBegin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateBegin.Location = new System.Drawing.Point(210, 321);
            this.txtDateBegin.Name = "txtDateBegin";
            this.txtDateBegin.Size = new System.Drawing.Size(364, 30);
            this.txtDateBegin.TabIndex = 99;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.CustomFormat = "dd.MM.yyyy";
            this.txtDateEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateEnd.Location = new System.Drawing.Point(210, 372);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(364, 30);
            this.txtDateEnd.TabIndex = 100;
            // 
            // AddJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 545);
            this.Controls.Add(this.txtDateEnd);
            this.Controls.Add(this.txtDateBegin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbPassed);
            this.Controls.Add(this.cmbWhereRead);
            this.Controls.Add(this.cmbIdBooks);
            this.Controls.Add(this.cmbIdStudents);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumInstances);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddJournal";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LibraryCollegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryCollegeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumInstances;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIdStudents;
        private System.Windows.Forms.ComboBox cmbIdBooks;
        private System.Windows.Forms.ComboBox cmbWhereRead;
        private System.Windows.Forms.ComboBox cmbPassed;
        private System.Windows.Forms.BindingSource dBLibraryCollegeDataSetBindingSource;
        private DB_LibraryCollegeDataSet dB_LibraryCollegeDataSet;
        private System.Windows.Forms.BindingSource readerTableBindingSource;
        private System.Windows.Forms.BindingSource booksTableBindingSource;
        private DB_LibraryCollegeDataSetTableAdapters.BooksTableTableAdapter booksTableTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource readerTableBindingSource1;
        private DB_LibraryCollegeDataSetTableAdapters.ReaderTableTableAdapter readerTableTableAdapter;
        private System.Windows.Forms.BindingSource booksTableBindingSource1;
        private System.Windows.Forms.DateTimePicker txtDateBegin;
        private System.Windows.Forms.DateTimePicker txtDateEnd;
        private System.Windows.Forms.BindingSource readerTableBindingSource2;
    }
}