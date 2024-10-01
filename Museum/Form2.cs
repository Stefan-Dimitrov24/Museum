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
    public partial class Form2 : Form
    {
        string box1, box2, box3, box4, box5, box6;
        private OleDbConnection oledbconnection = new OleDbConnection();
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            box1 = "Position Name";
            label1.Text = box1;
            textBox2.ReadOnly = false;
            box2 = "Empty";
            label2.Text = box2;
            textBox2.ReadOnly = true;
            box3 = "Empty";
            label3.Text = box3;
            textBox3.ReadOnly = true;
            box4 = "Empty";
            label4.Text = box4;
            textBox4.ReadOnly = true;
            box5 = "Empty";
            label5.Text = box5;
            textBox5.ReadOnly = true;
            box6 = "Empty";
            label6.Text = box6;
            textBox6.ReadOnly = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            box1 = "Company Name";
            label1.Text = box1;
            textBox1.ReadOnly = false;
            box2 = "City";
            label2.Text = box2;
            textBox2.ReadOnly = false;
            box3 = "Empty";
            label3.Text = box3;
            textBox3.ReadOnly = true;
            box4 = "Empty";
            label4.Text = box4;
            textBox4.ReadOnly = true;
            box5 = "Empty";
            label5.Text = box5;
            textBox5.ReadOnly = true;
            box6 = "Empty";
            label6.Text = box6;
            textBox6.ReadOnly = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            box1 = "Hall Name";
            label1.Text = box1;
            textBox1.ReadOnly = false;
            box2 = "Object Type";
            label2.Text = box2;
            textBox2.ReadOnly = false;
            box3 = "Empty";
            label3.Text = box3;
            textBox3.ReadOnly = true;
            box4 = "Empty";
            label4.Text = box4;
            textBox4.ReadOnly = true;
            box5 = "Empty";
            label5.Text = box5;
            textBox5.ReadOnly = true;
            box6 = "Empty";
            label6.Text = box6;
            textBox6.ReadOnly = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            box1 = "Object Type";
            label1.Text = box1;
            textBox1.ReadOnly = false;
            box2 = "Empty";
            label2.Text = box2;
            textBox2.ReadOnly = true;
            box3 = "Empty";
            label3.Text = box3;
            textBox3.ReadOnly = true;
            box4 = "Empty";
            label4.Text = box4;
            textBox4.ReadOnly = true;
            box5 = "Empty";
            label5.Text = box5;
            textBox5.ReadOnly = true;
            box6 = "Empty";
            label6.Text = box6;
            textBox6.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "insert into Groups (Worker_Num,Hall_Num,Reserver_Num,Date_Of_Group,Number_of_People, Price_Per_Person) " +
                    "values('" + textBox1.Text + " ','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton2.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "insert into Workers (Worker_Name,Position_Num) values('" + textBox1.Text + " ','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton3.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "insert into Positions (Position_Name) values('" + textBox1.Text + " ')";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton4.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "insert into Reserver_Company (Reserver_Name,City) values('" + textBox1.Text + " ','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton5.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "insert into Halls (Hall_Name,Objects_Type_Num) values('" + textBox1.Text + " ','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton6.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "insert into Object_Type (Objects_Type)  values('" + textBox1.Text + " ')";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else MessageBox.Show("Choose a table first!");
        }

        private void bck_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "update Groups set Worker_Num= '" + textBox1.Text + "' ,Hall_Num = '" + textBox2.Text + "' ,Reserver_Num = '" + textBox3.Text + "'" +
                    ",Date_of_Group = '" + textBox4.Text + "' ,Number_Of_People = '" + textBox5.Text + "' ,Price_Per_Person = '" + textBox6.Text + "' where Group_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton2.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "update Workers set Worker_Name= '" + textBox1.Text + "' ,Position_Num= '" + textBox2.Text + "' where Worker_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton3.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "update Positions set Position_Name= '" + textBox1.Text + "' where Position_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton4.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "update Reserver_Company set Reserver_Name= '" + textBox1.Text + "' ,City= '" + textBox2.Text + "' where Reserver_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton5.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "update Halls set Hall_Name= '" + textBox1.Text + "' ,Objects_Type_Num= '" + textBox2.Text + "' where Hall_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton6.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "update Object_Type set Objects_Type = '" + textBox1.Text + "' where Objects_Type_Num = " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else MessageBox.Show("Choose a table first!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "delete from Groups where Group_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton2.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "delete from Workers where Worker_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton3.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "delete from Positions where Position_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton4.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "delete from Reserver_Company where Reserver_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton5.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "delete from Halls where Hall_Num= " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else if (radioButton6.Checked == true)
            {
                oledbconnection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oledbconnection;
                cmd.CommandText = "delete from Object_Type where Objects_Type_Num = " + Upd_Bx.Text + " ";
                cmd.ExecuteNonQuery();
                oledbconnection.Close();
                MessageBox.Show("WORKED");
            }
            else MessageBox.Show("Choose a table first!");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            box1 = "Worker Name";
            label1.Text = box1;
            textBox1.ReadOnly = false;
            box2 = "Position Number";
            label2.Text = box2;
            textBox2.ReadOnly = false;
            box3 = "Empty";
            label3.Text = box3;
            textBox3.ReadOnly = true;
            box4 = "Empty";
            label4.Text = box4;
            textBox4.ReadOnly = true;
            box5 = "Empty";
            label5.Text = box5;
            textBox5.ReadOnly = true;
            box6 = "Empty";
            label6.Text = box6;
            textBox6.ReadOnly = true;
        }

        public Form2()
        {
            InitializeComponent();
            oledbconnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\deadh\OneDrive\Documents\BD.mdb";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.bDDataSet.Positions);

        }

        private void positionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            box1 = "Worker Number";
            label1.Text = box1;
            textBox1.ReadOnly = false;
            box2 = "Hall Number";
            label2.Text = box2;
            textBox2.ReadOnly = false;
            box3 = "Company Number";
            label3.Text = box3;
            textBox3.ReadOnly = false;
            box4 = "Date";
            label4.Text = box4;
            textBox4.ReadOnly = false;
            box5 = "Number of People";
            label5.Text = box5;
            textBox5.ReadOnly = false;
            box6 = "Price per Person";
            label6.Text = box6;
            textBox6.ReadOnly = false;
        }
    }
}
