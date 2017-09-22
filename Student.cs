using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Student_DB
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor_Name { get; set; }
        public int InstructorId { get; set; }

        //public DataSet GetStudentData()
        //{
        //    //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //    //SqlConnection sc = new SqlConnection(cs);
        //    //sc.Open();
        //    //SqlDataAdapter sd = new SqlDataAdapter("spStudentDetails", sc);
        //    //sd.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    //DataSet ds = new DataSet();
        //    //sd.Fill(ds);
        //    //sc.Close();
        //    //return ds;

        //}
    }
}