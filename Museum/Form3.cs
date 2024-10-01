using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace pls_BD
{
    public partial class Form3 : Form
    {
        private OleDbConnection oledbconnection = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            oledbconnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\deadh\OneDrive\Documents\BD.mdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select * from (Workers inner join Positions on Workers.Position_Num = Positions.Position_Num)" +
                    " where Position_Name = '"+textBox1.Text +"' ";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
            else if (radioButton2.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select Groups.Group_Num, Workers.Worker_Name,Positions.Position_Name, Halls.Hall_Name, Reserver_Company.Reserver_Name," +
                    " Groups.Date_Of_Group, Groups.Number_Of_People " +
                    "from ((((Groups inner join Workers on Groups.Worker_Num = Workers.Worker_Num)" +
                    "inner join Halls on Groups.Hall_Num = Halls.Hall_Num)" +
                    "inner join Reserver_Company on Groups.Reserver_Num = Reserver_Company.Reserver_Num)" +
                    "inner join Positions on Workers.Position_Num = Positions.Position_Num)" +
                    "where Worker_Name = '"+ textBox1.Text +"' ";
                cmd.Parameters.AddWithValue("Worker_Name", textBox1.Text);
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
            else if (radioButton3.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select Halls.Hall_Num, Halls.Hall_Name, Object_Type.Objects_Type" +
                    " from (Halls inner join Object_Type on Halls.Objects_Type_Num = Object_Type.Objects_Type_Num)" +
                    " where Object_Type.Objects_Type = '" + textBox1.Text + "' ";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
            else if (radioButton4.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select Groups.Group_Num, Workers.Worker_Name, Halls.Hall_Name, Reserver_Company.Reserver_Name, Groups.Date_Of_Group, Groups.Number_Of_People " +
                    "from (((Groups inner join Workers on Groups.Worker_Num = Workers.Worker_Num)" +
                    "inner join Halls on Groups.Hall_Num = Halls.Hall_Num)" +
                    "inner join Reserver_Company on Groups.Reserver_Num = Reserver_Company.Reserver_Num)" +
                    "where Date_Of_Group > #11/1/2022# and Date_Of_Group < #11/30/2022#";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
            else if (radioButton5.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select Groups.Group_Num, Workers.Worker_Name, Halls.Hall_Name, Object_Type.Objects_Type, Reserver_Company.Reserver_Name," +
                    " Groups.Date_Of_Group, Groups.Number_Of_People " +
                    "from ((((Groups inner join Workers on Groups.Worker_Num = Workers.Worker_Num)" +
                    "inner join Halls on Groups.Hall_Num = Halls.Hall_Num)" +
                    "inner join Reserver_Company on Groups.Reserver_Num = Reserver_Company.Reserver_Num)" +
                    "inner join Object_Type on Halls.Objects_Type_Num = Object_Type.Objects_Type_Num)" +
                    "where Hall_Name = '" + textBox1.Text + "' ";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
            else if (radioButton6.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select Groups.Group_Num, Workers.Worker_Name, Halls.Hall_Name, Reserver_Company.Reserver_Name," +
                    " Groups.Date_Of_Group, Groups.Number_Of_People " +
                    "from (((Groups inner join Workers on Groups.Worker_Num = Workers.Worker_Num)" +
                    "inner join Halls on Groups.Hall_Num = Halls.Hall_Num)" +
                    "inner join Reserver_Company on Groups.Reserver_Num = Reserver_Company.Reserver_Num)" +
                    "where Group_Num <= 5 ";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
            else if (radioButton7.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select Groups.Group_Num, Workers.Worker_Name, Halls.Hall_Name, Reserver_Company.Reserver_Name, Reserver_Company.City," +
                    " Groups.Date_Of_Group, Groups.Number_Of_People " +
                    "from (((Groups inner join Workers on Groups.Worker_Num = Workers.Worker_Num)" +
                    "inner join Halls on Groups.Hall_Num = Halls.Hall_Num)" +
                    "inner join Reserver_Company on Groups.Reserver_Num = Reserver_Company.Reserver_Num)" +
                    "where Reserver_Name = '" + textBox1.Text + "' ";
                cmd.Parameters.AddWithValue("Reserver_Name", textBox1.Text);
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
            else MessageBox.Show("Choose a table first!");
        }
    }
}
