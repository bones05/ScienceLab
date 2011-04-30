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
    public partial class addequipment : Form
    {
        public addequipment()
        {
            InitializeComponent();
        }

        private void addequipment_Load(object sender, EventArgs e)
        {
            //eerrr.. show form or something?
        }

        private void addNewEquipment()
        {

            string addCommand = "Insert Into EquipmentTable(EquipmentName, Description, OperatingNotes, SupplierID, StockLocation)" +
                "Values('{0}','{1}','{2}',{3},{4})";

            addCommand = string.Format(addCommand, equiptextBox.Text, desctextBox.Text, opnotestextBox.Text, 0, 0);
            runCommand(addCommand);
            
        }

/*        private void updateEquipment()
        {

        }
        */
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

        private void savebutton_Click(object sender, EventArgs e)
        {
            addNewEquipment();
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
