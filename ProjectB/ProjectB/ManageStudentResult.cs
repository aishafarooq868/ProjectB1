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
    public partial class ManageStudentResult : Form
    {
        public ManageStudentResult()
        {
            InitializeComponent();
        }
        int a;
        int Marks;
        int compMarks;
        SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
        private void ManageStudentResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet9.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet9.StudentResult);

            string query = "SELECT Id FROM Student";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader.Read())
                {
                    cbx_studentId.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            string query1 = "SELECT Title FROM Assessment";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader1;
            try
            {
                con.Open();
                reader1 = cmd1.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader1.Read())
                {
                    cbx_assessmentTitle.Items.Add(reader1[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            

            string query3 = "SELECT Id FROM RubricLevel";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlDataReader reader3;
            try
            {
                con.Open();
                reader3 = cmd3.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader3.Read())
                {
                    cbx_rubric.Items.Add(reader3[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void cbx_assessmentTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "SELECT * FROM Assessment WHERE Title = '" + cbx_assessmentTitle.Text + "'";
            SqlCommand cmda = new SqlCommand(q, con);
            //SqlDataReader myreader;
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            //myreader = cmda.ExecuteReader();
            /* int id=-1;
             while (myreader.Read())
             {
                  id = Convert.ToInt32(myreader[0]);
                 break; 
             }
             */
            con.Close();
            string query2 = "SELECT Id FROM AssessmentComponent WHERE AssessmentId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader2.Read())
                {
                    cbx_componentId.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        
        private void cbx_componentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "SELECT RubricId FROM AssessmentComponent WHERE Id = '" + cbx_componentId.Text + "'";
            SqlCommand cmda = new SqlCommand(q, con);
            //SqlDataReader myreader;
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            //a = r;
            con.Close();
            string query2 = "SELECT Details FROM Rubric WHERE Id = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cbx_rubric.Items.Clear();
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader2.Read())
                {
                    cbx_rubric.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cbx_rubricId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "SELECT Id FROM Rubric WHERE Details = '" + cbx_rubric.Text + "'";
            SqlCommand cmda = new SqlCommand(q, con);
            //SqlDataReader myreader;
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            con.Close();
            string query2 = "SELECT MeasurementLevel FROM RubricLevel WHERE RubricId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            //cbx_rubricId.Items.Clear();
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader2.Read())
                {
                    cbx_rubricmeasurementlevel.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cbx_rubricmeasurementlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "SELECT Id FROM RubricLevel WHERE MeasurementLevel = '" + cbx_rubricmeasurementlevel.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            //cbx_rubricId.Items.Clear();
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader2.Read())
                {
                    cbx_id.Items.Add(reader2[0]);
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
            string level = cbx_rubricmeasurementlevel.Text;
            int level1 = Convert.ToInt32(level);
            int maxlevel = 4;
            string q = "SELECT TotalMarks FROM AssessmentComponent WHERE Id = '" + cbx_componentId.Text + "'";
            SqlCommand cmda = new SqlCommand(q, con);
            //SqlDataReader myreader;
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            con.Close();
            compMarks = r;

            Marks = (level1 / maxlevel) * compMarks;
            

            string query = "INSERT into StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values ('" + cbx_studentId.Text + "', '" + cbx_componentId.Text + "', '" + cbx_id.Text + "', '" + dtp_evaluationDate.Value + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Data is Saved");

                //Clears textboxes after adding data.
                //txt_Id.Text = "";
                cbx_studentId.Items.Clear();
                cbx_assessmentTitle.Items.Clear();
                cbx_componentId.Items.Clear();
                cbx_rubric.Items.Clear();
                cbx_rubricmeasurementlevel.Items.Clear();
                string query1 = "SELECT * FROM StudentResult";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd1;
                    DataTable dt = new DataTable();
                    //DataColumn col = new DataColumn("Eval", typeof(double), "Marks = (level1 / maxlevel) * compMarks");
                    //dt.Columns.Add(col);
                    //dt.Rows.Add(0);
                    //return (double)(dt.Rows[0]["Eval"]);
                    //dt.Columns.Add("ObtainedMarks".ToString());
                    //DataRow dr = dt.NewRow();
                    //dr["ObtainedMarks"] = Marks.ToString();
                    //dt.Rows.Add(dr);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //con.Open();
            //string id2 = textBox1.Text;
            //int id1 = Convert.ToInt32(id2);
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            int id2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            //Data deletion
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM StudentResult WHERE StudentId = @id1 and AssessmentComponentId = @id2";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.Parameters.Add(new SqlParameter("@id2", id2));
                    cmd.ExecuteReader();
                    con.Close();

                }
            }
            if (e.ColumnIndex == 5)
            {
                //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cbx_studentId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cbx_componentId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cbx_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                dtp_evaluationDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            //Update query
            string query = "UPDATE StudentResult SET StudentId = '"+cbx_studentId.Text+"',  AssessmentComponentId = '" + cbx_componentId.Text + "', RubricMeasurementId = '" + cbx_id.Text + "', EvaluationDate = '" + dtp_evaluationDate.Value + "' WHERE StudentId= '" + cbx_studentId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            //Data inputs are cleared after updation
            cbx_studentId.Items.Clear();
            cbx_assessmentTitle.Items.Clear();
            cbx_componentId.Items.Clear();
            cbx_rubric.Items.Clear();
            cbx_rubricmeasurementlevel.Items.Clear();
            dtp_evaluationDate.Value = DateTimePicker.MinimumDateTime;
            

            //Showing updated data in datagridview
            using (SqlConnection sqlcon = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM StudentResult", sqlcon);
                DataTable d = new DataTable();
                sqlDA.Fill(d);
                dataGridView1.DataSource = d;
            }
        }
    }
}
