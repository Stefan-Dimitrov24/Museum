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
    public partial class Form1 : Form
    {
        private OleDbConnection oledbconnection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            oledbconnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\deadh\OneDrive\Documents\BD.mdb";
        }  
        private void positionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.bDDataSet.Groups);
            // TODO: This line of code loads data into the 'bDDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.bDDataSet.Workers);
            // TODO: This line of code loads data into the 'bDDataSet.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.bDDataSet.Positions);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void positionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "select * from Groups ";
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
                cmd.CommandText = "select * from Workers ";
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
                cmd.CommandText = "select * from Positions";
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
                cmd.CommandText = "select * from Reserver_Company";
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
                cmd.CommandText = "select * from Halls";
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
                cmd.CommandText = "select * from Object_Type";
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                oledbconnection.Close();
            }
        }
    }
}
