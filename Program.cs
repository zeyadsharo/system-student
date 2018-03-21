using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_student1
{
    class student
    {
        public int stnumber;
        public int stage;
        public string stname;
        public string sex;
        public float quizz1;
        public float quizz2;
        public float assigment;
        public float midterm;
        public float final;
        public float total;
        int itemcount = 0;
        public student()
        {
            stnumber = 0;
            stage = 0;
            stname = "no name";
            sex = null;
            quizz1 = 0;
            quizz2 = 0;
            assigment = 0;
            midterm = 0;
            final = 0;
            total = 0;
        }
        public student(int stnumber, int stage, string stname, string sex, float quizz1, float quizz2, float assigment, float midterm, float final, float total)
        {
            this.stnumber = stnumber;
            this.stage = stage;
            this.stname = stname;
            this.sex = sex;
            this.quizz1 = quizz1;
            this.quizz2 = quizz2;
            this.assigment = assigment;
            this.midterm = midterm;
            this.final = final;
            this.total = total;
        }








    }//end the class student 
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
