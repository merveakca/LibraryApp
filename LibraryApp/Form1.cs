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
                MessageBox.Show("Yazar ve Kitap adý boþ býrakýlamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Üye Bilgileri Boþ Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Silmek Ýstediðiniz Üye Satýrýný Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Düzenle")
            {
                dgMemberList.ReadOnly = false;
                btnEdit.Text = "Düzenlemeyi Tamamla!";
            }
            else
            {
                dgMemberList.ReadOnly = true;
                btnEdit.Text = "Düzenle";
            }
        }

        private void dgMemberList_SelectionChanged(object sender, EventArgs e)
        {
            dgMemberList.ClearSelection();
        }
    }
}