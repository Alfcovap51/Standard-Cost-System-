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
    public partial class newArea : Form
    {

        MySqlConnection dbcon = new MySqlConnection("SERVER=localhost;" + "DATABASE=scores;" + "UID=root;" + "PASSWORD=Unity2018;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;
        
        
        public newArea()
        {
            InitializeComponent();
            
        }

        private void newArea_Load(object sender, EventArgs e)
        {
            loadList();
            
        }

        public void loadList()
        {
           
            string query = "SELECT Number_Area, Name_Area FROM scs.areas WHERE ID_Company = " + getCompany();
            lstAreas.DataSource = getData(query);
            lstAreas.DisplayMember = "Name_Area";
            lstAreas.ValueMember = "Number_Area";
            dbcon.Close();
            dbcon.Dispose();
        }

        public DataTable getData(string query)
        {
           
            cmd = new MySqlCommand(query, dbcon);
            adapter = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            return table;
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

        private void btnNewArea_Click(object sender, EventArgs e)
        {
                int idCompany = getCompany();
                int newAreaID = Convert.ToInt32(txtNewAreaID.Text);
                string newAreaName = txtNewAreaName.Text;
            try
            {
                dbcon.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            if(dbcon.State == ConnectionState.Open)
            {
                DialogResult result = MessageBox.Show("Crearas una nueva Area con el nombre: " + newAreaName + " y ID: " + newAreaID, "Confirmar nueva Area", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    try
                    {
                        String query = "INSERT INTO scs.areas(ID_Company,ID_Area,Number_Area,Name_Area) values(@ID_Company, @ID_Area, @Number_Area, @Name_Area)";
                        //Create Command
                        MySqlCommand cmd = new MySqlCommand(query, dbcon);
                        cmd.Parameters.AddWithValue("ID_Company", idCompany);
                        cmd.Parameters.AddWithValue("ID_Area", newAreaID);
                        cmd.Parameters.AddWithValue("Number_Area", idCompany.ToString() + newAreaID.ToString());
                        cmd.Parameters.AddWithValue("Name_Area", newAreaName);
                        MySqlDataReader MyReader2;
                        MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Area Agregada");

                        dbcon.Close();
                        loadList();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error: " + err.Message);
                        dbcon.Close();
                    }
                    
                }

                
            }
           
                
            
        }

        private void btnDeleteArea_Click(object sender, EventArgs e)
        {
            int Number_Area;
            string Name_Area = lstAreas.Text;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out Number_Area);

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
                DialogResult result = MessageBox.Show("Se eliminara: " + Name_Area + " de la lista de Areas", "Eliminar Area", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    try
                    {
                        String query = "DELETE FROM scs.areas WHERE Number_Area = @Number_Area";
                        //Create Command
                        MySqlCommand cmd = new MySqlCommand(query, dbcon);
                       
                        cmd.Parameters.AddWithValue("Number_Area", Number_Area);
                        MySqlDataReader MyReader2;
                        MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Area Eliminada");

                        dbcon.Close();
                        loadList();
                        
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error: " + err.Message);
                        dbcon.Close();
                    }

                }


            }
        }
    }
}
