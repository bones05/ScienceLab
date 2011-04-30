using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Science
{
    public partial class SupplierDetails : Form
    {

        string suppID;
        int intsuppid;
        int stockitemid;
        int lastRecord;

        public SupplierDetails()
        {
            InitializeComponent();
        }

        public SupplierDetails(string sID, int equipId)
        {
            InitializeComponent();
            suppID = sID;
            intsuppid = Convert.ToInt32(suppID, 10);
            stockitemid = equipId;
        }

        private void supplierTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sciencedbDataSet);

        }

        private void supplierTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sciencedbDataSet);

        }

        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            //We don't need a time for the last purchase value.
            lastPurchaseDateTimePicker.Format = DateTimePickerFormat.Custom;
            lastPurchaseDateTimePicker.CustomFormat = "dd 'of' MMMM yyyy";

            string filterExp = "ID = '" + suppID + "'";
            supplierTableBindingSource.Filter = filterExp;

            sciencedbDataSet.SupplierTableDataTable set = this.sciencedbDataSet.SupplierTable;
            this.supplierTableTableAdapter.Fill(set);

            //Do the combo dance
            sciencedbDataSet.SupplierTableDataTable table = supplierTableTableAdapter.GetData();
            if (intsuppid > 1)
            {
                suppcombo.DataSource = table;
                suppcombo.DisplayMember = "SupplierName";
                suppcombo.ValueMember = "ID";
        }
  }
        public void updatecombobox()
        {

             object selectedItem = suppcombo.SelectedItem;
             DataRowView rowView = (DataRowView)selectedItem;
             DataRow row = rowView.Row;
             suppID = row.ItemArray[0].ToString();

             string filterExp = "ID = '" + suppID + "'";
             supplierTableBindingSource.Filter = filterExp;

             this.Update();
         
        }

        public void saveValues_Click(object sender, EventArgs e)
        {

            if (intsuppid > 0)
            {

                            string updatequery = "Update SupplierTable SET Cost = {0},Quantity = {1}, SupplierName = '{2}', LastPurchase='{3}' WHERE ID = {4}";
                
                updatequery = string.Format(updatequery, this.costTextBox.Text, this.quantityTextBox.Text, this.supplierNameTextBox.Text, this.lastPurchaseDateTimePicker.Value, intsuppid);
                runCommand(updatequery);

            }
            else
            {
                string insertquery = "Insert INTO supplierTable(Cost,Quantity,LastPurchase,SupplierName) Values({0},{1},'{2}','{3}')";
                insertquery = string.Format(insertquery, costTextBox.Text,quantityTextBox.Text,lastPurchaseDateTimePicker.Value,supplierNameTextBox.Text);
                runCommand(insertquery);
                
                //Get the next stockid from suppliertable
                lastRecord = 0;
                getlastitem();

                string updatesuppid = "Update EquipmentTable Set SupplierID = {0} WHERE id = {1}";
                updatesuppid = string.Format(updatesuppid, lastRecord, stockitemid);
                runCommand(updatesuppid);

            }

            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                
        private void getlastitem()
        {
             //Get the next stockid from suppliertable
                //get last record so we know what the new item will be.
                OleDbConnection mycon2 = new OleDbConnection();
                mycon2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";

                lastRecord = 0;

                OleDbCommand cmdUpdate = new OleDbCommand();


                string sGetLastItem = "select TOP 1 * from SupplierTable order by id desc";
                OleDbCommand getToprecord = new OleDbCommand();
                getToprecord.CommandText = sGetLastItem;
                OleDbDataReader reader = null;

                try
                {
                    getToprecord.Connection = mycon2;
                    mycon2.Open();
                    reader = getToprecord.ExecuteReader();
                    while (reader.Read())
                    {
                        lastRecord = (int)reader[0];
                    }
                }
                finally
                {
                    mycon2.Close();
                    
                }

        }

        private void runCommand(string addCommand)
        {
            int iSqlStatus;

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";
            OleDbCommand oledbRunCommand = new OleDbCommand();
            oledbRunCommand.CommandText = addCommand;
            oledbRunCommand.CommandType = CommandType.Text;

            try
            {
                oledbRunCommand.Connection = connection;
                connection.Open();
                iSqlStatus = oledbRunCommand.ExecuteNonQuery();
                if (iSqlStatus != 0)
                {
                    MessageBox.Show("Record Updated");
                    //return false;

                }
                else
                {
                    MessageBox.Show("Failed to Update record. Please check the details entered.");
                    //return true;
                }

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

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            //suppcombo.SelectedItem;
            DataRowView row = (DataRowView)suppcombo.SelectedItem;
            object name = row[1];
            object myobject = row[1];
            
            //    suppcombo.SelectedValue[0]	Cannot apply indexing with [] to an expression of type 'object'	

        }

        private void suppcombo_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (suppcombo.SelectedIndex != -1)
                updatecombobox();

        }

    }
}