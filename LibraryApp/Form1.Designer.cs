namespace LibraryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgBookList = new DataGridView();
            index = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            WriterName = new DataGridViewTextBoxColumn();
            IsAvalible = new DataGridViewTextBoxColumn();
            gbCreated = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtCreatedWriter = new TextBox();
            txtCreatedBook = new TextBox();
            btnCreateBook = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Index1 = new DataGridViewTextBoxColumn();
            LendingBook = new DataGridViewTextBoxColumn();
            Member = new DataGridViewTextBoxColumn();
            LendingDate = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox3 = new GroupBox();
            gbMember = new GroupBox();
            btnMemberCreate = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            txtAdress = new TextBox();
            txtMemberName = new TextBox();
            dgMemberList = new DataGridView();
            index2 = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Adress = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgBookList).BeginInit();
            gbCreated.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMemberList).BeginInit();
            SuspendLayout();
            // 
            // dgBookList
            // 
            dgBookList.AllowUserToAddRows = false;
            dgBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBookList.Columns.AddRange(new DataGridViewColumn[] { index, BookName, WriterName, IsAvalible });
            dgBookList.Location = new Point(17, 161);
            dgBookList.Name = "dgBookList";
            dgBookList.ReadOnly = true;
            dgBookList.RowHeadersWidth = 62;
            dgBookList.RowTemplate.Height = 33;
            dgBookList.Size = new Size(706, 249);
            dgBookList.TabIndex = 0;
            // 
            // index
            // 
            index.HeaderText = "#";
            index.MinimumWidth = 8;
            index.Name = "index";
            index.ReadOnly = true;
            index.Width = 30;
            // 
            // BookName
            // 
            BookName.HeaderText = "Book Name";
            BookName.MinimumWidth = 8;
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            BookName.Width = 250;
            // 
            // WriterName
            // 
            WriterName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WriterName.HeaderText = "Writer Name";
            WriterName.MinimumWidth = 8;
            WriterName.Name = "WriterName";
            WriterName.ReadOnly = true;
            // 
            // IsAvalible
            // 
            IsAvalible.HeaderText = "Is Avalible";
            IsAvalible.MinimumWidth = 8;
            IsAvalible.Name = "IsAvalible";
            IsAvalible.ReadOnly = true;
            IsAvalible.Width = 150;
            // 
            // gbCreated
            // 
            gbCreated.Controls.Add(label2);
            gbCreated.Controls.Add(dgBookList);
            gbCreated.Controls.Add(label1);
            gbCreated.Controls.Add(txtCreatedWriter);
            gbCreated.Controls.Add(txtCreatedBook);
            gbCreated.Controls.Add(btnCreateBook);
            gbCreated.Location = new Point(45, 64);
            gbCreated.Name = "gbCreated";
            gbCreated.Size = new Size(755, 427);
            gbCreated.TabIndex = 1;
            gbCreated.TabStop = false;
            gbCreated.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 6;
            label2.Text = "Yazarın Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 5;
            label1.Text = "Kitabın Adı";
            // 
            // txtCreatedWriter
            // 
            txtCreatedWriter.Location = new Point(121, 77);
            txtCreatedWriter.Name = "txtCreatedWriter";
            txtCreatedWriter.Size = new Size(441, 31);
            txtCreatedWriter.TabIndex = 4;
            // 
            // txtCreatedBook
            // 
            txtCreatedBook.Location = new Point(121, 40);
            txtCreatedBook.Name = "txtCreatedBook";
            txtCreatedBook.Size = new Size(441, 31);
            txtCreatedBook.TabIndex = 3;
            // 
            // btnCreateBook
            // 
            btnCreateBook.Location = new Point(568, 30);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(164, 91);
            btnCreateBook.TabIndex = 0;
            btnCreateBook.Text = "Ekle";
            btnCreateBook.UseVisualStyleBackColor = true;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(884, 583);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(719, 417);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Index1, LendingBook, Member, LendingDate, DueDate });
            dataGridView1.Location = new Point(6, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(706, 225);
            dataGridView1.TabIndex = 6;
            // 
            // Index1
            // 
            Index1.HeaderText = "#";
            Index1.MinimumWidth = 8;
            Index1.Name = "Index1";
            Index1.Width = 30;
            // 
            // LendingBook
            // 
            LendingBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LendingBook.HeaderText = "Lending Book";
            LendingBook.MinimumWidth = 8;
            LendingBook.Name = "LendingBook";
            // 
            // Member
            // 
            Member.HeaderText = "Member";
            Member.MinimumWidth = 8;
            Member.Name = "Member";
            Member.Width = 120;
            // 
            // LendingDate
            // 
            LendingDate.HeaderText = "Lending Date";
            LendingDate.MinimumWidth = 8;
            LendingDate.Name = "LendingDate";
            LendingDate.Width = 170;
            // 
            // DueDate
            // 
            DueDate.HeaderText = "Due Date";
            DueDate.MinimumWidth = 8;
            DueDate.Name = "DueDate";
            DueDate.Width = 120;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(94, 27);
            label3.Name = "label3";
            label3.Size = new Size(482, 58);
            label3.TabIndex = 7;
            label3.Text = "Ödünç Kitap Alanların Listesi";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(884, 76);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(719, 430);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = " ";
            // 
            // gbMember
            // 
            gbMember.Controls.Add(btnMemberCreate);
            gbMember.Controls.Add(label6);
            gbMember.Controls.Add(label5);
            gbMember.Controls.Add(label4);
            gbMember.Controls.Add(txtPhoneNumber);
            gbMember.Controls.Add(txtAdress);
            gbMember.Controls.Add(txtMemberName);
            gbMember.Controls.Add(dgMemberList);
            gbMember.Controls.Add(btnEdit);
            gbMember.Controls.Add(btnDelete);
            gbMember.Location = new Point(45, 497);
            gbMember.Name = "gbMember";
            gbMember.Size = new Size(755, 503);
            gbMember.TabIndex = 4;
            gbMember.TabStop = false;
            gbMember.Text = " ";
            // 
            // btnMemberCreate
            // 
            btnMemberCreate.Location = new Point(568, 47);
            btnMemberCreate.Name = "btnMemberCreate";
            btnMemberCreate.Size = new Size(112, 113);
            btnMemberCreate.TabIndex = 14;
            btnMemberCreate.Text = "Ekle";
            btnMemberCreate.UseVisualStyleBackColor = true;
            btnMemberCreate.Click += btnMemberCreate_Click;
            // 
            // label6
            // 
            label6.Location = new Point(30, 86);
            label6.Name = "label6";
            label6.Size = new Size(150, 38);
            label6.TabIndex = 13;
            label6.Text = "Telefon Numarası";
            // 
            // label5
            // 
            label5.Location = new Point(17, 113);
            label5.Name = "label5";
            label5.Size = new Size(130, 38);
            label5.TabIndex = 12;
            label5.Text = "Adres";
            // 
            // label4
            // 
            label4.Location = new Point(17, 23);
            label4.Name = "label4";
            label4.Size = new Size(139, 38);
            label4.TabIndex = 11;
            label4.Text = "İsim Soyisim";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(186, 86);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(322, 31);
            txtPhoneNumber.TabIndex = 10;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(186, 129);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(322, 31);
            txtAdress.TabIndex = 9;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(186, 30);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(322, 31);
            txtMemberName.TabIndex = 7;
            // 
            // dgMemberList
            // 
            dgMemberList.AllowUserToAddRows = false;
            dgMemberList.AllowUserToResizeRows = false;
            dgMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMemberList.Columns.AddRange(new DataGridViewColumn[] { index2, MemberName, PhoneNumber, Adress });
            dgMemberList.Location = new Point(26, 181);
            dgMemberList.Name = "dgMemberList";
            dgMemberList.ReadOnly = true;
            dgMemberList.RowHeadersWidth = 62;
            dgMemberList.RowTemplate.Height = 33;
            dgMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMemberList.Size = new Size(706, 225);
            dgMemberList.TabIndex = 6;
            dgMemberList.SelectionChanged += dgMemberList_SelectionChanged;
            // 
            // index2
            // 
            index2.HeaderText = "#";
            index2.MinimumWidth = 8;
            index2.Name = "index2";
            index2.ReadOnly = true;
            index2.Width = 30;
            // 
            // MemberName
            // 
            MemberName.HeaderText = "Name Surname";
            MemberName.MinimumWidth = 8;
            MemberName.Name = "MemberName";
            MemberName.ReadOnly = true;
            MemberName.Width = 180;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 180;
            // 
            // Adress
            // 
            Adress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Adress.HeaderText = "Adress";
            Adress.MinimumWidth = 8;
            Adress.Name = "Adress";
            Adress.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(398, 432);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 65);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(142, 432);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 65);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 1094);
            Controls.Add(gbMember);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(gbCreated);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgBookList).EndInit();
            gbCreated.ResumeLayout(false);
            gbCreated.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbMember.ResumeLayout(false);
            gbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgMemberList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgBookList;
        private GroupBox gbCreated;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox gbMember;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtCreatedBook;
        private Button btnCreateBook;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn WriterName;
        private DataGridViewTextBoxColumn IsAvalible;
        private Label label2;
        private Label label1;
        private TextBox txtCreatedWriter;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Index1;
        private DataGridViewTextBoxColumn LendingBook;
        private DataGridViewTextBoxColumn Member;
        private DataGridViewTextBoxColumn LendingDate;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridView dgMemberList;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtPhoneNumber;
        private TextBox txtAdress;
        private TextBox txtMemberName;
        private DataGridViewTextBoxColumn index2;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Adress;
        private Button btnMemberCreate;
    }
}