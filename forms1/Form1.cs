using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace forms1
{
    public partial class Form1 : Form
    {
        //query for table and database creation in the project folder
        //Global Declaration of Connection string from config file and other objects which can be used in multiple functions
        public static String strr = Convert.ToString(ConfigurationManager.ConnectionStrings["EmployeeDatabase"].ConnectionString);
        SqlConnection con1 = new SqlConnection(strr);
        DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenCon_Click(object sender, EventArgs e)
        {
            //prevent double table on double click
            dataGridView1.DataSource = "";

            //Declare the SQL Query as a string
            String cmd1 = "select * from EmployeeDetails";
            try
            {
                //clearing our data table to avoid multiple displays when clicked second time
                dt.Clear();

                //open connection,initialize command
                con1.Open();
                StatusMessage.Text = "Connection Successful";
                SqlCommand c1 = new SqlCommand(cmd1, con1);

                //pass table from sql into data table 
                dt.Load(c1.ExecuteReader());
                
                //fill the gridview with datatable
                dataGridView1.DataSource = dt;
            }
            catch (Exception expp)
            {
                StatusMessage.Text = "Connection failed";
            }
            finally
            {
                //close connection after displaying
                con1.Close();
            }
        }

        private void CloseCon_Click(object sender, EventArgs e)
        {
            Addmsg.Text = "";
            con1.Close();
            dataGridView1.DataSource = "";            
            StatusMessage.Text = "Connection Closed";
            
        }

        private void GetCount_Click(object sender, EventArgs e)
        {
            //Declare sql query as string
            String CountStr = "select COUNT(*) from EmployeeDetails";

            //clear message when called to avoid confusion
            Addmsg.Text = "";
            try
            {
                //open connection,initializwe command
                con1.Open();
                SqlCommand c1 = new SqlCommand(CountStr, con1);

                //pass table from sql into data table 
                int count = (int)c1.ExecuteScalar();

                //display no of rows
                StatusMessage.Text = "Total Rows : "+count.ToString();

            }
            catch (Exception expp)
            {
                StatusMessage.Text = "Connection failed";
            }
            finally
            {
                //close connection ofter displayng count
                con1.Close();
            }

        }
        public int AddRow()
        {
            
            //clearing all message lables
            Addmsg.Text = "";

            //declare variables to fill with data from text boxes
            String name = "";
            int Empid = 0, Salary = 0;

            name = NameBox.Text.ToString();

            //try catch to allow only numbers in ID and salary
            try
            {
                Empid = Convert.ToInt32(IdBox.Text.ToString());
                Salary = Convert.ToInt32(SalaryBox.Text.ToString());

            }

            catch (System.FormatException)
            {
                Addmsg.Text = "Enter Only Integers in Id,Salary";

                //OpenCon_Click(sender, e);
                con1.Close();
                return 0;

            }
            //declare query to insert data
            String InsQ = "INSERT INTO EmployeeDetails VALUES(" + Empid + ",'" + name + "'," + Salary + ")";

            //clear all text fields after copying data into variables
            NameBox.Clear();
            IdBox.Clear();
            SalaryBox.Clear();

            try
            {
                //open sql connection
                con1.Open();


                SqlCommand c1 = new SqlCommand(InsQ, con1);

                // i contains number of rows affected by our query
                int i = c1.ExecuteNonQuery();

                //if i==0 then no new rows were added
                if (i != 0)
                {
                    Addmsg.Text = "Insertion Successful";
                }
                else Addmsg.Text = "no new rows were added";


            }
            catch (Exception expp)
            {
                StatusMessage.Text = "Insertion Failed";
                

            }
            finally
            {
                //close connection after insertion
                con1.Close();
            }



            return 0;
        }

        public int UpdateRow()
        {
            Addmsg.Text = "";
            String name = "";
            int Empid = 0, Salary = 0;

            name = NameBox.Text.ToString();

            try
            {
                Empid = Convert.ToInt32(IdBox.Text.ToString());
                Salary = Convert.ToInt32(SalaryBox.Text.ToString());

            }

            catch (System.FormatException)
            {
                Addmsg.Text = "Enter Only Integers in Id,Salary";

                //OpenCon_Click(sender, e);
                con1.Close();
                return 0;

            }

            String InsQ = "UPDATE EmployeeDetails SET EmployeeName='"+ name + "',salary=" + Salary + " WHERE EmployeeID="+Empid;
            NameBox.Clear();
            IdBox.Clear();
            SalaryBox.Clear();

            try
            {

                con1.Open();
                SqlCommand c1 = new SqlCommand(InsQ, con1);
                int i = c1.ExecuteNonQuery();


                if (i != 0)
                {
                    Addmsg.Text = "Update Successful";
                }
                else
                    Addmsg.Text = "ID invalid.0 Rows Changed";


            }
            catch (Exception expp)
            {
                Addmsg.Text = "Insertion Failed";


            }
            finally
            {
                con1.Close();
            }



            return 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //no validation at the moment. So to stop insertion of wrong data we need to stop the insertion
            //preferred function calling instead of nested if else

            AddRow();

            //to update the view
            OpenCon_Click(sender,e);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            //no validation at the moment. So to stop insertion of wrong data we need to stop the insertion
            //preferred function calling instead of nested if else
            UpdateRow();

            //update the view
            OpenCon_Click(sender, e);

        }
        
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int Empid = 0;



            try
            {
                Empid = Convert.ToInt32(IdBox.Text.ToString());

            }

            catch (System.FormatException)
            {
                Addmsg.Text = "Enter Only Integers in Id,Salary";
                con1.Close();

            }
            //declare a string with delete query
            String InsQ = "DELETE FROM EmployeeDetails WHERE EmployeeID=" + Empid;

            //clear all text fields after copying ID
            NameBox.Clear();
            IdBox.Clear();
            SalaryBox.Clear();

            try
            {

                con1.Open();
                SqlCommand c1 = new SqlCommand(InsQ, con1);

                //i has number of rows effected
                int i = c1.ExecuteNonQuery();


                if (i != 0)
                {
                    Addmsg.Text = "Delete Successful";
                    //update the view
                    OpenCon_Click(sender, e);
                }
                else
                    Addmsg.Text = "0 Rows Changed";


            }
            catch (Exception expp)
            {
                Addmsg.Text = "Deletion Failed";


            }
            finally
            {
                con1.Close();
            }


        }

        private void Excelbtn_Click(object sender, EventArgs e)
        {
            //prevent double table on double click
            dataGridView1.DataSource = "";



            //Couldnt find any ways to directly import excel files with sql so OLEDb was used
            //only worked after installing access database engine from
            //https://download.microsoft.com/download/2/4/3/24375141-E08D-4803-AB0E-10F2E3A07AAA/AccessDatabaseEngine.exe



            //file location of excel document in .xlsx format
            String filename = @"G:\test\forms1\forms1\Book1.xlsx";

            //connection string format found at https://www.connectionstrings.com/ace-oledb-12-0/
            String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";

            //Sheet1$ refers to the sheet name in the excel file
            String Command = "Select * from [Sheet1$]";

            //create new OLEDB connection
            OleDbConnection con = new OleDbConnection(connection);
            
            //open connection
            con.Open();

            //execute command
            OleDbCommand cmd = new OleDbCommand(Command, con);
            
            //store table in data adapter
            OleDbDataAdapter db = new OleDbDataAdapter(cmd);

            //fill our data table with data from OleDbDataAdapter-db
            DataTable dt2 = new DataTable();
            db.Fill(dt2);

            //set/change grid view data source
            dataGridView1.DataSource = dt2;

        }
    }
}
