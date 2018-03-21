using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_student1
{
    class student
    {
        public int stnumber=0;
        public int stage;
        public string stname;
        public string sex;
        public float quizz1;
        public float quizz2;
        public float assigment;
        public float midterm;
        public float final;
        public float total;
        static public int itemcount = -1;
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
        }//end the prametrized constractor    
       public void printInfo()
        {
            Console.WriteLine("Student number:"+ stnumber);
            Console.WriteLine("Student Age:"+stage);
            Console.WriteLine("Student sex:"+sex);
            Console.WriteLine("Quizz1:");
            Console.WriteLine("Quizz2:");
            Console.WriteLine("assigment:"+assigment);
            Console.WriteLine("Midterm:"+midterm);
            Console.WriteLine("Final"+final);
            Console.WriteLine("Total:"+total);    
        }//end the print info


    }//end the class student 
    class Intial
    {
        student[] st=new student[30];
        public void displaymenu()
        {
            Console.WriteLine("======================================================\n                         MENU                         \n======================================================");
            Console.WriteLine(" 1.Add student records");
            Console.WriteLine(" 2.Delete student records");
            Console.WriteLine(" 3.Update student records");
            Console.WriteLine(" 4.View all student records");
            Console.WriteLine(" 5.Calculate an average of a selected student's scores");
            Console.WriteLine(" 6.Show student who get the max total score");
            Console.WriteLine(" 7.Show student who get the min total score");
            Console.WriteLine(" 8.Find a student by ID");
            Console.WriteLine(" 9.Sort students by TOTAL");
            //create an array to store only 30 students'records for testing.
            int choice;
            string confirm;

            do
            {
                Console.Write("Enter your choice(1-8):");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        add(ref student.itemcount);
                        break;
                    //case 2:
                    //    delete(st, ref itemcount);
                    //    break;
                    //case 3:
                    //    update(st, itemcount);
                    //    break;
                    //case 4:
                    //    viewall(st, itemcount);
                    //    break;
                    //case 5:
                    //    average(st, itemcount);
                    //    break;
                    //case 6:
                    //    showmax(st, itemcount);
                    //    break;
                    //case 7:
                    //    showmin(st, itemcount);
                    //    break;
                    //case 8:
                    //    find(st, itemcount);
                    //    break;
                    //case 9:
                    //    bubblesort(st, itemcount);
                    //    break;

                    default: Console.WriteLine("invalid"); break;
                }
                Console.Write("Press y or Y to continue:");

                confirm = Console.ReadLine().ToString();

            } while (confirm == "y" || confirm == "Y");
        }//end the desplay menu


        public void add(ref int itemcount)
        {
           itemcount++;
            Console.WriteLine(itemcount);
            Console.Write("Enter student's ID:");
           int stnumber= int.Parse(Console.ReadLine());
            Console.Write("Enter student's St age:");
            int stage = int.Parse(Console.ReadLine());
            while (stage < 0)
            {
                Console.Write("You have enter a wrong age!!\n ReEnter student's Age:");
                stage = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter student's Name:");
            string stname = Console.ReadLine().ToString();

            Console.Write("Enter student's Sex(F or M):");
           string sex = Console.ReadLine().ToString();

            Console.Write("Enter student's quizz1 score:");
            float quizz1 = float.Parse(Console.ReadLine());

            Console.Write("Enter student's quizz2 score:");
            float quizz2 = float.Parse(Console.ReadLine());

            Console.Write("Enter student's assigment score:");
            float assigment = float.Parse(Console.ReadLine());

            Console.Write("Enter student's mid term score:");
           float midterm = float.Parse(Console.ReadLine());
            Console.Write("Enter student's final score:");
            float final = float.Parse(Console.ReadLine());
            
             float total = quizz1 + quizz2 + assigment + midterm +final;
            //++this.itemcount;
            st[itemcount] = new student(stnumber, stage, stname, sex, quizz1, quizz2, assigment, midterm, final, total);
        }
       public void print()
        {
            Console.WriteLine(student.itemcount);
            for (int i = 0; i < student.itemcount; i++)
            {
                st[i].printInfo();
            }
        }
        
    } //end the intial student 
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            Intial I1 = new Intial();
            I1.displaymenu();
            I1.print();
            Console.ReadKey();
        }
    }
}
