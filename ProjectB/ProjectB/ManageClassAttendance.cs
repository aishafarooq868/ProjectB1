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
    public partial class ManageClassAttendance : Form
    {
        public ManageClassAttendance()
        {
            InitializeComponent();
        }
        SqlConnection constring = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
        int id;
        private void ManageClassAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet10.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet10.ClassAttendance);
            btn_update.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                constring.Open();
                String cmd = String.Format("INSERT INTO ClassAttendance(AttendanceDate) values('{0}')", this.monthCalendar1.SelectionEnd.Date);
                SqlCommand command = new SqlCommand(cmd, constring);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Class Attendance Added");
                constring.Close();
                cmd = "SELECT * FROM ClassAttendance";
                command = new SqlCommand(cmd, constring);
                command.Parameters.Add(new SqlParameter("0", 1));
                constring.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, constring);
                DataTable view = new DataTable();
                adapter.Fill(view);
                dataGridView1.DataSource = view;
                constring.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                constring.Open();
                int row = e.RowIndex;
                int id1 = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
                string c = "Delete  from dbo.StudentAttendance where AttendanceId = '" + id + "'";
                SqlCommand cmd2 = new SqlCommand(c, constring);
                cmd2.ExecuteNonQuery();
                


                string run = "Delete from dbo.ClassAttendance where Id = '" + id + "'";
                SqlCommand cmd1 = new SqlCommand(run, constring);
                cmd1.ExecuteNonQuery();
                
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Class Date has been deleted");
                constring.Close();

            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                string t = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                string date = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                DateTime dat = Convert.ToDateTime(date);
                monthCalendar1.SetDate(dat);
                btn_add.Hide();
                btn_update.Show();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            constring.Open();
            string Query = "Update ClassAttendance Set  AttendanceDate ='" + monthCalendar1.SelectionEnd.Date + "' where Id ='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, constring);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Class Attendance has been Updated");
            constring.Close();
            String query = "SELECT * FROM ClassAttendance";
            cmd = new SqlCommand(query, constring);
            cmd.Parameters.Add(new SqlParameter("0", 1));
            constring.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(query, constring);
            DataTable view = new DataTable();
            adapter.Fill(view);
            dataGridView1.DataSource = view;
            constring.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
        }
    }
}
