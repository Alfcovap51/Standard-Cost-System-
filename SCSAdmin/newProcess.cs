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
    public partial class newExpense : Form
    {

        MySqlConnection dbcon = new MySqlConnection("SERVER=localhost;" + "DATABASE=scores;" + "UID=root;" + "PASSWORD=Unity2018;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        public newExpense()
        {
            InitializeComponent();
        }

        private void newExpense_Load(object sender, EventArgs e)
        {
            string query = "SELECT ID_Area, Name_Area FROM scs.areas WHERE ID_Company = " + getCompany();
            lstAreas.DataSource = getData(query);
            lstAreas.DisplayMember = "Name_Area";
            lstAreas.ValueMember = "ID_Area";
            lstAreas_SelectedValueChanged(null, null);
            lstSubAreas_SelectedValueChanged(null, null);
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

        

        private void lstAreas_SelectedValueChanged(object sender, EventArgs e)
        {
            lblSubAreas.Text = "SubAreas en " + lstAreas.Text;
            int idCompany = getCompany();
            int idArea;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out idArea);
            string query = "SELECT Name_SubArea, ID_SubArea FROM scs.subareas WHERE ID_Company = " + getCompany() + " AND ID_Area = " + idArea;
            lstSubAreas.DataSource = getData(query);
            lstSubAreas.DisplayMember = "Name_SubArea";
            lstSubAreas.ValueMember = "ID_SubArea";
        }

        private void loadExpensesList()
        {
            int idCompany = getCompany();
            int idArea;
            int idSubArea;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out idArea);
            Int32.TryParse(lstSubAreas.SelectedValue.ToString(), out idSubArea);
            string query = "SELECT Number_Expense, CONCAT( Number_Expense, ' - ', Description, '  $', Budget) AS Expense  FROM scs.expenses WHERE ID_Company = " + getCompany() + " AND ID_Area = " + idArea + " AND ID_SubArea = " + idSubArea;


            lstExpenses.DataSource = getData(query);
            lstExpenses.DisplayMember = "Expense";
            lstExpenses.ValueMember = "Number_Expense";
            dbcon.Close();
        }

        private void lstSubAreas_SelectedValueChanged(object sender, EventArgs e)
        {
            int idCompany = getCompany();
            int idArea;
            int idSubArea;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out idArea);
            Int32.TryParse(lstSubAreas.SelectedValue.ToString(), out idSubArea);
            string query = "SELECT Number_Expense, CONCAT( Number_Expense, ' - ', Description, '  $', Budget) AS Expense FROM scs.expenses WHERE ID_Company = " + getCompany() + " AND ID_Area = " + idArea + " AND ID_SubArea = " + idSubArea;
            lstExpenses.DataSource = getData(query);
            lstExpenses.DisplayMember = "Expense";
            lstExpenses.ValueMember = "Number_Expense";
            
        }

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            
            int idCompany = getCompany();
            int idArea, idSubArea;
            Int32.TryParse(lstAreas.SelectedValue.ToString(), out idArea);
            Int32.TryParse(lstSubAreas.SelectedValue.ToString(), out idSubArea);
           
            
            int idExpense = Convert.ToInt32(txtIDExpense.Text);
            int expenseBudget = Convert.ToInt32(txtBudget.Text);
            string newExpenseDescription = txtExpense.Text;

            try
            {
                dbcon.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            DialogResult result = MessageBox.Show("Crearas un Gasto con el nombre: " + newExpenseDescription + " y ID: " + idExpense, "Confirmar nuevo Gasto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    String query = "INSERT INTO scs.expenses(ID_Company,ID_Area,ID_SubArea,ID_Expense,Number_Expense,Description,Budget) values(@ID_Company, @ID_Area, @ID_SubArea, @ID_Expense, @Number_Expense, @Description,@Budget)";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, dbcon);
                    cmd.Parameters.AddWithValue("ID_Company", idCompany);
                    cmd.Parameters.AddWithValue("ID_Area", idArea);
                    cmd.Parameters.AddWithValue("ID_SubArea", idSubArea);
                    cmd.Parameters.AddWithValue("ID_Expense", idExpense);
                    cmd.Parameters.AddWithValue("Number_Expense", idCompany.ToString() + idArea.ToString() + idSubArea.ToString() + "-" +idExpense.ToString());
                    cmd.Parameters.AddWithValue("Description", newExpenseDescription);
                    cmd.Parameters.AddWithValue("Budget", expenseBudget);
                    MySqlDataReader MyReader2;
                    MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Gasto Agregado");
                    MyReader2.Close();
                    dbcon.Close();
                    loadExpensesList();
                    

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
            string Number_Expense = lstExpenses.SelectedValue.ToString();
            string Description = lstSubAreas.Text;
            

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
                        String query = "DELETE FROM scs.expenses WHERE Number_Expense = @Number_Expense";
                        //Create Command
                        MySqlCommand cmd = new MySqlCommand(query, dbcon);

                        cmd.Parameters.AddWithValue("Number_Expense", Number_Expense);
                        MySqlDataReader MyReader2;
                        MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Gasto Eliminado");

                        dbcon.Close();
                        loadExpensesList();

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
