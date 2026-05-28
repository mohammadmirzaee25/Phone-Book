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
using System.IO;
namespace Phone_Book
{
    public partial class Form1 : Form
    {
        SqlConnection conn1 = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        CurrencyManager cr;


        public Form1()
        {
            InitializeComponent();
        }

        private Size originalPictureBoxSize;
        private PictureBoxSizeMode originalSizeMode;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the directory where your EXE is running
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Go up to the project folder (two levels up from Debug/Release)
            string projectDirectory = Directory.GetParent(exeDirectory).Parent.Parent.FullName;
            string dbPath = Path.Combine(projectDirectory, "Database1.mdf");

            conn1.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";

            try
            {
                conn1.Open();
                fillcombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
            }
            cr = (CurrencyManager)this.BindingContext[ds1, "T1"];
            originalPictureBoxSize = pictureBox1.Size;
            originalSizeMode = pictureBox1.SizeMode;

        }
        void fillcombo(string s = "select * from PhonebookT1")
        {

            cmd1.CommandText = s;
            cmd1.Connection = conn1;
            da1.SelectCommand = cmd1;
            ds1.Clear();
            da1.Fill(ds1, "T1");

            // filling data grid view
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds1, "T1");

            //filling each textn box
            nametxt.DataBindings.Clear();
            nametxt.DataBindings.Add("text", ds1, "T1.name");
            familytxt.DataBindings.Clear();
            familytxt.DataBindings.Add("text", ds1, "T1.family");
            telltxt.DataBindings.Clear();
            telltxt.DataBindings.Add("text", ds1, "T1.tell_number");
            citytxt.DataBindings.Clear();
            citytxt.DataBindings.Add("text", ds1, "T1.city");
            pictureBox1.DataBindings.Clear();
            pictureBox1.DataBindings.Add("imagelocation", ds1, "T1.imageurl");

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            nametxt.ReadOnly = false;
            familytxt.ReadOnly = false;
            telltxt.ReadOnly = false;
            citytxt.ReadOnly = false;

            nametxt.Text = "";
            familytxt.Text = "";
            telltxt.Text = "";
            citytxt.Text = "";

            savebtn.Enabled = true;
            newbtn.Enabled = false;
            browsbtn.Enabled = true;

            nametxt.Focus();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "insert into  PhonebookT1 values (@p1 , @p2 , @p3 , @p4 ,@p5)";
            c.Parameters.AddWithValue("p1", nametxt.Text);
            c.Parameters.AddWithValue("p2", familytxt.Text);
            c.Parameters.AddWithValue("p3", telltxt.Text);
            c.Parameters.AddWithValue("p4", citytxt.Text);
            c.Parameters.AddWithValue("p5", copypic(pictureBox1.ImageLocation, telltxt.Text));
            c.Connection = conn1;
            c.ExecuteNonQuery();

            savebtn.Enabled = false;
            newbtn.Enabled = true;
            browsbtn.Enabled = false;

            nametxt.ReadOnly = true;
            familytxt.ReadOnly = true;
            telltxt.ReadOnly = true;
            citytxt.ReadOnly = true;

            fillcombo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            cr.Position = dataGridView1.CurrentCell.RowIndex;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            cr.Position++;
            dataGridView1.CurrentCell = dataGridView1.Rows[cr.Position].Cells[0];
        }

        private void prebtn_Click(object sender, EventArgs e)
        {
            if (cr.Position != 0)
            {
                cr.Position--;
                dataGridView1.CurrentCell = dataGridView1.Rows[cr.Position].Cells[0];
            }
        }

        private void lastbtn_Click(object sender, EventArgs e)
        {
            cr.Position = cr.Count - 1;
            dataGridView1.CurrentCell = dataGridView1.Rows[cr.Position].Cells[0];
        }

        private void firstbtn_Click(object sender, EventArgs e)
        {
            cr.Position = 0;
            dataGridView1.CurrentCell = dataGridView1.Rows[cr.Position].Cells[0];
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();
            x = MessageBox.Show("do you want to dlete ? " + nametxt.Text + " " + familytxt.Text, "Delete ?", MessageBoxButtons.YesNo);

            if (x == DialogResult.No)
                return;

            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "delete from PhonebookT1 where tell_number=@t1";
            c2.Parameters.AddWithValue("t1", telltxt.Text);
            c2.Connection = conn1;
            c2.ExecuteNonQuery();
            fillcombo();
        }

        private void findtxt_TextChanged(object sender, EventArgs e)
        {
            if (findtxt.Text == "")
            {
                fillcombo();
            }
            else
            {
                SqlCommand c2 = new SqlCommand();
                string field = searchcombobox.Text;
                if (field == "")
                    field = "name";
                string s = c2.CommandText = "select * from PhonebookT1 where " + field + " like '%" + findtxt.Text + "%'";
                fillcombo(s);

            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            if (editbtn.Text == "Edit")
            {
                nametxt.ReadOnly = false;
                familytxt.ReadOnly = false;
                telltxt.ReadOnly = true;
                citytxt.ReadOnly = false;
                browsbtn.Enabled = true;

                editbtn.Text = "apply";
            }

            else
            {
                int currentcell = dataGridView1.CurrentCell.RowIndex;

                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "update PhonebookT1 set name=@p1 , family=@p2 ,   city=@p4 , imageurl=@p5 where tell_number=@p3";
                c3.Parameters.AddWithValue("p1", nametxt.Text);
                c3.Parameters.AddWithValue("p2", familytxt.Text);
                c3.Parameters.AddWithValue("p3", telltxt.Text);
                c3.Parameters.AddWithValue("p4", citytxt.Text);
                c3.Parameters.AddWithValue("p5", copypic(pictureBox1.ImageLocation, telltxt.Text));

                c3.Connection = conn1;
                c3.ExecuteNonQuery();


                fillcombo();
                cr.Position = currentcell;
                dataGridView1.CurrentCell = dataGridView1.Rows[cr.Position].Cells[0];

                nametxt.ReadOnly = true;
                familytxt.ReadOnly = true;
                telltxt.ReadOnly = true;
                citytxt.ReadOnly = true;
                editbtn.Enabled = true;
                browsbtn.Enabled = false;
                editbtn.Text = "Edit";


            }
        }

        private void browsbtn_Click(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();
            x = openFileDialog1.ShowDialog();

            if (x == DialogResult.Cancel)
                return;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        string copypic(string source, string key)
        {
            string curpath;
            string newpath;
            if (source == "")
                return null;
            curpath = Application.StartupPath + @"\images\";
            if (!Directory.Exists(curpath))
                Directory.CreateDirectory(curpath);


            newpath = curpath + key + source.Substring(source.LastIndexOf("."));

            if (File.Exists(newpath))
                File.Delete(newpath);

            File.Copy(source, newpath);
            return newpath;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                // Store current state
                originalPictureBoxSize = pictureBox1.Size;
                originalSizeMode = pictureBox1.SizeMode;

                // Keep the same location, just change size to half of Form1
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Size = new Size(this.Width / 2, this.Height / 2);
                // DO NOT change the Location - it stays where it is
            }
            else
            {
                // Restore original size and mode
                pictureBox1.SizeMode = originalSizeMode;
                pictureBox1.Size = originalPictureBoxSize;
            }
        }

    }
}
