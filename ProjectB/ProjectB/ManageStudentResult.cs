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
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            con.Close();
            string query2 = "SELECT Id FROM AssessmentComponent WHERE AssessmentId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
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
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            con.Close();
            string query2 = "SELECT MeasurementLevel FROM RubricLevel WHERE RubricId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
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
            SqlDataReader reader2;
            try
            {
                con.Open();
                reader2 = cmd2.ExecuteReader();
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
            con.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            con.Close();
            compMarks = r;

            Marks = (level1 / maxlevel) * compMarks;

            string query = "INSERT into StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values ('" + cbx_studentId.Text + "', '" + cbx_componentId.Text + "', '" + cbx_id.Text + "', '" + dtp_evaluationDate.Value + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Data is Saved");

            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, con);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AssessmentComponentId"].Visible = false;
            dataGridView1.Columns["StudentId"].Visible = false;

            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(dataGridView1.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(dataGridView1.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                dataGridView1.Rows[i].Cells["ObtainedMarks"].Value = marks;
            }
            cbx_studentId.Items.Clear();
            cbx_assessmentTitle.Items.Clear();
            cbx_componentId.Items.Clear();
            cbx_rubric.Items.Clear();
            cbx_rubricmeasurementlevel.Items.Clear();
            cbx_id.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AssessmentComponentId"].Visible = false;
            dataGridView1.Columns["StudentId"].Visible = false;

            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(dataGridView1.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(dataGridView1.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                dataGridView1.Rows[i].Cells["ObtainedMarks"].Value = marks;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //con.Open();
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            int id2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //con.Open();
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM StudentResult WHERE StudentId = @id1 and AssessmentComponentId = @id2";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.Parameters.Add(new SqlParameter("@id2", id2));
                    cmd.ExecuteReader();
                    con.Close();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }     
    }
}
