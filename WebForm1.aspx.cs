using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Student_DB;
using System.Data;
using System.Data.SqlClient;

namespace Student_DB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //String inputUrl = "data source = .; database=Student; integrated security = SSPI";
            //SqlConnection conn = new SqlConnection(inputUrl);
            //conn.Open();
            //string query = "select * from Student_Details;";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //GridView1.DataSource = dr;
            //GridView1.DataBind();
            //conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String inputUrl = "data source = .; database=Student; integrated security = SSPI";
            SqlConnection conn = new SqlConnection(inputUrl);
            conn.Open();
            string query = "select * from Student_Details;";
            string query1 = "select sd.ID,sd.name, sd.InstructorId, ir.Name from Student_Details sd join Instructor ir on sd.InstructorId = ir.InstructorId";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand c = new SqlCommand(query1, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            conn.Close();


            //Student s = new Student();
            //DataSet ds = s.GetStudentData();
            //GridView1.DataSource = ds;
            //GridView1.DataBind();

        }
    }
}