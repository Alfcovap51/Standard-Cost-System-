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

namespace SCSAdmin
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
            string query = "SELECT Number_Concept , CONCAT(Number_Concept,'   ',Description) AS Concept FROM scs.concepts WHERE ID_Company = " + getCompany();
            lstConcept.DataSource = getData(query);
            lstConcept.DisplayMember = "Concept";
            lstConcept.ValueMember = "Number_Concept";
        }

        public int getCompany()
        {
            int company;
            string query = "SELECT ID_Company FROM scs.companies WHERE Name_Company = @Company";
            try
            {
                dbcon.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Message: " + err.Message);
            }

            cmd = new MySqlCommand(query, dbcon);
            cmd.Parameters.AddWithValue("Company", GlobalClass.company);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            company = dataReader.GetInt32("ID_Company");
            dataReader.Close();
            dbcon.Close();
            return company;

        }

        public DataTable getData(string query)
        {

            cmd = new MySqlCommand(query, dbcon);
            adapter = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }



    }
}
