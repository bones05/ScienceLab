using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO; 
using System.Drawing.Imaging;

namespace Science
{
    
    public partial class EquipmentDetails : Form
    {
        Dictionary<int, string> litems;
        Dictionary<int, string> items;
        Dictionary<string,string> locations;
        DataTable dTable = new DataTable();

        int stockItemId;
    //    int supplierNames_empty = 0;

        public EquipmentDetails()
        {
            InitializeComponent();
            //supplierIDTextBox.TextChanged += new EventHandler(supplierIDTextBox_TextChanged);
            loadSuppliers();
        }

        public EquipmentDetails(int itemId)
        {
            stockItemId = itemId;
            InitializeComponent();
           // supplierIDTextBox.TextChanged += new EventHandler(supplierIDTextBox_TextChanged);
        }

        void showitemid()
        {
            
            //InitializeComponent();
           // supplierIDTextBox.TextChanged += new EventHandler(supplierIDTextBox_TextChanged);
        }

        void loadSuppliers()
        {
            if (supplierNames.Items.Count < 1)
            {
                sciencedbDataSet.SupplierTableDataTable table = supplierTableTableAdapter1.GetData();
                
                litems = new Dictionary<int, string>();
                
                supplierNames.Items.Clear();
                litems.Add(supplierNames.Items.Count, "");
                supplierNames.Items.Add(""); //Add New here for default
                supplierNames.SelectedItem = "";

  /*              foreach (DataRow row in table.Rows)
                {
                    string supplierName = row["SupplierName"].ToString();
                    string supplierID = row["ID"].ToString();
                    litems.Add(supplierNames.Items.Count, supplierName);
                
                    supplierNames.Items.Add(supplierName);
                    supplierNames.SelectedItem = supplierName;
                }
    */        }
        }
/*
        void supplierIDTextBox_TextChanged(object sender, EventArgs e)
        {
            //sciencedbDataSetTableAdapters.SupplierTableTableAdapter supAdtr = new sciencedbDataSet.SupplierTableDataTable(); // tableAdapterManager.SupplierTableTableAdapter();
            sciencedbDataSet.SupplierTableDataTable table = supplierTableTableAdapter1.GetData(); //supAdtr.GetData();

            
            items = new Dictionary<int, string>();

            supplierNames.Items.Clear();
            items.Add(supplierNames.Items.Count, "");
            supplierNames.Items.Add(""); //Add New here for default
            supplierNames.SelectedItem = "";
            
            foreach (DataRow row in table.Rows)
                {
                    string supplierName = row["SupplierName"].ToString();
                    string supplierID = row["ID"].ToString();
                    int intsuppid = Convert.ToInt32(supplierID, 10);

                    //Should only add each/one supplier for this item.
                    //items.Add(supplierNames.Items.Count, supplierName);
                
                    items.Add(intsuppid, supplierName);
              //      supplierNames.Items.Add(supplierName);
                
                supplierNames.DisplayMember = supplierName;
                supplierNames.ValueMember = supplierID;
                    
                    if (supplierID == supplierIDTextBox.Text)
                    {
                        label1.Text = string.Empty;
                        label1.Text = row["Quantity"].ToString();
                        supplyCost.Text = "$" + row["Cost"].ToString();
                        if (!string.IsNullOrEmpty(row["LastPurchase"].ToString()))
                        {
                            DateTime lDate = (DateTime)row["LastPurchase"];
                            supplyDate.Text = lDate.ToString("d");
                        }
                         else
                              supplyDate.Text = string.Empty;
                          supplierNames.SelectedItem = supplierName;
                      }

                }
        }
        */


        private void loadequipmentdetails()
        {

        }

        private void equipmentTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sciencedbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            if (stockItemId > -1)
            {
                string filterExp = "ID = '" + stockItemId.ToString() + "'";
                equipmentTableBindingSource.Filter = filterExp;
    //            supplierNames_empty = 0;
                equipmentTableBindingNavigator.Visible = false;
            }
         
            this.equipmentTableTableAdapter.Fill(this.sciencedbDataSet.EquipmentTable);

            if (supplierNames_empty == 0)
            {
                supplierNames_empty = 1;
                supplierIDTextBox.Text = supplierNames.SelectedIndex.ToString(); //not sure what this does
               // supplierIDTextBox.Text = "";
            }
            */


            /* Attempt to use OLEDB Connection for location table
            string locationFilter = getLocationFilter();
         //   string locationFilter = getLocationFilter();
            locationTableBindingSource.Filter = locationFilter;
            locationTableDataGridView.Update();
            //locationTableBindingSource.Filter = "RoomID = '" + roomIDTextBox.Text + "'";
            this.locationTableTableAdapter.Fill(this.sciencedbDataSet.LocationTable);
             */

            //string loadlocations = "Select from LocationTable ([PhysicalLocation], [RoomNumber], [RoomDescription], [Shelf], [Column], [Section]) WHERE 
            
            /*
             * select stocklocationid from equipmenttable where id like stockid
             * 
             * select physicalid from locationlink where stocklocation like QUERY1
             * 
             * select * from locationtable where physicallocation like QUERY2
             *  
             * 
            */

            if (stockItemId > -1)
            {
                DataTable detailstable = new DataTable();
                DataRow detailsrow;

                //SQL query for required data, without the image. Was my initial thought on what may be wrong.
                string getequipdetails = "Select ID, EquipmentName, Description, OperatingNotes, SupplierID, StockLocation From EquipmentTable where ID =" + stockItemId;
                //This function gets the entire row from the DB and stores it directly into the Datatable
                detailstable = getrecords(getequipdetails);
                //Store the row into a datarow so we can get information by the column name.
                detailsrow = detailstable.Rows[0];

                //Assigning data the to required text boxes on the form.
                equipmentNameTextBox.Text = (string)detailsrow["EquipmentName"];
                descriptionTextBox.Text = (string)detailsrow["Description"];
                //At this point the code jumps back to 'equipmentTableDataGridView_CellContentClick' function in welcomeform.cs and completes
                //the function by displaying this form. Ignoring all code below this line. NFI why?
                //operatingNotesTextBox.Text = detailsrow["OperatingNotes"].ToString();
                supplierIDTextBox.Text = detailsrow["SupplierID"].ToString();

                DateTime date = DateTime.Now;
                operatingNotesTextBox.Text = date.ToString("D");

                //operatingNotesTextBox.Text = detailsrow["OperatingNotes"].ToString();

                //Remaining code to get data for Supplier Details and GridView, respectively.
               // detailstable.Clear();
                DataTable supplierstable = new DataTable();
                DataRow suppliersrow;

                string getsuppdetails = "Select * From SupplierTable where ID =" + supplierIDTextBox.Text;
                supplierstable = getrecords(getsuppdetails);
                suppliersrow = supplierstable.Rows[0];

                supplyCost.Text = (string)suppliersrow["Cost"];
                label1.Text = (string)suppliersrow["Quantity"];
                suppnamelbl.Text = (string)suppliersrow["SupplierName"];
            }

            //Get stock locationID
            string getstocklocid = "Select stocklocation from equipmenttable where id =" + stockItemId;
            int stocklocationid = sqlselect(getstocklocid);

            if (stocklocationid > 0)
            {
                //Get stock physicalID
                string getphysicallocid = "Select physicallocationnumber from locationlinktable where stocklocationnumber =" + stocklocationid;
                tableselect(getphysicallocid);

                 //foreach datarow in physicaltable do $query
                //Match physical ID and insert in datagrid
                                /*int y = 0;
                foreach (DataRow in physicaltable.Rows)
                {
                string filldatagrid = "Select RoomNumber, [Section], [Column], [Shelf] from LocationTable where PhysicalLocation =" + physicaltable.Rows[y];
                    someshit(filldatagrid);
                }
                */
            }
            
            this.showitemid();
            
            // TODO: This line of code loads data into the 'sciencedbDataSet.LocationTable' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'sciencedbDataSet.EquipmentTable' table. You can move, or remove it, as needed.

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
            
            //fill the DataTable
            dAdapter.Fill(dTable);

            //the DataGridView
            //DataGridView dgView = new DataGridView();
            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();

            //set the BindingSource DataSource
            bSource.DataSource = dTable;

            //set the DataGridView DataSource
            locationTableDataGridView.DataSource = bSource;
            connection.Close();
        }

        private void updategv(DataTable records)
        {
            DataTable dTable = records;
            BindingSource bSource = new BindingSource();

            //set the BindingSource DataSource
            bSource.DataSource = dTable;

            //set the DataGridView DataSource
            locationTableDataGridView.DataSource = bSource;
        }

        private string getLocationFilter()
        {
            sciencedbDataSet.LocationLinkTableDataTable links = this.locationLinkTableTableAdapter1.GetData();
            locations = new Dictionary<string, string>();

            int x = 0;
            //if (stockLocationTextBox.TextLength < 1)
              //  stockLocationTextBox.Text = x.ToString();
                if (stocklocationlabel.Text.Count() < 1) 
                    stocklocationlabel.Text = x.ToString();
            else
            {
                foreach (DataRow row in links.Rows)
                {
                    //if (row["StockLocationNumber"].ToString() == stockLocationTextBox.Text)
                        if (row["StockLocationNumber"].ToString() == stocklocationlabel.Text)
                        locations.Add(row["PhysicalLocationNumber"].ToString(), row["StockLocationNumber"].ToString());
                   // if ( Compare( row["StockLocationNUmber"].ToString(), stockLocationTextBox.Text, true) = 0
                }
            }

            string filterText = string.Empty;

            string filterString = "PhysicalLocation = '{0}'";


            foreach (string K in locations.Keys)
            {
                if (!string.IsNullOrEmpty(filterText))
                    filterText += " or ";

                filterText += string.Format(filterString, K);
            }

            if (string.IsNullOrEmpty(filterText))
                filterText = string.Format(filterString, "-1");

            return filterText;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Edit link
            Form supDetails = new SupplierDetails(supplierIDTextBox.Text, stockItemId);

                supDetails.Show();
        }

        private void supplierNames_SelectedIndexChanged(object sender, EventArgs e)
        {
       //     Shit Can only handle 1 supplier at this point.

            if (supplierNames.Items.Count > 1)
            {
                supplierIDTextBox.Text = supplierNames.SelectedValue.ToString();
                //supplierIDTextBox.Text = supplierNames.SelectedIndex.ToString();
                //supplierIDTextBox.Text = supplierNames.SelectedValue.ToString();
            if (supplierNames.SelectedIndex == 0)
            {
                supplierIDTextBox.Text = "";
                //label1.Text = string.Empty;
              //  supplyDate.Text = string.Empty;
            //    supplyCost.Text = string.Empty;
            }
            
            }

        }

        private void equipmentTableBindingNavigator_MouseClick(object sender, MouseEventArgs e)
        {
            string locationFilter = getLocationFilter();
            locationTableBindingSource.Filter = locationFilter;

            locationTableDataGridView.Update();
            
        }

 /*
  * Replaced with Label and moved up into Form_load
  private void stockLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            string locationFilter = getLocationFilter();
            locationTableBindingSource.Filter = locationFilter;

            locationTableDataGridView.Update();
        }
        */
  

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {


            string addCommand = "Update EquipmentTable Set EquipmentName = '{0}',Description = '{1}',OperatingNotes = '{2}' WHERE id =" + stockItemId;
            
            addCommand = string.Format(addCommand, equipmentNameTextBox.Text, descriptionTextBox.Text, operatingNotesTextBox.Text);
           // MessageBox.Show(descriptionTextBox.Text);
            runCommand(addCommand);
            //this.equipmentTableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.sciencedbDataSet);
            this.Validate();
            this.Close();
        }
        private void runCommand(string addCommand)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";
            OleDbCommand oledbRunCommand = new OleDbCommand();
            oledbRunCommand.CommandText = addCommand;
            oledbRunCommand.CommandType = CommandType.Text;
            oledbRunCommand.Connection = connection;

            try
            {
                connection.Open();
                oledbRunCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }

        }


        private void addnewLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int zero = 0;
            string sendzero = zero.ToString();

            Form supDetails = new SupplierDetails(sendzero, stockItemId);
           
            supDetails.Show();
        }
        /*
        private void EquipmentDetails_Activated(object sender, EventArgs e)
        {
        //    this.equipmentTableTableAdapter.Fill(this.sciencedbDataSet.EquipmentTable);
        //   MessageBox.Show("Activated");
        }
        */
        private void addlocbutton_Click(object sender, EventArgs e)
        {
            equipmentlocation loc = new equipmentlocation(stockItemId);
            loc.Show();
        }

  /*      void supplierIDTextBox_TextChanged(object sender, EventArgs e)
        {
            sciencedbDataSet.SupplierTableDataTable table = supplierTableTableAdapter1.GetData(); //supAdtr.GetData();


            items = new Dictionary<int, string>();
/*
            supplierNames.Items.Clear();
            items.Add(supplierNames.Items.Count, "");
            supplierNames.Items.Add(""); //Add New here for default
            supplierNames.SelectedItem = "";
            */
/*            foreach (DataRow row in table.Rows)
            {
                string supplierName = row["SupplierName"].ToString();
                string supplierID = row["ID"].ToString();
                int intsuppid = Convert.ToInt32(supplierID, 10);

                //Should only add each/one supplier for this item.
                //items.Add(supplierNames.Items.Count, supplierName);

                items.Add(intsuppid, supplierName);
                //      supplierNames.Items.Add(supplierName);

                if (supplierID == supplierIDTextBox.Text)
                {
                    
                    label1.Text = string.Empty;
                    label1.Text = row["Quantity"].ToString();
                    supplyCost.Text = "$" + row["Cost"].ToString();
                    suppnamelbl.Text = string.Empty;
                    suppnamelbl.Text = row["SupplierName"].ToString();
                    if (!string.IsNullOrEmpty(row["LastPurchase"].ToString()))
                    {
                        DateTime lDate = (DateTime)row["LastPurchase"];
                        supplyDate.Text = lDate.ToString("d");
                    }
                    else
                        supplyDate.Text = string.Empty;
                    supplierNames.SelectedItem = supplierName;
                }

            }
        }
*/
        public void updatePicture_Click(object sender, EventArgs e)
        {
            Form updatepics = new updatepics(stockItemId);

            updatepics.Show();
        }

        private void dellocbutton_Click(object sender, EventArgs e)
        {
            equipmentlocation loc = new equipmentlocation(stockItemId);
            loc.Show();
        }

        public DataTable getrecords(string sqlCommand)
        {
           
            //stringgplresult = string.Empty;
            DataTable physicaltable = new DataTable();
         //   physicaltable.Columns.Add("Title1");
//            DataRow row;

            OleDbConnection mycon2 = new OleDbConnection();
            mycon2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";

            //string sGetLastItem = sqlCommand;
            OleDbCommand getToprecord = new OleDbCommand();
            getToprecord.CommandText = sqlCommand;
            OleDbDataReader reader = null;
            
            try
            {
                getToprecord.Connection = mycon2;
                mycon2.Open();
                reader = getToprecord.ExecuteReader();

                physicaltable.Load(reader);
                /*
                while (reader.Read())
                {
                    row = physicaltable.NewRow();
                    row[0] = reader[0];
                    physicaltable.Rows.Add(row);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                mycon2.Close();
            }

           // DataTable table = physicaltable;
          //  DataRow row1 = physicaltable.Rows[0];
         //   stringgplresult = row1[0].ToString();

            return physicaltable;
        }//end fucn

        private int sqlselect(string selectquery)
            {
            OleDbConnection getconnection = new OleDbConnection();
            getconnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";

            int getrecordid = 0;

            string sGetItem = selectquery;
            OleDbCommand getrecord = new OleDbCommand();
            getrecord.CommandText = sGetItem;
            OleDbDataReader reader = null;

            try
            {
                getrecord.Connection = getconnection;
                getconnection.Open();
                reader = getrecord.ExecuteReader();
                while (reader.Read())
                {
                    getrecordid = (int)reader[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                getconnection.Close();

            }
            return getrecordid;
            }

        public void tableselect(string sqlCommand)
        {

//    stringgplresult = string.Empty;
            DataTable physicaltable = new DataTable();
            physicaltable.Columns.Add("Title1");
            DataRow row;

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
        /*
        public void getimage(int equipid)
        {
            byte[] ImageByte = null;

            MemoryStream MemStream = null;

            PictureBox PicBx = new PictureBox();

            object OB;

            string WorkingDirectory = Application.StartupPath + "\\";

            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + WorkingDirectory + "DBFile.mdb; Persist Security Info=True";

            cnction = new OleDbConnection(connString);

            cnction.Open();

            int ImageID = 6;

            sqlCommand = "SELECT ImageObject FROM ImagesTable WHERE ImageID = " + ImageID + "";

            comm = new OleDbCommand(sqlCommand, cnction);

            ImageByte = comm.ExecuteScalar();

            MemStream = new MemoryStream(ImageByte);

            PicBx.Image = Image.FromStream(MemStream);

        } //end func
        */
        } //end namespace
    }

