using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class ManageClo : Form
    {
        public ManageClo()
        {
            InitializeComponent();
        }
        //Validation on Name
        private void NAME_ONLY(object sender, KeyPressEventArgs e)
        {
            //TextBox tb = sender as TextBox;

            //if (tb.SelectionStart == 0 && !char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = (e.KeyChar == (char)Keys.Space);
               
            //}

            //else
            //{
            //    e.Handled = false;
            //}
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }



        private void ManageClo_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            // TODO: This line of code loads data into the 'projectBDataSet3.Clo' table. You can move, or remove it, as needed.
            //this.cloTableAdapter1.Fill(this.projectBDataSet3.Clo);
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);

        }
        //Data is edited and deleted in the datagridview.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Establishes sql connection
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //if(MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //Data deletion.
                if (e.ColumnIndex == 5)
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM Rubric WHERE CloId = @id1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.ExecuteReader();
                    con.Close();

                    con.Open();
                    string query1 = "DELETE FROM Clo WHERE Id = @id1";
                    SqlCommand command = new SqlCommand(query1, con);
                    command.Parameters.Add(new SqlParameter("@id1", id1));
                    command.ExecuteReader();
                    con.Close();

                }
            
            //if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            
            //Data editing
            if(e.ColumnIndex == 4)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                
            }
        }
        //This is click of button 1 for inserting data of clo in database.
        private void button1_Click(object sender, EventArgs e)
        {
            //This if checks for provided details
            if (textBox1.Text != "")
            {
                //Establishes sql connection.
                SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
                //Query for data insertion.
                string query = "insert into Clo(Name, DateCreated, DateUpdated) values('" + this.textBox1.Text + "','" + DateTime.Now + "','" + DateTime.Now+ "'); ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Throws message for not providing details
            else
            {
                MessageBox.Show("Please! provide details.");
            }
        }
        //This is click of button 2 where data is shown in datagridview.
        private void button2_Click(object sender, EventArgs e)
        {
            //Establishes sql connection.
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            //Query for selecting the data.
            string query = "select * from Clo";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //This is click of button4 where data is updated.
        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            //Establishes sql connection
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            //Update query
            string query = "UPDATE Clo Set Name = '" + this.textBox1.Text + "', DateCreated = '"+DateTime.Now+"', DateUpdated = '"+DateTime.Now+"' WHERE Id= '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            //Clears textboxes after updating data
            textBox1.Text = "";
            textBox2.Text = "";
            //Shows updated data in datagridview.
            using (SqlConnection sqlcon = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Clo", sqlcon);
                DataTable d = new DataTable();
                sqlDA.Fill(d);
                dataGridView1.DataSource = d;
            }
        }
        //Linkage with home page.
        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
        //validation for name
        private void isname(object sender, CancelEventArgs e)
        {
            TextBox t = sender as TextBox;
            if(string.IsNullOrWhiteSpace(t.Text) == true)
            {
                //MessageBox.Show("Invalid Information");
                e.Cancel = false;
                return;
            }
        }
    }
}
