using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;


namespace Science
{
    public partial class WelcomeForm : Form
    {
        DataTable welcomegrid = new DataTable();

        public WelcomeForm()
        {
            /*
            string filePath = @"C:\Database\sciencedb.accdb";
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}";//C:\Users\Shannon\Desktop\sciencedb.accdb";
            connString = string.Format(connString, filePath);
            */
            OleDbConnection connString = new OleDbConnection();
            connString.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";
            //Properties.Settings.Default.sciencedbConnectionString = connString;

            InitializeComponent();
        }

        private void equipmentTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.equipmentTableBindingSource.EndEdit();
//            this.tableAdapterManager.UpdateAll(this.sciencedbDataSet);

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sciencedbDataSet.EquipmentTable' table. You can move, or remove it, as needed.
          //  this.equipmentTableTableAdapter.Fill(this.sciencedbDataSet.EquipmentTable);
            string getrecords = "Select EquipmentName, Description, OperatingNotes, ID From EquipmentTable";
            fillgv(getrecords);
        }

        private void equipmentTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridView gv = (DataGridView)sender;
                DataGridViewRow row = gv.Rows[e.RowIndex];

                int itemId = (int)row.Cells["ID"].Value;
                
                Form itemDetails = new EquipmentDetails(itemId);
                itemDetails.Show();
            }
        }
        
        private void equipmentTableDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            /*DataGridView gv = (DataGridView)sender;
            foreach (DataGridViewRow row in gv.Rows)
                row.Cells["Information"].Value = "more";
            //row.Cells[4].Value = "more";
            //int i;
           */
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            filterText();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            filterText();
        }

        private void filterText()
        {
            string filterText = string.Empty;

            string textEntered = searchTextBox.Text;

            filterText = "EquipmentName like '%{0}%'";
            if (textEntered.Contains("*") || textEntered.Contains("&") || textEntered.Contains("^") || textEntered.Contains("%") || textEntered.Contains("~") || textEntered.Contains("`") || textEntered.Contains("#") || textEntered.Contains("/") || textEntered.Contains("?"))
            {
                searchTextBox.Text = searchTextBox.Text.Substring(0, searchTextBox.Text.Length - 1);
                MessageBox.Show("Invalid Character");
                
            }
            string filterTextbox = CleanInput(searchTextBox.Text);
            filterText = string.Format(filterText, filterTextbox);

            //equipmentTableBindingSource.Filter = filterText;
            equipmentTableDataGridView.Update();
        }

        static string CleanInput(string strIn)
        {
            // Replace invalid characters with empty strings.
            return Regex.Replace(strIn, @"[^\w\.@-]%*`~&()^", "");
        }


        private void WelcomeForm_Activated(object sender, EventArgs e)
        {
          //  this.equipmentTableTableAdapter.Fill(this.sciencedbDataSet.EquipmentTable);
            // Uncomment to indicate refresh counter
            //   label2.Text += "1 ";

        }

        private void addEquipment_Click(object sender, EventArgs e)
        {
            //EquipmentDetails addNew = new EquipmentDetails();
            //addNew.Show();
            addequipment addnew = new addequipment();
            addnew.Show();
        }

        private void newlocbutton_Click(object sender, EventArgs e)
        {
            newphysicallocation newloc = new newphysicallocation();
            newloc.Show();
        }


        public void fillgv(string query)
        {

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";
            OleDbCommand oledbRunCommand = new OleDbCommand();
            oledbRunCommand.CommandText = query;
            oledbRunCommand.CommandType = CommandType.Text;
            oledbRunCommand.Connection = connection;

            //create an OleDbDataAdapter to execute the query
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connection);

            //create a command builder
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            //create a DataTable to hold the query results
//            welcomegrid = new DataTable();
            
            //fill the DataTable
            dAdapter.Fill(welcomegrid);
            
            welcomegrid.Columns.Add("Information", typeof(String));
            for (int i = 0; i < welcomegrid.Rows.Count; i++)
            {
                welcomegrid.Rows[i]["information"] = "more";
                //DataRow row = welcomegrid.Rows[i];
                //row["Information"] = "more";
            }
            
            //the DataGridView
            //DataGridView dgView = new DataGridView();
            //BindingSource to sync DataTable and DataGridView
            //BindingSource bSource = new BindingSource();

            //set the BindingSource DataSource
            //bSource.DataSource = welcomegrid;
            
            //set the DataGridView DataSource
            equipmentTableDataGridView.DataSource = welcomegrid;
            equipmentTableDataGridView.Columns[0].Visible = false;
            connection.Close();
            

            
        }
       /* 
        public void tableselect(string sqlCommand)
        {

            //    stringgplresult = string.Empty;
       //     DataTable physicaltable = new DataTable();
         //   physicaltable.Columns.Add("Title1");
           // DataRow row;
            
            OleDbConnection mycon2 = new OleDbConnection();
            mycon2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";

            string sGetItem = sqlCommand;
            OleDbCommand getrecord = new OleDbCommand();
            getrecord.CommandText = sGetItem;
            OleDbDataReader reader = null;

            try
            {
                getrecord.Connection = mycon2;
                mycon2.Open();
                reader = getrecord.ExecuteReader();
                welcomegrid.Load(reader);
               
                int i = 0;
                while (reader.Read())
                {
                    row = physicaltable.NewRow();
                    row[0] = reader[0];
                    physicaltable.Rows.Add(row);
                    i++;

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                mycon2.Close();
            }
            //foreach datarow in physicaltable do $query
            //Match physical ID and insert in datagrid

            int y = 0;
            foreach (DataRow xy in physicaltable.Rows)
            {
                string filldatagrid = "Select RoomNumber, [Section], [Column], [Shelf] from LocationTable where PhysicalLocation =" + xy[y].ToString();
                fillgv(filldatagrid);
            }
            

        }
        */
    }
}
