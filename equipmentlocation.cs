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
    public partial class equipmentlocation : Form
    {
        int stockID;
        int lastRecord;
        int rphysicalloc;
        int rlocationid;
        int gplresult;
        int delphysicalloc;
        int dellocationid;
        string stringgplresult;
        string sphysical;
        string slocationid;

        public equipmentlocation()
        {
            InitializeComponent();
        }

        public equipmentlocation(int stock)
        {
            InitializeComponent();
            stockID = stock;
        }

        private void equipmentlocation_Load(object sender, EventArgs e)
        {

            string sqlCommand = "select distinct roomnumber from locationtable";
            DataTable table = populateListBox(sqlCommand);
            foreach (DataRow row in table.Rows)
                roomnocombo.Items.Add(row[0]);

        }

        private void sectioncombo_load()
        {
            sectioncombo.Items.Clear();
            string sqlCommand = "select distinct [section] from locationtable where (RoomNumber like '" + 
                this.roomnocombo.Text + "')";

  //          sqlCommand = string.Format(sqlCommand, roomnocombo.Text);
            
            DataTable table = populateListBox(sqlCommand);
            foreach (DataRow row in table.Rows)
                sectioncombo.Items.Add(row[0]);

        }
        private void columncombo_load()
        {
            columncombo.Items.Clear();
            string sqlCommand = "select distinct [column] from locationtable where (RoomNumber like '" +
                this.roomnocombo.Text + "')";

            //            sqlCommand = string.Format(sqlCommand, roomnocombo.Text);

            DataTable table = populateListBox(sqlCommand);
            foreach (DataRow row in table.Rows)
                columncombo.Items.Add(row[0]);
        }
        private void shelfcombo_load()
        {
            shelfcombo.Items.Clear();
            string sqlCommand = "select distinct [shelf] from locationtable where (RoomNumber like '" +
                this.roomnocombo.Text + "')";

            //sqlCommand = string.Format(sqlCommand, roomnocombo.Text);

            DataTable table = populateListBox(sqlCommand);
            foreach (DataRow row in table.Rows)
                shelfcombo.Items.Add(row[0]);

        }

        private DataTable populateListBox(string sqlCommand)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Title");
            DataRow row;

            OleDbConnection mycon2 = new OleDbConnection();
            mycon2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";


            OleDbCommand cmdUpdate = new OleDbCommand();


            string sGetLastItem = sqlCommand;
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
                    row = table.NewRow();
                    row[0] = reader[0];
                    table.Rows.Add(row);
                }
            }
            finally
            {
                mycon2.Close();
            }

            return table;
        }

        private void roomnocombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectioncombo_load();
            columncombo_load();
            shelfcombo_load();
          
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            getlastitem();
            //need to check for equipmentid.location
            //if equipmenttable.stocklocation has no value no record is added.


            //Get the stocklocationid for the equipment item we are updating
            string getstockloc = "Select stocklocation from equipmenttable where id = {0}";
            getstockloc = string.Format(getstockloc, stockID);
            //rlocationid = getPhysicalloc(getstockloc);
            getstringPhysicalloc(getstockloc);
            slocationid = stringgplresult;
            //   rlocationid = Convert.ToInt32(slocationid, 10);

            if (slocationid == "")
            {
                slocationid = lastRecord.ToString();
                addnewequipment_addnewlocationid();
            }
            else
            {
                addNewEquipment();
            }

            //addnewequipment only updates records.
            //addNewEquipment();

        }

        public void addNewEquipment()
        {
   //         getlastitem();


            //Get the phyicallocation number co-inciding with the selected location.
            string getpl = "Select PhysicalLocation from LocationTable where (RoomNumber like '{0}') and ([Section] like '{1}') and ([Column] like '{2}') and ([Shelf] like '{3}')";
            getpl = string.Format(getpl, roomnocombo.Text, sectioncombo.Text, columncombo.Text, shelfcombo.Text);
           // rphysicalloc = getPhysicalloc(getpl);
            getstringPhysicalloc(getpl);
            sphysical = stringgplresult;

            //
            //Get stocklocation from equipment table stolen from here.
            //

            //Update the location link table with the new values            
            string addCommand = "Insert Into LocationLinkTable(StockLocationNumber, PhysicalLocationNumber)" +
                "Values({0},'{1}')";

            addCommand = string.Format(addCommand, slocationid, sphysical);
            runCommand(addCommand);

            //code for updating equipmentable.stocklocation with a new value.
      //      string updateequip = "Update equipmenttable set stocklocation = {0} where id = {1}";
        //    updateequip = string.Format(updateequip, lastRecord, stockID);
          //  runCommand(updateequip);
            this.Close();
            
        }

        private void addnewequipment_addnewlocationid()
        {
            getlastitem();

            //Get the phyicallocation number co-inciding with the selected location.
            string getpl = "Select PhysicalLocation from LocationTable where (RoomNumber like '{0}') and ([Section] like '{1}') and ([Column] like '{2}') and ([Shelf] like '{3}')";
            getpl = string.Format(getpl, roomnocombo.Text, sectioncombo.Text, columncombo.Text, shelfcombo.Text);
            // rphysicalloc = getPhysicalloc(getpl);
            getstringPhysicalloc(getpl);
            sphysical = stringgplresult;

            //
            //Get stocklocation from equipment table stolen from here.
            //

            //Update the location link table with the new values            
            string addCommand = "Insert Into LocationLinkTable(StockLocationNumber, PhysicalLocationNumber)" +
                "Values({0},'{1}')";
            addCommand = string.Format(addCommand, slocationid, sphysical);
            runCommand(addCommand);

            //code for updating equipmentable.stocklocation with a new value.
              string updateequip = "Update equipmenttable set stocklocation = {0} where id = {1}";
              lastRecord++;
              updateequip = string.Format(updateequip, lastRecord, stockID);
              runCommand(updateequip);

            this.Close();

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
                //cmdUpdate.Connection = mycon;
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

        public int getPhysicalloc(string sqlCommand)
        {
            //private DataTable getPhysicalloc(string sqlCommand)

            gplresult = 0;
            DataTable physicaltable = new DataTable();
            physicaltable.Columns.Add("Title1");
            DataRow row;

            OleDbConnection mycon2 = new OleDbConnection();
            mycon2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";


            OleDbCommand cmdUpdate = new OleDbCommand();


            string sGetLastItem = sqlCommand;
            OleDbCommand getToprecord = new OleDbCommand();
            getToprecord.CommandText = sGetLastItem;
            OleDbDataReader reader = null;
            
            try
            {
                getToprecord.Connection = mycon2;
                mycon2.Open();
                reader = getToprecord.ExecuteReader();
                while (gplresult == 0)
                {
                    reader.Read();
                    gplresult = (int)reader[0];
                }
            }
    /*        try
            {
                getToprecord.Connection = mycon2;
                mycon2.Open();
                reader = getToprecord.ExecuteReader();
                while (reader.Read())
                {
                    row = physicaltable.NewRow();
                    row[0] = reader[0];
                    physicaltable.Rows.Add(row);
                }
               
                
            }
      */      finally
            {
                mycon2.Close();
            }
            return gplresult;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            //delete location
            delEquipment();
            
        }

        private void delEquipment()
        {
            //lastRecord = getlastitem();

            //Get the phyicallocation number co-inciding with the selected location.
            string getpl = "Select PhysicalLocation from LocationTable where (RoomNumber like '{0}') and ([Section] like '{1}') and ([Column] like '{2}') and ([Shelf] like '{3}')";
            getpl = string.Format(getpl, roomnocombo.Text, sectioncombo.Text, columncombo.Text, shelfcombo.Text);
            delphysicalloc = getPhysicalloc(getpl);

            //Get the stocklocationid for the equipment item we are updating
            string getstockloc = "Select stocklocation from equipmenttable where id = {0}";
            getstockloc = string.Format(getstockloc, stockID);
            dellocationid = getPhysicalloc(getstockloc);

            //delete the location link table with the new values            
            string addCommand = "Delete from LocationLinkTable where(StockLocationNumber = {0} and PhysicalLocationNumber = {1})";

            addCommand = string.Format(addCommand, dellocationid, delphysicalloc);
            runCommand(addCommand);

            //code for updating equipmentable.stocklocation with a new value.
            //      string updateequip = "Update equipmenttable set stocklocation = {0} where id = {1}";
            //    updateequip = string.Format(updateequip, lastRecord, stockID);
            //  runCommand(updateequip);
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


            string sGetLastItem = "select TOP 1 * from LocationLinkTable order by stocklocationnumber desc";
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

        public void getstringPhysicalloc(string sqlCommand)
        {
            //private DataTable getPhysicalloc(string sqlCommand)

            stringgplresult = string.Empty;
            DataTable physicaltable = new DataTable();
            physicaltable.Columns.Add("Title1");
            DataRow row;

            OleDbConnection mycon2 = new OleDbConnection();
            mycon2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";


            OleDbCommand cmdUpdate = new OleDbCommand();


            string sGetLastItem = sqlCommand;
            OleDbCommand getToprecord = new OleDbCommand();
            getToprecord.CommandText = sGetLastItem;
            OleDbDataReader reader = null;
            /*        
                    try
                    {
                        getToprecord.Connection = mycon2;
                        mycon2.Open();
                        reader = getToprecord.ExecuteReader();
                        while (gplresult == 0)
                        {
                            reader.Read();
                            gplresult = (int)reader[0];
                        }
                    }
            */
            try
            {
                getToprecord.Connection = mycon2;
                mycon2.Open();
                reader = getToprecord.ExecuteReader();
                while (reader.Read())
                {
                    row = physicaltable.NewRow();
                    row[0] = reader[0];
                    physicaltable.Rows.Add(row);
                }
            }
            finally
            {
                mycon2.Close();
            }

            DataTable table = physicaltable;
            DataRow row1 = physicaltable.Rows[0];
            stringgplresult = row1[0].ToString();


            //return stringgplresult;
            // return gplresult;
           // return 0;
        }


    }
}