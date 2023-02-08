namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var countryLi = new List<String>();
            countryLi.Add("(Select)");
            countryLi.Add("Vietnam");
            countryLi.Add("Thailan");

            countries.DataSource = countryLi;
            countries.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String res = "Employee Name: " + fullName.Text +
                         "\nD.O.B: " + dob.Text +
                         "\nAddress: " + addr.Text +
                         "\nCity: " + city.Text +
                         "\nCountry: " + countries.SelectedItem.ToString() +
                         "\nQualification: " + quali.Text +
                         "\nPhone: " + phone.Text +
                         "\nEmail: " + email.Text +
                         "\nD.O.J: " + dateJoin.Text; 
            
            MessageBox.Show(res, "Employee's Information");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyDown += (s, ea) =>
                    {
                        if (ea.KeyCode != Keys.Enter) return;
                        ea.SuppressKeyPress = true;
                        SelectNextControl(ActiveControl, true, true, true, true);
                    };
                }
                else if (control is MaskedTextBox m)
                {
                    m.KeyDown += (s, ea) =>
                    {
                        if (ea.KeyCode != Keys.Enter) return;
                        ea.SuppressKeyPress = true;
                        SelectNextControl(ActiveControl, true, true, true, true);
                    };
                }
                else if (control is ComboBox c)
                {
                    c.KeyDown += (s, ea) =>
                    {
                        if (ea.KeyCode != Keys.Enter) return;
                        ea.SuppressKeyPress = true;
                        SelectNextControl(ActiveControl, true, true, true, true);
                    };
                }
                else if (control is DateTimePicker d)
                {
                    d.KeyDown += (s, ea) =>
                    {
                        if (ea.KeyCode != Keys.Enter) return;
                        ea.SuppressKeyPress = true;
                        SelectNextControl(ActiveControl, true, true, true, true);
                    };
                }
            }
        }

        private void fullName_Validated(object sender, EventArgs e)
        {

        }

        private void fullName_Leave(object sender, EventArgs e)
        {
           
        }

        private void dob_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dob_Validated(object sender, EventArgs e)
        {

        }

        private void dob_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
        }

        private void fullName_Enter(object sender, EventArgs e)
        {
        }

        private void dob_Leave(object sender, EventArgs e)
        {
           
        }
    }
}