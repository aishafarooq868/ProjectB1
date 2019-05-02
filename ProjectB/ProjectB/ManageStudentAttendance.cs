using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectB
{
    public partial class ManageStudentAttendance : Form
    {
        public ManageStudentAttendance()
        {
            InitializeComponent();
        }
        string constring = "Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";

        int id;
        int att_id;
        int lookid;
        int sid;
        string reg_no;
        string status;
        string att_date;
        int db_att;
        int db_std;
        int updated_sid;
        int updated_aid;
        int del_sid;
        int del_attid;

        private void ManageStudentAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet11.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet11.StudentAttendance);

        }
        void UpdateAttendance()
        {
            //this.assessmentComponentTableAdapter.Fill(this.projectBDataSet6.AssessmentComponent);
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet11.StudentAttendance);


            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            //asse
            string constring = "Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection cmd = new SqlConnection(constring);
            cmd.Open();
            String s = "SELECT AttendanceDate FROM ClassAttendance";
            SqlCommand command = new SqlCommand(s, cmd);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx_Date.Items.Add(reader[0]);



            }
            cmd.Close();
        }
        void UpdateStatus()
        {
            //this.assessmentComponentTableAdapter.Fill(this.projectBDataSet6.AssessmentComponent);
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet11.StudentAttendance);


            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            //asse
            string constring = "Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection cmd = new SqlConnection(constring);
            cmd.Open();
            String s = "SELECT Name FROM Lookup where LookupId < 5 ";
            SqlCommand command = new SqlCommand(s, cmd);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx_Status.Items.Add(reader[0]);



            }
            cmd.Close();
        }
        void UpdateStudent()
        {
            //this.assessmentComponentTableAdapter.Fill(this.projectBDataSet6.AssessmentComponent);
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet11.StudentAttendance);


            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            //asse
            string constring = "Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection cmd = new SqlConnection(constring);
            cmd.Open();
            String s = "SELECT RegistrationNumber FROM Student";
            SqlCommand command = new SqlCommand(s, cmd);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx_RegistrationNumber.Items.Add(reader[0]);



            }
            cmd.Close();
        }
        private void cbx_RegistrationNumber_Click(object sender, EventArgs e)
        {
            cbx_RegistrationNumber.Items.Clear();
            UpdateStudent();

        }

        private void cbx_Date_Click(object sender, EventArgs e)
        {
            cbx_Date.Items.Clear();
            UpdateAttendance();

        }

        private void cbx_Status_Click(object sender, EventArgs e)
        {
            cbx_Status.Items.Clear();
            UpdateStatus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT Id FROM Student WHERE RegistrationNumber = '" + cbx_RegistrationNumber.Text + "'";
            SqlConnection conDataBase1 = new SqlConnection(constring);

            SqlCommand cmdDataBase1 = new SqlCommand(query1, conDataBase1);
            SqlDataReader myreader1;
            conDataBase1.Open();
            cmdDataBase1.Parameters.Add(new SqlParameter("0", 1));
            myreader1 = cmdDataBase1.ExecuteReader();
            //MessageBox.Show("Attendance Marked");
            while (myreader1.Read())
            {
                sid = Convert.ToInt32(myreader1[0]);
            }


            //int att_id;
            String date = cbx_Date.Text;

            DateTime d1 = Convert.ToDateTime(date);
            DateTime dateonly = d1.Date;
            string query2 = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = '" + dateonly + "'";
            SqlConnection conDataBase2 = new SqlConnection(constring);

            SqlCommand cmdDataBase2 = new SqlCommand(query2, conDataBase2);
            SqlDataReader myreader2;
            conDataBase2.Open();
            cmdDataBase2.Parameters.Add(new SqlParameter("0", 1));
            myreader2 = cmdDataBase2.ExecuteReader();
            //MessageBox.Show("Attendance Marked");
            while (myreader2.Read())
            {
                att_id = Convert.ToInt32(myreader2[0]);
            }

            string c = "Select LookupId from Lookup where Name = '" + cbx_Status.Text + "'";
            SqlConnection cn = new SqlConnection(constring);
            SqlCommand cmddatabase3 = new SqlCommand(c, cn);
            SqlDataReader reader;
            cn.Open();
            cmddatabase3.Parameters.Add(new SqlParameter("0", 1));
            reader = cmddatabase3.ExecuteReader();
            while (reader.Read())
            {
                lookid = Convert.ToInt32(reader[0]);
            }

            string qeury = "insert into dbo.StudentAttendance(AttendanceId,StudentId,AttendanceStatus) values('" + att_id + "','" + sid + "','" + lookid + "')";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
            SqlDataReader myreader;
            conDataBase.Open();
            myreader = cmdDataBase.ExecuteReader();
            MessageBox.Show("Attendance Marked");
            while (myreader.Read())
            {

            }
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.StudentAttendance", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            cbx_Status.Text = "";
            cbx_RegistrationNumber.Text = "";
            cbx_Date.Text = "";

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT Id FROM Student WHERE RegistrationNumber = '" + cbx_RegistrationNumber.Text + "'";
            SqlConnection conDataBase1 = new SqlConnection(constring);

            SqlCommand cmdDataBase1 = new SqlCommand(query1, conDataBase1);
            SqlDataReader myreader1;
            conDataBase1.Open();
            cmdDataBase1.Parameters.Add(new SqlParameter("0", 1));
            myreader1 = cmdDataBase1.ExecuteReader();
            while (myreader1.Read())
            {
                updated_sid = Convert.ToInt32(myreader1[0]);
            }

            String date = cbx_Date.Text;

            DateTime d1 = Convert.ToDateTime(date);
            DateTime dateonly = d1.Date;
            string query2 = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = '" + dateonly + "'";
            SqlConnection conDataBase2 = new SqlConnection(constring);

            SqlCommand cmdDataBase2 = new SqlCommand(query2, conDataBase2);
            SqlDataReader myreader2;
            conDataBase2.Open();
            cmdDataBase2.Parameters.Add(new SqlParameter("0", 1));
            myreader2 = cmdDataBase2.ExecuteReader();
            //MessageBox.Show("Attendance Marked");
            while (myreader2.Read())
            {
                updated_aid = Convert.ToInt32(myreader2[0]);
            }
            //string query2 = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = '" + cmbAttendanceId.Text + "'";


            //int lookid;
            string c = "Select LookupId from Lookup where Name = '" + cbx_Status.Text + "'";
            SqlConnection cn = new SqlConnection(constring);
            SqlCommand cmddatabase3 = new SqlCommand(c, cn);
            SqlDataReader reader;
            cn.Open();
            cmddatabase3.Parameters.Add(new SqlParameter("0", 1));
            reader = cmddatabase3.ExecuteReader();
            while (reader.Read())
            {
                lookid = Convert.ToInt32(reader[0]);
            }



            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            string Qeury = "Update dbo.StudentAttendance Set AttendanceId ='" + updated_aid + "',StudentId ='" + updated_sid + "',AttendanceStatus ='" + lookid + "' Where AttendanceId ='" + att_id + "' AND StudentId = '" + sid + "'";

            SqlCommand cmd = new SqlCommand(Qeury, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Student Attendance Information Updated");
            cbx_RegistrationNumber.Text = "";
            cbx_Status.Text = "";
            cbx_Date.Text = "";
            //cmdAdd.Text = "Add";



            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.StudentAttendance", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                //string temp = dataStudentAttendance.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                //id = Convert.ToInt32(temp);
                string attendance_id = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                string student_id = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                string lookup_id = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                del_attid = Convert.ToInt32(attendance_id);
                del_sid = Convert.ToInt32(student_id);
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();


                string c = "Delete  from dbo.StudentAttendance where AttendanceId = '" + del_attid + "' AND StudentId ='" + del_sid + "'";
                SqlCommand cmd2 = new SqlCommand(c, connection);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Student Attendance Deleted");
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.StudentAttendance", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                }
                //string Qeury = "Delete from dbo.Assessment where ID = '" + id + "'";
                //SqlCommand cmd = new SqlCommand(Qeury, connection);
                //cmd.ExecuteNonQuery();







            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                string temp = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);




                string attendance_id = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                string student_id = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                string lookup_id = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                //cmbAssessmentId.Text = dataAssessmentComponent.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                att_id = Convert.ToInt32(attendance_id);
                db_att = att_id;
                db_std = sid;
                sid = Convert.ToInt32(student_id);
                lookid = Convert.ToInt32(lookup_id);

                // Student reg number
                string query1 = "SELECT RegistrationNumber FROM Student WHERE Id = '" + sid + "'";
                SqlConnection conDataBase1 = new SqlConnection(constring);

                SqlCommand cmdDataBase1 = new SqlCommand(query1, conDataBase1);
                SqlDataReader myreader1;
                conDataBase1.Open();
                cmdDataBase1.Parameters.Add(new SqlParameter("0", 1));
                myreader1 = cmdDataBase1.ExecuteReader();
                //MessageBox.Show("Attendance Marked");
                while (myreader1.Read())
                {
                    reg_no = Convert.ToString(myreader1[0]);
                }
                cbx_RegistrationNumber.Text = reg_no;

                //Attendance Status

                string c = "Select Name from Lookup where LookupId = '" + lookid + "'";
                SqlConnection cn = new SqlConnection(constring);
                SqlCommand cmddatabase3 = new SqlCommand(c, cn);
                SqlDataReader reader;
                cn.Open();
                cmddatabase3.Parameters.Add(new SqlParameter("0", 1));
                reader = cmddatabase3.ExecuteReader();
                while (reader.Read())
                {
                    status = Convert.ToString(reader[0]);
                }
                cbx_Status.Text = status;

                //Attendance Date

                String date = cbx_Date.Text;

                //DateTime d1 = Convert.ToDateTime(date);
                //DateTime dateonly = d1.Date;
                string query2 = "SELECT AttendanceDate FROM ClassAttendance WHERE Id = '" + att_id + "'";
                SqlConnection conDataBase2 = new SqlConnection(constring);

                SqlCommand cmdDataBase2 = new SqlCommand(query2, conDataBase2);
                SqlDataReader myreader2;
                conDataBase2.Open();
                cmdDataBase2.Parameters.Add(new SqlParameter("0", 1));
                myreader2 = cmdDataBase2.ExecuteReader();
                //MessageBox.Show("Attendance Marked");
                while (myreader2.Read())
                {
                    att_date = Convert.ToString(myreader2[0]);
                }
                cbx_Date.Text = att_date;










                btn_Add.Hide();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void cbx_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
