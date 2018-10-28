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
    public partial class newSubArea : Form
    {

        MySqlConnection dbcon = new MySqlConnection("SERVER=localhost;" + "DATABASE=scores;" + "UID=root;" + "PASSWORD=Unity2018;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        public newSubArea()
        {
            InitializeComponent();
        }

        private void newSubArea_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT ID_Area, Name_Area FROM scs.areas WHERE ID_Company = " + getCompany();
            lstAreas.DataSource = getData(query);
            lstAreas.DisplayMember = "Name_Area";
            lstAreas.ValueMember = "ID_Area";
            lstAreas_SelectedIndexChanged(null, null);
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

       
        private void lstAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSubAreas.Text = "SubAreas en " + lstAreas.Text;
            
           
        }

        private void lstAreas_SelectedValueChanged(object sender, EventArgs e)
        {
            int idCompany = getCompany();
            int idArea;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out idArea);
            string query = "SELECT Number_SubArea, Name_SubArea FROM scs.subareas WHERE ID_Company = " + getCompany() + " AND ID_Area = " + idArea;
            lstSubAreas.DataSource = getData(query);
            lstSubAreas.DisplayMember = "Name_SubArea";
            lstSubAreas.ValueMember = "Number_SubArea";


        }

        private void loadSubAreasList()
        {
            int idCompany = getCompany();
            int idArea;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out idArea);
            string query = "SELECT Number_SubArea, Name_SubArea FROM scs.subareas WHERE ID_Company = " + getCompany() + " AND ID_Area = " + idArea;
            lstSubAreas.DataSource = getData(query);
            lstSubAreas.DisplayMember = "Name_SubArea";
            lstSubAreas.ValueMember = "Number_SubArea";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCompany = getCompany();
            int idArea;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out idArea);
            int newSubAreaID = Convert.ToInt32(txtIDSubArea.Text);
            string newSubAreaName = txtNameSubArea.Text;

            try
            {
                dbcon.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            DialogResult result = MessageBox.Show("Crearas una nueva Area con el nombre: " + newSubAreaName + " y ID: " + newSubAreaID, "Confirmar nueva Area", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    String query = "INSERT INTO scs.subareas(ID_Company,ID_Area,ID_SubArea,Number_SubArea,Name_SubArea) values(@ID_Company, @ID_Area, @ID_SubArea, @Number_SubArea, @Name_SubArea)";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);
                    cmd.Parameters.AddWithValue("ID_Company", idCompany);
                    cmd.Parameters.AddWithValue("ID_Area", idArea);
                    cmd.Parameters.AddWithValue("ID_SubArea", newSubAreaID);
                    cmd.Parameters.AddWithValue("Number_SubArea", idCompany.ToString() + idArea.ToString() + newSubAreaID.ToString());
                    cmd.Parameters.AddWithValue("Name_SubArea", newSubAreaName);
                    MySqlDataReader MyReader2;
                    MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Area Agregada");
                    loadSubAreasList();
                    dbcon.Close();
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message);
                    dbcon.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Number_SubArea;
            string Name_SubArea = lstSubAreas.Text;
            Int32.TryParse(lstSubAreas.SelectedValue.ToString(), out Number_SubArea);

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
                DialogResult result = MessageBox.Show("Se eliminara: " + Name_SubArea + " de la lista de Areas", "Eliminar Area", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    try
                    {
                        String query = "DELETE FROM scs.subareas WHERE Number_SubArea = @Number_SubArea";
                        //Create Command
                        MySqlCommand cmd = new MySqlCommand(query, dbcon);

                        cmd.Parameters.AddWithValue("Number_SubArea", Number_SubArea);
                        MySqlDataReader MyReader2;
                        MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Area Eliminada");

                        dbcon.Close();
                        loadSubAreasList();

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
