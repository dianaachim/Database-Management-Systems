using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectManagement
{
    public partial class Form1 : Form
    {
        SqlDataAdapter daTask, daDeveloper;
        DataSet ds;
        SqlConnection dbConn;
        SqlCommandBuilder cb;
        BindingSource bsTask, bsDeveloper;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(daTask);
            daTask.Update(ds.Tables["Task"]);
        }

        public Form1()
        {
            InitializeComponent();
            dbConn = new SqlConnection(@"Data Source = DESKTOP-5EB5T3U\SQLEXPRESS; Initial Catalog = ProjectManagement; Integrated Security = true");
            ds = new DataSet();

            daTask = new SqlDataAdapter("SELECT * FROM Task", dbConn);
            daDeveloper = new SqlDataAdapter("SELECT * FROM Developer", dbConn);
            cb = new SqlCommandBuilder(daTask);

            DataRelation dr = new DataRelation("FK__Task__did__5441852A", ds.Tables["Developer"].Columns["did"], ds.Tables["Task"].Columns["did"]);

            ds.Relations.Add(dr);

            bsDeveloper = new BindingSource();
            bsDeveloper.DataSource = ds;
            bsDeveloper.DataMember = "Developer";

            bsTask = new BindingSource();
            bsTask.DataSource = bsDeveloper;
            bsTask.DataMember = "FK__Task__did__5441852A";

            this.DeveloperList.DataSource = bsDeveloper;
            this.TaskList.DataSource = bsTask;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
