using System;
using System.Windows.Forms;

/*
 * This will be used to create a new user
 * Contents in the name, username, and password will be stored to a database
 * Once in the database (after you hit submit) the form should close and you should be on the original form to sign in
 */


namespace Chat
{
    public partial class New_User : Form
    {
        public New_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //There should be a database for user credentials and one for each user to hold message records
            MessageBox.Show("If implemented, a name, username, and password would be saved to the database and allow for signin");
            this.Close();
        }

        private void New_User_Load(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
