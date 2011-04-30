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
    public partial class newphysicallocation : Form
    {
        int lastRecord = 0;

        public newphysicallocation()
        {
            InitializeComponent();
        }

        private void newphysicallocation_Load(object sender, EventArgs e)
        {

        }
/* Handled in runcommand()
        private void addNewEquipment()
        {
            int x = 0;
            int y = 0;
            int z = 0;

            string addCommand = "Insert Into LocationTable(PhysicalLocation, RoomNumber, RoomDescription, Shelf, Column, Section)" + 
                "Values({0},'{1}','{2}',{3},{4}, {5})";

            int isection = Convert.ToInt32(sectionstextBox.Text, 10);
            int icolumn = Convert.ToInt32(columntextBox.Text, 10);
            int ishelf = Convert.ToInt32(shelvestextBox.Text, 10);

            for (x = 1; x <= isection; x++)
                for (y=1; y <= icolumn; y++)
                    for (z=1; z <= ishelf; z++)
                    {
                        addCommand = string.Format(addCommand, lastRecord, roomnumtextBox, roomdesctextBox, x, y, z);
                        runCommand(addCommand);
                        lastRecord++;
                    }

        }
*/
        public void getlastitem()
        {
            //get last record so we know what the new item will be.
            //just going to get the id and use that as physical location number

            OleDbConnection mycon2 = new OleDbConnection();
            mycon2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";

            
           
            OleDbCommand cmdUpdate = new OleDbCommand();


            string sGetLastItem = "select TOP 1 * from LocationTable order by id desc";
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
        
        private void runCommand()
        {
            int iSqlStatus =0;
         //   int x = 0;
       //     int y = 0;
         //   int z = 0;

            int isection = Convert.ToInt32(sectionstextBox.Text, 10);
            int icolumn = Convert.ToInt32(columntextBox.Text, 10);
            int ishelf = Convert.ToInt32(shelvestextBox.Text, 10);

           // string addCommand = "Insert Into LocationTable PhysicalLocation, RoomNumber, RoomDescription, Shelf, Column, Section" +
            //string addCommand = "INSERT INTO LocationTable (PhysicalLocation, RoomNumber, RoomDescription, Shelf, Column, Section)" +
              //  "Values({0},'{1}','{2}','{3}','{4}','{5}')"; 
            string addCommand = "INSERT INTO LocationTable ([PhysicalLocation], [RoomNumber], [RoomDescription], [Shelf], [Column], [Section])" +
                 "Values({0},'{1}','{2}','{3}','{4}','{5}')";

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";
            OleDbCommand oledbRunCommand = new OleDbCommand();
            oledbRunCommand.CommandText = addCommand;
            oledbRunCommand.CommandType = CommandType.Text;

            try
            {
                oledbRunCommand.Connection = connection;
                connection.Open();

                for (int x = 1; x <= isection; x++)
                {
                    for (int y = 1; y <= icolumn; y++)
                    {
                        for (int z = 1; z <= ishelf; z++)
                        {
                            string newString = string.Format(addCommand, lastRecord, roomnumtextBox.Text, roomdesctextBox.Text, x, y, z);
                            oledbRunCommand.CommandText = newString;
                            iSqlStatus = oledbRunCommand.ExecuteNonQuery();
                            lastRecord++;   
                        }
                    }
                }
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

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            getlastitem();
            runCommand();
            this.Close();
        }
    }
}
