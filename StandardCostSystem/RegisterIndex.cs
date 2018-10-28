using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StandardCostSystem
{
    public partial class RegisterIndex : Form
    {
        MySqlConnection dbcon = new MySqlConnection("SERVER=localhost;" + "DATABASE=scores;" + "UID=root;" + "PASSWORD=Unity2018;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        public RegisterIndex()
        {
            InitializeComponent();
        }

        private void RegisterIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
