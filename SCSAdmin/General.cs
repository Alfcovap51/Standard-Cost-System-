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
    public partial class General : Form
    {
        MySqlConnection dbcon = new MySqlConnection("SERVER=localhost;" + "DATABASE=scores;" + "UID=root;" + "PASSWORD=Unity2018;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;
        
        public General()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT ID_Company, ID_Area, Name_Area FROM scs.areas WHERE ID_Company = " + getCompany();
            dtRegisters.DataSource = getData(query);
            fillCombo(cbAreas, query, "Name_Area", "ID_Area");
            cbAreas_SelectedIndexChanged(null, null);

            lblCompany.Text = GlobalClass.company;
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

        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            cmd = new MySqlCommand(query, dbcon);
            adapter = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        public DataTable getData(string query)
        {
            cmd = new MySqlCommand(query, dbcon);
            adapter = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void cbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCompany = getCompany();
            int idArea;
            //Int32.TryParse(getCompany(), out idCompany);
            Int32.TryParse(cbAreas.SelectedValue.ToString(), out idArea);
            string query = "SELECT ID_Company, ID_Area, ID_SubArea, Name_SubArea FROM scs.subareas WHERE ID_Company = " + idCompany + " AND ID_Area = " + idArea;
            fillCombo(cbSubAreas, query, "Name_SubArea", "ID_SubArea");
            dtRegisters.DataSource = getData(query);
        }

       
       
        
       
        private void cbSubAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCompany = getCompany();
            int idArea;
            int idSubArea;
            
            Int32.TryParse(cbAreas.SelectedValue.ToString(), out idArea);
            Int32.TryParse(cbSubAreas.SelectedValue.ToString(), out idSubArea);
            string query = "SELECT I, Name_Register, Cost  FROM scs.subareas WHERE ID_Company = " + idCompany + " AND ID_Area = " + idArea + " AND ID_SubArea = " + idSubArea;

            dtRegisters.DataSource = getData(query);
        }
       
        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newArea Area = new newArea();
            Area.Show();
            
        }

        private void subAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSubArea SubArea = new newSubArea();
            SubArea.Show();
        }

        

        public void refreshAreas()
        {
            string query = "SELECT ID_Company, ID_Area, Name_Area FROM scs.areas WHERE ID_Company = " + getCompany();
            dtRegisters.DataSource = getData(query);
            fillCombo(cbAreas, query, "Name_Area", "ID_Area");
        }

        private void btnActualizarCombos_Click(object sender, EventArgs e)
        {
            refreshAreas();

        }

        private void procesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newConcept Expense = new newConcept();
            Expense.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterIndex Register = new RegisterIndex();
            Register.Show();
        }
    }
}
