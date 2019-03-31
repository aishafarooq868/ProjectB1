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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }
        //This the click of button 1 where data is inserted into the database.
        private void button1_Click(object sender, EventArgs e)
        {
            //This if sets allowable and non allowable inputs.
            if(textBox1.Text != "" &&  textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                //Builds connection with Database.
                SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
                //Data insert query 
                string query = "INSERT into Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "'); ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Data is Saved");
                    //Clears textboxes after adding data.
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    while (myreader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Throws message in case of not providing data
            else
            {
                MessageBox.Show("Please! provide details.");
            }
            
        }
        //This is the click of button2 where data from the database is shown in the datagridview.
        private void button2_Click(object sender, EventArgs e)
        {
            //Cretes database connection.
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            //Query for selecting data to be shown in the grid.
            string query = "SELECT * FROM Student";
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
        //Validation on Email
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBox4.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox4, "Please, provide a valid Email Address");
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*foreach (char a in textBox3.Text)
            {
                if (char.IsLetter(a) || char.IsPunctuation(a) || char.IsSymbol(a))
            {
                MessageBox.Show("Invalid Contact");
            }
            }*/
            //string a = textBox3.Text;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox7.Hide();
            // TODO: This line of code loads data into the 'projectBDataSet2.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter1.Fill(this.projectBDataSet2.Student);
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);

        }
        //Linkage with home page.
        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
            
        }
        //Delete and edit data in the datagridview.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            //Data Editing.
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 7)
            {
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                
            }
            //Data deletion.
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "delete from Student where Id = @id1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.ExecuteReader();
                    con.Close();
                }
            }
        }
        //Validation for the contact number.
        private void NMBR_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox3.Text.Length > 11)
            {
                MessageBox.Show("Contact number can be no more longer than 11");
            }
        }
        //Valoidation for first name.
        private void TXT_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //valoidation for last name.
        private void TXT1_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Validation for status.
        private void NMBR1_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Linkage with Clo Form
        private void button4_Click(object sender, EventArgs e)
        {
            ManageClo m = new ManageClo();
            this.Hide();
            m.Show();
        }
        //Updating the data
        private void button5_Click(object sender, EventArgs e)
        {
            string id = textBox7.Text;
            //Establishing connection with sql
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            //Update query
            string query = "UPDATE Student Set FirstName = '" + this.textBox1.Text + "', LastName = '"+this.textBox2.Text+"', Contact = '"+this.textBox3.Text+"', Email = '"+this.textBox4.Text+"', RegistrationNumber = '"+this.textBox5.Text+"', Status = '"+this.textBox6.Text+"' WHERE Id= '"+id+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            //clears textboxes after updating.
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            //shows updated data in datagridview.
            using (SqlConnection sqlcon = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Student", sqlcon);
                DataTable d = new DataTable();
                sqlDA.Fill(d);
                dataGridView1.DataSource = d;
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
