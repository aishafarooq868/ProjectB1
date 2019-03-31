using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class RubricLevel : Form
    {
        public RubricLevel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
        private void button2_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM RubricLevel";
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

        private void RubricLevel_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            // TODO: This line of code loads data into the 'projectBDataSet7.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet7.RubricLevel);
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            //Clo Id selection query
            string query = "SELECT Id FROM Rubric";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                //MessageBox.Show("Saved");
                while (myreader.Read())
                {
                    cbx_rubricId.Items.Add(myreader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool isExist1 = false;
            string query2 = "SELECT RubricId, COUNT(RubricId) FROM RubricLevel GROUP BY RubricId HAVING COUNT(RubricId) >= 4";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            con.Open();
            SqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read())
            {
                int id = Convert.ToInt32(cbx_rubricId.Text);
                if (id == Convert.ToInt32(reader1[0]))
                {
                    isExist1 = true;
                    MessageBox.Show("More than 4 levels can't be added against 1 Rubric.");
                    break;
                }
            }
            con.Close();
            if (cbx_rubricId.Text != "" && txt_details.Text != "" && txt_measurement.Text != "")
            {
                
                if(isExist1 == false)
                {
                    string query = "INSERT into RubricLevel(RubricId, Details, MeasurementLevel) values ('" + cbx_rubricId.Text + "', '" + txt_details.Text + "', '" + /*Convert.ToInt32(*/txt_measurement.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader;
                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Data is Saved");

                        //Clears textboxes after adding data.
                        //txt_Id.Text = "";
                        cbx_rubricId.SelectedItem = null;
                        txt_details.Text = "";
                        txt_measurement.Text = "";
                        string query1 = "SELECT * FROM RubricLevel";
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
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
            //if (txt.Text.Length > 11)
            //{
            //    MessageBox.Show("Contact number can be no more longer than 11");
            //}
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            //Establishes sql connection
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            //Update query
            string query = "UPDATE RubricLevel SET /*Id = '" + this.textBox1.Text + "',*/ Details = '" + txt_details.Text + "', MeasurementLevel = '" + txt_measurement.Text + "' WHERE Id= '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            //Data inputs are cleared after updation
            txt_measurement.Text = "";
            txt_details.Text = "";
            cbx_rubricId.SelectedItem = null;
            //Showing updated data in datagridview
            using (SqlConnection sqlcon = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM RubricLevel", sqlcon);
                DataTable d = new DataTable();
                sqlDA.Fill(d);
                dataGridView1.DataSource = d;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txt_details.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txt_measurement.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                //cbx_rubricId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }

            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM RubricLevel WHERE Id = @id1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.ExecuteReader();
                    con.Close();
                }
            }
        }
    }
}
