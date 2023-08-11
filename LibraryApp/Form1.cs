namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!(txtCreatedBook.Text == "" || txtCreatedWriter.Text == ""))
            {
                dgList.Rows.Add(dgList.Rows.Count + 1, txtCreatedBook.Text, txtCreatedWriter.Text, true);
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
            if (!(txtMemberName.Text == "" || txtPhoneNumber.Text == "" || txtAdress.Text == ""))
            {
                dgMember.Rows.Add(dgMember.Rows.Count + 1, txtMemberName.Text, txtPhoneNumber.Text, txtAdress.Text);
                txtMemberName.Text = "";
                txtPhoneNumber.Text = "";
                txtAdress.Text = "";
            }
            else
            {
                MessageBox.Show("Üye Bilgileri Boþ Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgMember.Rows)
            {
                dgMember.Rows.RemoveAt(row.Index);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Düzenle")
            {
                dgMember.ReadOnly = false;
                btnEdit.Text = "Düzenlemeyi Tamamla!";
            }
            else
            {
                dgMember.ReadOnly = true;
                btnEdit.Text = "Düzenle";
            }
        }
    }
}