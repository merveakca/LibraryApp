namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            if (!(txtCreatedBook.Text == "" || txtCreatedWriter.Text == ""))
            {
                dgBookList.Rows.Add(dgBookList.Rows.Count + 1, txtCreatedBook.Text, txtCreatedWriter.Text, true);
                txtCreatedBook.Text = "";
                txtCreatedWriter.Text = "";
            }
            else
            {
                MessageBox.Show("Yazar ve Kitap ad� bo� b�rak�lamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMemberCreate_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            if (!(txtMemberName.Text == "" || txtPhoneNumber.Text == "" || txtAdress.Text == ""))
            {
                dgMemberList.Rows.Add(dgMemberList.Rows.Count + 1, txtMemberName.Text, txtPhoneNumber.Text, txtAdress.Text);
                txtMemberName.Text = "";
                txtPhoneNumber.Text = "";
                txtAdress.Text = "";
            }
            else
            {
                MessageBox.Show("�ye Bilgileri Bo� Ge�ilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgMemberList.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dgMemberList.SelectedRows)
                {
                    dgMemberList.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Silmek �stedi�iniz �ye Sat�r�n� Se�iniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "D�zenle")
            {
                dgMemberList.ReadOnly = false;
                btnEdit.Text = "D�zenlemeyi Tamamla!";
            }
            else
            {
                dgMemberList.ReadOnly = true;
                btnEdit.Text = "D�zenle";
            }
        }

        private void dgMemberList_SelectionChanged(object sender, EventArgs e)
        {
            dgMemberList.ClearSelection();
        }
    }
}