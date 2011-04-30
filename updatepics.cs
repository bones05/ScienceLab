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
    public partial class updatepics : Form
    {
        int stockItemId;
        public updatepics()
        {
            InitializeComponent();
        }

        public updatepics(int stockid)
        {
            InitializeComponent();
            stockItemId = stockid;

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            
/* Memory violation error wont let us use the dialog box :( 
 * Gonna have to go console on these bitches.
            string Chosen_File = @"C:\Pics\9.JPG";
            //folderBrowserDialog1.ShowDialog();
            //DialogResult picture = openFileDialog1.ShowDialog();
            openFD1 = new OpenFileDialog();

            openFD1.Title = "Insert an Image";
            openFD1.FileName = "";
            openFD1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif";
            openFD1.ShowDialog();

            
            Chosen_File = openFD1.FileName;
   */         //pictureBox1.Image = Image.FromFile(Chosen_File);

            if (File.Exists(textBox1.Text))
            UploadImg(textBox1.Text);
            else
            MessageBox.Show("Error. Please check the filepath exists.");
            
            Loadimg();
            //call upload pic
        }

        private void UploadImg(string filelocation)
        {
            int iSqlStatus;

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";
           // OleDbCommand myCommand = new OleDbCommand();
            //         SqlCommand.CommandText = addCommand;
            //       SqlCommand.CommandType = CommandType.Text;

            int imageSize;
            string imageType;
            FileStream imageStream;
//            Image img = Image.FromFile(filelocation);


            // Gets the Size of the Image
            //imageSize = fileImgUpload.PostedFile.ContentLength;
            //imageSize = img.Size;
            //var filelength = new FileInfo(filelocation).Length;
            //imageSize = Convert.ToInt32(filelength,10);

//            long x = (new System.IO.FileInfo(filelocation)).Length;
//            imageSize = unchecked((int)x);


            // Gets the Image Type
            //imageType = fileImgUpload.PostedFile.ContentType;
//            imageType = img.RawFormat.ToString();

            // Reads the Image stream
            //imageStream = fileImgUpload.PostedFile.InputStream;
            //imageStream = img.Save(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg);
//            imageStream = new memoryStream();

//            img.Save(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            imageStream = new FileStream(filelocation, FileMode.Open);

            // Create a byte array of file stream length   
            byte[] ImageData = new byte[imageStream.Length];

            //Read block of bytes from stream into the byte array   
            imageStream.Read(ImageData, 0, System.Convert.ToInt32(imageStream.Length));

            //Close the File Stream   
            imageStream.Close();
            //row[7] = ImageData;

//            byte[] imageContent = new byte[imageSize];
//            int intStatus;
//            intStatus = imageStream.Read(imageContent, 0, imageSize);


            //OleDbCommand myCommand = new OleDbCommand("insert into tblImg(img_title,img_stream,img_type) values(@img_title,@img_stream,@img_type)", myAccessConnection);

            //OleDbCommand myCommand = new OleDbCommand("Update Equipmenttable set [image] = @img_stream where ID = @img_id");
            OleDbCommand myCommand = new OleDbCommand("update [equipmenttable] set [image] = @img_stream WHERE ID = " + stockItemId);
            // Mark the Command as a Text
            myCommand.CommandType = CommandType.Text;

            // Add Parameters to Command
            //OleDbParameter img_title = new OleDbParameter("@img_title", OleDbType.VarChar);
            //img_title.Value = txtImgTitle.Text;
            //myCommand.Parameters.Add(img_title);

            OleDbParameter img_stream = new OleDbParameter("@img_stream", OleDbType.Binary);
            img_stream.Value = ImageData;
            myCommand.Parameters.Add(img_stream);

            //OleDbParameter img_Type = new OleDbParameter("@img_type", OleDbType.VarChar);
            //img_Type.Value = imageType;
            //myCommand.Parameters.Add(img_Type);

//            OleDbParameter img_id = new OleDbParameter("@img_id", OleDbType.Integer);
  //          img_id.Value = stockItemId;
    //        myCommand.Parameters.Add(img_id);

            try
            {
                //openAccessConnection();
                myCommand.Connection = connection;
                connection.Open();
                iSqlStatus = myCommand.ExecuteNonQuery();
                //closeAccessConnection();
                // connection.Close();

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
                //Response.Write("Insert Failure. Error Details : " + exc.Message.ToString());
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();

            }
        }

        private void updatepics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sciencedbDataSet.EquipmentTable' table. You can move, or remove it, as needed.
      //      this.equipmentTableTableAdapter.Fill(this.sciencedbDataSet.EquipmentTable);
            Loadimg();
        }

        private void Loadimg()
        {

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\sciencedb.accdb";

     //       OleDbCommand myCommand = new OleDbCommand("update [equipmenttable] set [image] = @img_stream WHERE ID = " + stockItemId);
            // Mark the Command as a Text
        //    myCommand.CommandType = CommandType.Text;

            try
            {
               // string ID = Request.QueryString["id"];
                byte[] ImageByte = null;
                MemoryStream memstream = null;
                
                OleDbCommand myCommand = new OleDbCommand("select image from equipmenttable where id=" + stockItemId);
                myCommand.Connection = connection;
                // Mark the Command as a Text
                //myCommand.CommandType = CommandType.Text;

                connection.Open();
      /*          // Add Parameters to Command
                OleDbParameter img_id = new OleDbParameter("@img_id", OleDbType.Integer);
                img_id.Value = stockItemId;
                myCommand.Parameters.Add(img_id);
                */
                /*

                OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
                DataSet myDataSet = new DataSet();
                myAdapter.Fill(myDataSet);

                foreach (DataRow dRow in myDataSet.Tables[0].Rows)
                {
                    Response.ContentType = dRow["img_type"].ToString();
                    byte[] imageContent = (byte[])((dRow["img_stream"]));
                    Response.BinaryWrite(imageContent);
                }
                */
                
                ImageByte = (byte[])myCommand.ExecuteScalar();
                memstream = new MemoryStream(ImageByte);
                pictureBox1.Image = Image.FromStream(memstream);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
