using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virtual_Class
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Add your connection here for now
            Database db=new Database(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tamas\Documents\GitHub\Virtual-Class\Virtual-Class\ServerDB.mdf;Integrated Security=True");
           // some testing...
            db.OpenConnection();
            db.InsertData("UserName", "LOL");
            db.InsertData("UserName", "LEL");
            db.ReadData("UserName");
            db.CloseConnection();
        }
    }
}
