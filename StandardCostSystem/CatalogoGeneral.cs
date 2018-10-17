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

    public partial class CatalogoGeneral : Form
    {
        
        MySqlConnection dbcon = new MySqlConnection("SERVER=localhost;" + "DATABASE=scores;" + "UID=root;" + "PASSWORD=Unity2018;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;


        public CatalogoGeneral()
        {
            InitializeComponent();
            
        }

        private void CatalogoGeneral_Load(object sender, EventArgs e)
        {
            string query = "SELECT ID_Company, Name_Company FROM scs.companies";
            fillCombo(cbCompanies, query, "Name_Company", "ID_Company");
            cbCompanies_SelectedIndexChanged(null, null);
            cbAreas_SelectedIndexChanged(null, null);
         
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



        private void cbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCompany;
            Int32.TryParse(cbCompanies.SelectedValue.ToString(), out idCompany);
            string query = "SELECT ID_Company, ID_Area, Name_Area FROM scs.areas WHERE ID_Company = " + idCompany;
            fillCombo(cbAreas, query, "Name_Area", "ID_Area");
            dataGridView_Registers.DataSource = getData(query);
        }

        private void cbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCompany;
            int idArea;
            Int32.TryParse(cbCompanies.SelectedValue.ToString(), out idCompany);
            Int32.TryParse(cbAreas.SelectedValue.ToString(), out idArea);
            string query = "SELECT ID_Company, ID_Area, ID_SubArea, Name_SubArea FROM scs.subareas WHERE ID_Company = " + idCompany + " AND ID_Area = " + idArea;
            fillCombo(cbSubAreas, query, "Name_SubArea", "ID_SubArea");
            dataGridView_Registers.DataSource = getData(query);
        }
    }
}
