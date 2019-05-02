using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class ManageAssessment : Form
    {
        public ManageAssessment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
        private void ManageAssessment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet6.Assessment);
            textBox1.Hide();
        }

        private void cmd_add_Click(object sender, EventArgs e)
        {
            
            if(txt_title.Text != "" && txt_marks.Text != "" && txt_weightage.Text != "")
            {
                string query = "INSERT into Assessment(Title, DateCreated, TotalMarks, TotalWeightage) values ('" + txt_title.Text + "', '" + DateTime.Now + "', '" + txt_marks.Text + "', '" + txt_weightage.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Data is Saved");
                    
                    txt_title.Text = "";
                    txt_marks.Text = "";
                    txt_weightage.Text = "";
                    string query1 = "SELECT * FROM Assessment";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd1;
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please! provide details.");
            }
        }
        private void NMBR_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txt_marks_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^0*(?:[1-9][0-9]?|100)$";
            if (Regex.IsMatch(txt_marks.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_marks, "Please, provide marks within range 0 to 100.");
                txt_marks.Text = "";
                return;
            }
        }

        private void txt_weightage_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^0*(?:[1-9][0-9]?|100)$";
            if (Regex.IsMatch(txt_weightage.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_weightage, "Please, provide marks within range 0 to 100.");
                //MessageBox.Show("Please, provide marks within range 0 to 100.");
                txt_weightage.Text = "";
                return;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //con.Open();
            if (e.ColumnIndex == 5)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txt_title.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txt_marks.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txt_weightage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
            
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    con.Open();
                    
                    int[] array = new int[50];
                    int i = 0;
                    string query1 = "Select Id from AssessmentComponent WHERE AssessmentId ='" + id1 + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        array[i]= Convert.ToInt32(reader[0]);
                        i++;



                    }

                    foreach(int id in array)
                    {
                        string query2 = "Delete  from StudentResult WHERE AssessmentComponentId = '" + id + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.ExecuteNonQuery();


                        string query3 = "Delete  from AssessmentComponent WHERE Id = '" + id + "'";
                        SqlCommand cmd3 = new SqlCommand(query3, con);
                        cmd3.ExecuteNonQuery();


                    }

                    string query4 = "Delete  from Assessment WHERE Id ='" + id1 + "'";
                    SqlCommand cmd4 = new SqlCommand(query4, con);
                    cmd4.ExecuteNonQuery();

                    con.Close();
                }

            }
        }

        private void cmd_show_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM Assessment";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd1;
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

        private void cmd_update_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            //Establishing connection with sql
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            //Update query
            string query = "UPDATE Assessment Set Title = '" + this.txt_title.Text + "', DateCreated = '" + DateTime.Now + "', TotalMarks = '" + this.txt_marks.Text + "', TotalWeightage = '" + this.txt_weightage.Text + "' WHERE Id= '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            //clears textboxes after updating.
            txt_title.Text = "";
            txt_marks.Text = "";
            txt_weightage.Text = "";
            //shows updated data in datagridview.
            using (SqlConnection sqlcon = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Assessment", sqlcon);
                DataTable d = new DataTable();
                sqlDA.Fill(d);
                dataGridView1.DataSource = d;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
