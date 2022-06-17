using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FLEET_SYSTEM1._0
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Checking if the textfields have been filled
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && cmBoxSelectCompany.SelectedIndex >= 0)
            {
                //txtProccessing.Visible = true;
                //this.Invalidate();
                //this.Validate();


                //When the login is successful
                progressBar.Maximum = 100;
                progressBar.Step = 1;
                progressBar.Value = 0;

                Random ren = new Random();

                for (int i = 0; i < 100; i++)
                {
                    progressBar.Value = i;

                    Thread.Sleep(ren.Next(20));
                }

                //getting the company ID
                try
                {
                    SqlDataAdapter a1 = new SqlDataAdapter("select * from Company where CompanyName = '" + cmBoxSelectCompany.Text + "'", Connection.connect);

                    DataTable d1 = new DataTable();



                    a1.Fill(d1);

                    if (d1.Rows.Count == 1)
                    {
                        ////Get the last users id
                        //SqlDataAdapter a2 = new SqlDataAdapter("select * from Company where CompanyID = '" + cmBoxSelectCompany.SelectedValue.ToString() + "'", Library.Connection.connect);
                        //DataTable d2 = new DataTable();
                        //a2.Fill(d2);

                        //Adding to the two tables
                        try
                        {
                            //Generateing a random user id
                            Random gen = new Random();
                            string id = "E";
                            //loop to generate 4 random numbers
                            for (int i = 0; i < 5; i++)
                            {
                                id += gen.Next(10);
                            }

                            //storing the postion type
                            string position = this.cmbUserRole.GetItemText(this.cmbUserRole.SelectedItem);
                            position = Connection.Position;

                            SqlCommand usersInsert = new SqlCommand("insert into Users values('" + id + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "');", Connection.connect);
                            usersInsert.ExecuteNonQuery();

                            SqlCommand employeesInsert = new SqlCommand("insert into Employees values('" + id + "', '" + d1.Rows[0][0].ToString() + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + position + "');", Connection.connect);
                            employeesInsert.ExecuteNonQuery();

                            MessageBox.Show("User stored to the database");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        Thread.Sleep(100);
                        Complete();
                        Thread.Sleep(100);
                        Signup();

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }


        }

        private void Complete()
        {
            MessageBox.Show("Sign Up Successful \n" +
                "Proceed to log in");
        }

        private void Signup()
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeWindow home = new HomeWindow();
            home.Show();
            this.Dispose();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            try
            {
                //Get all the company names avaiable
                SqlDataAdapter adpt = new SqlDataAdapter("select CompanyName from Company", Connection.connect);

                DataTable dt = new DataTable();

                adpt.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmBoxSelectCompany.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmBoxSelectCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
