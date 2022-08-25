using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生信息管理系统
{
   
    [Serializable]
    public class Clazz
    {
        public string Clzno { get; set; }
        public string Clzname { get; set; }
        public Clazz(string clzno,string name)
        {
            Clzno = clzno;
            Clzname = name;
        }
    }
    [Serializable]
    public class Student
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Clzno { get; set; }
        public Student(string sno, string name, string clazno)
        {
            Sno= sno;
            Sname = name;
            Clzno = clazno;
        }
    }

    [Serializable]
    public class Course
    {
          public string Cno { get; set; }
          public string Cname { get; set; }
         public Course(string cno, string cname)
        {
            Cno = cno;
            Cname = cname;
        }
    }
    [Serializable]
    public class Grade
    {
        public string Sno { get; set; }
        public string Cno { get; set; }
        public string Score { get; set; }
        public Grade(string sno, string cno, string score)
        {
            Sno = sno;
            Cno= cno;
            Score = score;
        }
    }
    [Serializable]
    class clazzGrade
    {
        public string Clzno { get; set; }
        public string Sno { get; set; }
        public string Clzname { get; set; }
        public string CName { get; set; }
        public string Sname { get; set; }
        public string Score { get; set; }
        public clazzGrade(string clzno, string sno,string clzname, string cName, string sname, string score)
        {
            Clzno = clzno;
            Sno = sno;
            Clzname = clzname;
            CName = cName;
            Sname = sname;
            Score = score;
        }
    }
}
