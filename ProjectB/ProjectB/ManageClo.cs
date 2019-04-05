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
            //int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            ////if(MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    //Data deletion.
            //    if (e.ColumnIndex == 5)
            //    {
            //        this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            //    string query = "DELETE FROM dbo.[RubricLevel] and dbo.[AssessmentComponent] WHERE RubricId = @id1";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.Add(new SqlParameter("@id1", id1));
            //    cmd.ExecuteReader();
            //    con.Close();

            //    //con.Open();
            //    //string query3 = "DELETE FROM AssessmentComponent WHERE RubricId = @id1";
            //    //SqlCommand cmd3 = new SqlCommand(query3, con);
            //    //cmd3.Parameters.Add(new SqlParameter("@id1", id1));
            //    //cmd3.ExecuteReader();
            //    //con.Close();

            //    con.Open();
            //    string query1 = "DELETE FROM Rubric WHERE CloId = @id1";
            //        SqlCommand cmd1 = new SqlCommand(query1, con);
            //        cmd1.Parameters.Add(new SqlParameter("@id1", id1));
            //        cmd1.ExecuteReader();
            //        con.Close();

            //        con.Open();
            //        string query2 = "DELETE FROM Clo WHERE Id = @id1";
            //        SqlCommand cmd2 = new SqlCommand(query2, con);
            //        cmd2.Parameters.Add(new SqlParameter("@id1", id1));
            //        cmd2.ExecuteReader();
            //        con.Close();

            //    }

            if (e.ColumnIndex == 5)
            {
                int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                int[] rubric_array = new int[5];
                int[] assessment_array = new int[50];
                int[] rubriclvl_array = new int[5];

                int i = 0;

                string qeury = "Select Id from Rubric where CloId = @id1";
                SqlCommand cmd = new SqlCommand(qeury, con);
                cmd.Parameters.Add(new SqlParameter("@id1", id1));
                cmd.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rubric_array[i] = Convert.ToInt32(reader[0]);
                    i++;




                }
                reader.Close();
                foreach (int rubric in rubric_array)
                {
                    string qeury1 = "Select Id from RubricLevel where RubricId = '" + rubric + "'";
                    SqlCommand cmd1 = new SqlCommand(qeury, con);
                    cmd1.Parameters.Add(new SqlParameter("0", 1));
                    //cmd1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader reader1 = cmd.ExecuteReader();
                    while (reader1.Read())
                    {
                        rubriclvl_array[i] = Convert.ToInt32(reader1[0]);
                        i++;




                    }
                    reader1.Close();
                    foreach (int lvl in rubriclvl_array)
                    {
                        string qeury2 = "Delete from StudentResult where RubricMeasurementId = '" + lvl + "'";
                        SqlCommand cmd2 = new SqlCommand(qeury2, con);
                        cmd2.ExecuteNonQuery();

                        string qeury3 = "Delete from RubricLevel where Id = '" + lvl + "'";
                        SqlCommand cmd3 = new SqlCommand(qeury3, con);
                        cmd2.ExecuteNonQuery();




                    }


                }
                foreach (int rubric in rubric_array)
                {
                    string qeury1 = "Select Id from AssessmentComponent where RubricId = '" + rubric + "'";
                    SqlCommand cmd1 = new SqlCommand(qeury, con);
                    cmd1.Parameters.Add(new SqlParameter("0", 1));
                    //cmd1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader reader1 = cmd.ExecuteReader();
                    while (reader1.Read())
                    {
                        assessment_array[i] = Convert.ToInt32(reader1[0]);
                        i++;




                    }
                    reader1.Close();
                    foreach (int assessmentlvl in assessment_array)
                    {
                        string qeury2 = "Delete from StudentResult where AssessmentComponentId = '" + assessmentlvl + "'";
                        SqlCommand cmd2 = new SqlCommand(qeury2, con);
                        cmd2.ExecuteNonQuery();

                        string qeury3 = "Delete from RubricLevel where Id = '" + assessmentlvl + "'";
                        SqlCommand cmd3 = new SqlCommand(qeury3, con);
                        cmd2.ExecuteNonQuery();




                    }
                    string qeury4 = "Delete from Rubric where CloId = @id";
                    SqlCommand cmd4 = new SqlCommand(qeury4, con);
                    cmd4.ExecuteNonQuery();


                    string qeury5 = "Delete from Clo where Id = @id";
                    SqlCommand cmd5 = new SqlCommand(qeury5, con);
                    cmd5.ExecuteNonQuery();





                }

                ////Data editing
                if (e.ColumnIndex == 4)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                }
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
