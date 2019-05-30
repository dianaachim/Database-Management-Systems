using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratory1
{
    public partial class Form1 : Form
    {
        SqlConnection dbConn;
        //SqlDataAdapter daHouse, daStudent;
        SqlDataAdapter parent_adapter, child_adapter;
        DataRelation relation;
        DataSet ds;
        SqlCommandBuilder cb;
        BindingSource bsHouse, bsStudent;

        public Form1()
        {
            InitializeComponent();
            String path = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
            this.dbConn = new SqlConnection(path);
            //get data from the db
            //dbConn = new SqlConnection(@"Data Source = DESKTOP-5EB5T3U\SQLEXPRESS; Initial Catalog = HP; Integrated Security = true");
            ds = new DataSet();
            String select_parent = ConfigurationManager.AppSettings.Get("select1");
            String parent = ConfigurationManager.AppSettings.Get("parent");
            this.parent_adapter = new SqlDataAdapter(select_parent, this.dbConn);

            //daHouse = new SqlDataAdapter("SELECT * FROM Broom", dbConn);
            //daStudent= new SqlDataAdapter("SELECT * FROM Student", dbConn);
            //cb = new SqlCommandBuilder(daStudent);
            this.parent_adapter.Fill(ds, parent);

            String select_child = ConfigurationManager.AppSettings.Get("select2");
            String child = ConfigurationManager.AppSettings.Get("child");
            this.child_adapter = new SqlDataAdapter(select_child, this.dbConn);
            this.child_adapter.Fill(ds, child);

            String FKName = ConfigurationManager.AppSettings.Get("FKName");
            String FKID = ConfigurationManager.AppSettings.Get("FKID");
            this.relation = new DataRelation(FKName, ds.Tables[parent].Columns[FKID], ds.Tables[child].Columns[FKID]);
            ds.Relations.Add(relation);

            //DataRelation dr = new DataRelation("FK_Student_Broom", ds.Tables["Broom"].Columns["broom_id"],
            //ds.Tables["Student"].Columns["broom_id"]);
            //ds.Relations.Add(dr);
            //data binding


            cb = new SqlCommandBuilder();
            bsHouse = new BindingSource();
            bsHouse.DataSource = ds;
            bsHouse.DataMember = parent;

            bsStudent = new BindingSource();
            bsStudent.DataSource = bsHouse;
            bsStudent.DataMember = FKName;

            dgvHouse.DataSource = bsHouse;
            dgvStudent.DataSource = bsStudent;
               
            //send changes back to the db (the event handler for the click event of the update db button)
            child_adapter.Update(ds.Tables[child]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String parent = ConfigurationManager.AppSettings.Get("parent");
            String child = ConfigurationManager.AppSettings.Get("child");
            SqlCommandBuilder builder = new SqlCommandBuilder(child_adapter);
            child_adapter.Update(ds.Tables[child]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
