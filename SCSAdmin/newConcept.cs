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
    public partial class newConcept : Form
    {

        MySqlConnection dbcon = new MySqlConnection("SERVER=localhost;" + "DATABASE=scores;" + "UID=root;" + "PASSWORD=Unity2018;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        public newConcept()
        {
            InitializeComponent();
        }

        private void newExpense_Load(object sender, EventArgs e)
        {
            loadConceptsList();
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
            dbcon.Dispose();
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


        private void loadConceptsList()
        {
            int idCompany = getCompany();
            string query = "SELECT Number_Concept , CONCAT(Number_Concept,'   ',Description) AS Concept FROM scs.concepts WHERE ID_Company = " + getCompany();

            lstConcepts.DataSource = getData(query);
            lstConcepts.DisplayMember = "Concept";
            lstConcepts.ValueMember = "Number_Concept";
            dbcon.Close();
        }

     

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            
            int idCompany = getCompany();
            int idConcept = Convert.ToInt32(txtIDConcept.Text);
            string newConceptDescription = txtConcept.Text;

            try
            {
                dbcon.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            DialogResult result = MessageBox.Show("Crearas un Concepto con el nombre: " + newConceptDescription + " y ID: " + idConcept, "Confirmar nuevo Gasto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    String query = "INSERT INTO scs.concepts(Number_Concept,Description) values(@Number_Concept, @Description)";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);
                    cmd.Parameters.AddWithValue("Number_Concept", idConcept);
                    cmd.Parameters.AddWithValue("Description", newConceptDescription);
                    
                    MySqlDataReader MyReader2;
                    MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Concepto Agregado");
                    MyReader2.Close();
                    dbcon.Close();
                    loadConceptsList();     

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message);
                    dbcon.Close();
                }

            }
        }

        private void btnEliminateExpense_Click(object sender, EventArgs e)
        {
            string ID_Concept = lstConcepts.SelectedValue.ToString();
            string Description = lstConcepts.Text;
            

            try
            {
                dbcon.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            if (dbcon.State == ConnectionState.Open)
            {
                DialogResult result = MessageBox.Show("Se eliminara: " + Description + " de la lista de Gastos", "Eliminar Gasto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    try
                    {
                        String query = "DELETE FROM scs.expenses WHERE Number_Concept = @Number_Concept";
                        //Create Command
                        MySqlCommand cmd = new MySqlCommand(query, dbcon);

                        cmd.Parameters.AddWithValue("Number_Concept", lstConcepts.SelectedValue);
                        MySqlDataReader MyReader2;
                        MyReader2 = cmd.ExecuteReader();   // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Concepto Eliminado");

                        dbcon.Close();
                        loadConceptsList();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error: " + err.Message);
                        dbcon.Close();
                    }

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
