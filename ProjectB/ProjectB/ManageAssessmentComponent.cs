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
    public partial class ManageAssessmentComponent : Form
    {
        public ManageAssessmentComponent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            // TODO: This line of code loads data into the 'projectBDataSet8.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet8.AssessmentComponent);
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
            con.Close();
            string query1 = "SELECT Id FROM Assessment";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd1.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader.Read())
                {
                    cbx_assessmentId.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = "INSERT into AssessmentComponent (Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) values('"+txt_name.Text+"', '"+cbx_rubricId.Text+"', '"+txt_totalmarks.Text+"', '"+dtp_created.Value+"', '"+dtp_updated.Value+"', '"+cbx_assessmentId.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Data is Saved");

                //Clears textboxes after adding data.
                txt_name.Text = "";
                cbx_rubricId.SelectedItem = null;
                txt_totalmarks.Text = "";
                cbx_assessmentId.SelectedItem = null;
                dtp_created.Value = DateTimePicker.MinimumDateTime;
                dtp_updated.Value = DateTimePicker.MinimumDateTime;
                con.Close();
                string query1 = "SELECT * FROM AssessmentComponent";
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
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM AssessmentComponent";
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
            //con.Close();
        }

        private void dtp_created_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_created.Value == DateTimePicker.MinimumDateTime)
            {
                dtp_created.Value = DateTime.Now;
                dtp_created.Format = DateTimePickerFormat.Custom;
                dtp_created.CustomFormat = "";
            }
            else
            {
                dtp_created.Format = DateTimePickerFormat.Short;
            }
        }

        private void dtp_updated_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_created.Value == DateTimePicker.MinimumDateTime)
            {
                dtp_created.Value = DateTime.Now;
                dtp_created.Format = DateTimePickerFormat.Custom;
                dtp_created.CustomFormat = "";
            }
            else
            {
                dtp_created.Format = DateTimePickerFormat.Short;
            }
        }
        private void NMBR_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //cbx_rubricId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txt_totalmarks.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                dtp_created.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                dtp_updated.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                //cbx_assessmentId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
            con.Open();
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM AssessmentComponent WHERE Id = @id1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.ExecuteReader();
                    con.Close();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            con.Open();
            //Update query
            string query = "UPDATE AssessmentComponent SET /*Id = '" + this.textBox1.Text + "',*/ Name = '" + txt_name.Text + "', TotalMarks = '" + txt_totalmarks.Text + "', DateCreated = '"+ dtp_created.Value+"', DateUpdated = '"+dtp_updated.Value+"' WHERE Id= '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            //Data inputs are cleared after updation
            txt_name.Text = "";
            txt_totalmarks.Text = "";
            cbx_rubricId.SelectedItem = null;
            cbx_assessmentId.SelectedItem = null;
            dtp_created.Value = DateTimePicker.MinimumDateTime;
            dtp_updated.Value = DateTimePicker.MinimumDateTime;

            //Showing updated data in datagridview
            using (SqlConnection sqlcon = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM AssessmentComponent", sqlcon);
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
