using Home_Accounting.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Accounting
{
    public partial class HomeAcc : Form
    {

        public HomeAcc()
        {
            InitializeComponent();
        }

        HomeAccClass cls = new HomeAccClass();

        //Method to Clear Fields

        public void Clear()
        {
            AccNameBox.Text = "";
            NameBox.Text = "";
            BalanceBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Data
            DataTable dt = cls.Select();
            AccDataList.DataSource = dt;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            cls.Name = NameBox.Text;
            cls.Balance = int.Parse(BalanceBox.Text);
        
            //Inserting Data into DataBase using the method we created in previous episode
            bool isSuccess = cls.Insert(cls);
            if (isSuccess)
            {
                //Successfully Inserted
                MessageBox.Show("New Account successfully Inserted");
                //Call the Clear() to clear our fields
                Clear();
            }
            else
            {
                //Failed to Add
                MessageBox.Show("Failed to add New Account. Try again!");
            }

            //Load Data
            DataTable dt = cls.Select();
            AccDataList.DataSource = dt;

        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //Get the Data from textboxes
            cls.AccountID = int.Parse(AccNameBox.Text);
            cls.Name = NameBox.Text;
            cls.Balance = int.Parse(BalanceBox.Text);

            //Update Data
            bool isSuccess = cls.Update(cls);
            if (isSuccess)
            {
                MessageBox.Show("Contact has been successfully Updated.");
                //Load Data
                DataTable dt = cls.Select();
                AccDataList.DataSource = dt;
                //Clear
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Updated. Try again!");
            }

        }
        

        private void AccDataList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data from Data Grid View and Load it to the TextBoxes
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            AccNameBox.Text = AccDataList.Rows[rowIndex].Cells[0].Value.ToString();
            NameBox.Text = AccDataList.Rows[rowIndex].Cells[1].Value.ToString();
            BalanceBox.Text = AccDataList.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Get the Account ID from the App
            cls.AccountID = Convert.ToInt32(AccNameBox.Text);
            bool isSuccess = cls.Delete(cls);
            if (isSuccess)
            {
                MessageBox.Show("Account has been successfully deleted!");
                //Load Data
                DataTable dt = cls.Select();
                AccDataList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete Account. Try again!");
            }
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            //Get value from Search Box
            string keywoard = SearchBox.Text;

            SqlConnection sqlConnection = new SqlConnection(myconnstr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_account WHERE Name LIKE '%" + keywoard + "%' OR Balance LIKE '%" + keywoard + "%'", sqlConnection);
        
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            AccDataList.DataSource = dt;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
