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
    public partial class ManageRubric : Form
    {
        public ManageRubric()
        {
            InitializeComponent();
        }
        //Load of Rubric form where CloId from Clo's table is loaded in combobox.
        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet5.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter1.Fill(this.projectBDataSet5.Rubric);
            //Establishing sql connection
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            //Clo Id selection query
            string query = "SELECT Id FROM Clo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                //MessageBox.Show("Saved");
                while (myreader.Read())
                {
                    comboBox1.Items.Add(myreader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // TODO: This line of code loads data into the 'projectBDataSet4.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet4.Rubric);

        }
        //This is click of button 1 where data is inserted in database.
        private void button1_Click(object sender, EventArgs e)
        {
            //This if checks for provided information.
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                //Establishes sql connection.
                SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
                bool isExist = false;
                string command = "SELECT Id FROM Rubric";
                SqlCommand cmd1 = new SqlCommand(command, con);
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                while(reader.Read())
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    if(id == Convert.ToInt32(reader[0]))
                    {
                        isExist = true;
                        MessageBox.Show("Rubric Id already exists, Please provide another Id for rubric");
                        break;
                    }
                }
                con.Close();
                if(isExist == false)
                {
                    //Insert query
                    string query = "INSERT into Rubric(Id, Details, CloId) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + comboBox1.Text + "'); ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader myreader;
                    try
                    {
                        con.Open();
                        myreader = cmd.ExecuteReader();
                        MessageBox.Show("Data is saved");
                        while (myreader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
                
            }
            //Throws message for not providing details.
            else
            {
                MessageBox.Show("Please! provide details.");
            }
            
        }
        //This is click of button2 where data is shown in datagridview
        private void button2_Click(object sender, EventArgs e)
        {
            //Establishes sql connection
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            //data selection query.
            string query = "select * from Rubric";
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
        //Data is editted and deleted in the datagridview.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Establishes sql connection
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            //string id2 = textBox1.Text;
            //int id1 = Convert.ToInt32(id2);
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //Data deletion
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE from Rubric WHERE Id = @id1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.ExecuteReader();
                    con.Close();
                }
            }
            //Data updation
            if (e.ColumnIndex == 3)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

            }
        }
        //This is the click of button3 where data is updated
        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            //Establishes sql connection
            SqlConnection con = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
            //Update query
            string query = "UPDATE Rubric SET Id = '" + this.textBox1.Text + "', Details = '" + textBox2.Text + "', CloId = '" + comboBox1.Text + "' WHERE Id= '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            //Data inputs are cleared after updation
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            //Showing updated data in datagridview
            using (SqlConnection sqlcon = new SqlConnection("Data Source = AISHA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Rubric", sqlcon);
                DataTable d = new DataTable();
                sqlDA.Fill(d);
                dataGridView1.DataSource = d;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NMBR_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Linkage with Clo
        private void button4_Click(object sender, EventArgs e)
        {
            ManageClo c = new ManageClo();
            this.Hide();
            c.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Linkage with home page.
        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
