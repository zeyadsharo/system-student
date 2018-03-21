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
        student[] st = new student[30];
          public  int itemcount = 0;
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
                        add(ref itemcount);
                        break;
                    case 2:
                        delete(st, ref itemcount);
                        break;
                    case 3:
                        update(st, itemcount);
                        break;
                    case 4:
                        viewall(st, itemcount);
                        break;
                    case 5:
                        average(st, itemcount);
                        break;
                    case 6:
                        showmax(st, itemcount);
                        break;
                    case 7:
                        showmin(st, itemcount);
                        break;
                    case 8:
                        find(st, itemcount);
                        break;
                    case 9:
                        bubblesort(st, itemcount);
                        break;

                    default: Console.WriteLine("invalid"); break;
                }
                Console.Write("Press y or Y to continue:");

                confirm = Console.ReadLine().ToString();
            } while (confirm == "y" || confirm == "Y");
        }//end the desplay menu
        public void add(ref int itemcount)
        {
          
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
            st[itemcount] = new student(stnumber, stage, stname, sex, quizz1, quizz2, assigment, midterm, final, total);
            itemcount++;
        }//end the added information 
        public int search(student[] st, int id, int itemcount)
        {
            int found = -1;
            for (int i = 0; i < itemcount && found == -1; i++)
            { 
                if (st[i].stnumber == id) found = i;
                else found = -1;
            }
            return found;
        }//end the search function 
        static void clean(student[] st, int index)
        {
            st[index].stnumber = 0;
            st[index].stage = 0;
            st[index].stname = null;
            st[index].sex = null;
            st[index].quizz1 = 0;
            st[index].quizz2 = 0;
            st[index].assigment = 0;
            st[index].midterm = 0;
            st[index].final = 0;
            st[index].total = 0;
        }
        public void delete(student[] st, ref int itemcount)
        {
            int id;
            int index;
            if (itemcount > 0)
            {
                Console.Write("Enter student's ID:");
                id = int.Parse(Console.ReadLine());
                index = search(st, id, itemcount);
                if ((index != -1) && (itemcount != 0))
                {
                    if (index == (itemcount - 1))
                    {
                        clean(st, index);
                        this.itemcount = itemcount--;
                        Console.WriteLine("The record was deleted.");
                    }
                    else
                    {
                        for (int i = index; i < itemcount - 1; i++)
                        {
                            st[i] = st[i + 1];
                            clean(st, itemcount);
                            --itemcount;
                        }
                    }
                }
                else Console.WriteLine("The record doesn't exist.Check the ID and try again.");
            }
            else Console.WriteLine("No record to delete");
        }
        public void viewall(student[] st, int itemcount)
        {

            int i = 0;

            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8}(column index)", "0", "1", "2", "3", "4", "5", "6", "7", "8");
            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8,-5}", "ID", "NAME", "SEX", "Q1", "Q2", "As", "Mi", "Fi", "TOTAL");
            Console.WriteLine("=====================================================");
            while (i < itemcount)
            {
                if (st[i].stnumber != -1)
                {
                    Console.Write("{0,-5}{1,-20}{2,-5}", st[i].stnumber, st[i].stname, st[i].sex);
                    Console.Write("{0,-5}{1,-5}{2,-5}", st[i].quizz1, st[i].quizz2, st[i].assigment);
                    Console.Write("{0,-5}{1,-5}{2,-5}", st[i].midterm, st[i].final, st[i].total);
                    Console.Write("\n");
                }
                i = i + 1;
            }
        }
        public void update(student[] st, int itemcount)
        {
            int id;
            int column_index;
            Console.Write("Enter student's ID:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Name 2.Sex 3. quizz1 4.quizz2 5.assigment score 6.midterm score 7.final score 8.Age");
            Console.Write("Which field you want to update(1-8)?:");
            column_index = int.Parse(Console.ReadLine());
            int index = search(st, id, itemcount);
            if ((index != -1) && (itemcount != 0))
            {
                if (column_index == 1)
                {
                    Console.Write("Enter student's Name:");
                    st[index].stname = Console.ReadLine().ToString();
                }
                else if (column_index == 2)
                {
                    Console.Write("Enter student's Sex(F or M):");
                    st[index].sex = Console.ReadLine().ToString();
                }
                else if (column_index == 3)
                {
                    Console.Write("Enter student's quizz1 score:");
                    st[index].quizz1 = float.Parse(Console.ReadLine());
                }
                else if (column_index == 4)
                {
                    Console.Write("Enter student's quizz2 score:");
                    st[index].quizz2 = float.Parse(Console.ReadLine());
                }
                else if (column_index == 5)
                {
                    Console.Write("Enter student's assigment score:");
                    st[index].assigment = float.Parse(Console.ReadLine());
                }
                else if (column_index == 6)
                {
                    Console.Write("Enter student's midterm score:");
                    st[index].midterm = float.Parse(Console.ReadLine());
                }
                else if (column_index == 7)
                {
                    Console.Write("Enter student's final score:");
                    st[index].final = float.Parse(Console.ReadLine());
                }
                else if (column_index == 8)
                {
                    Console.Write("Enter student's Age:");
                    st[index].stage = int.Parse(Console.ReadLine());
                }
                else Console.WriteLine("Invalid column index");
                st[index].total = st[index].quizz1 + st[index].quizz2 + st[index].assigment + st[index].midterm + st[index].final + st[index].stage;
            }
            else Console.WriteLine("The record deosn't exits.Check the ID and try again.");
        }
        public void average(student[] st, int itemcount)
        {
            int id;
            float avg = 0;
            Console.Write("Enter students'ID:");
            id = int.Parse(Console.ReadLine());
            int index = search(st, id, itemcount);
            if (index != -1 && itemcount > 0)
            {
                st[index].total = st[index].quizz1 + st[index].quizz2 + st[index].assigment + st[index].midterm + st[index].final;
                avg = st[index].total / 5;
            }
            Console.WriteLine("The average score is {0}.", avg);
        }
        public void showmax(student[] st, int itemcount)
        {
            float max = st[0].total;
            int index = 0;
            Console.WriteLine(itemcount);
            if (itemcount >= 2)
            {
                for (int j = 0; j < itemcount - 1; ++j)
                    if (max < st[j + 1].total)
                    {
                        max = st[j + 1].total;
                        index = j + 1;
                    }
            }
            else if (itemcount == 1)
            {
                index = 0;
                max = st[0].total;
            }
            else Console.WriteLine("Not record found!");
            if (index != -1) Console.WriteLine("The student with ID:{0} gets the highest score {1}.", st[index].stnumber, max);
        }
        //method to show min total score
        public void showmin(student[] st, int itemcount)
        {
            float min = st[0].total;
            int index = 0;
            if (itemcount >= 2)
            {
                for (int j = 0; j < itemcount - 1; ++j)
                    if (min > st[j + 1].total)
                    {
                        min = st[j + 1].total;
                        index = j + 1;
                    }
            }
            else if (itemcount == 1)
            {
                index = 0;
                min = st[0].total;
            }
            else Console.WriteLine("No record found!");
            if (index != -1) Console.WriteLine("The student with ID:{0} gets the lowest score {1}.", st[index].stnumber, min);
        }
        //method to find record
        public void find(student[] st, int itemcount)
        {
            int id;
            Console.Write("Enter student's ID:");
            id = int.Parse(Console.ReadLine());
            int index = search(st, id, itemcount);
            if (index != -1)
            {
                Console.Write("{0,-5}{1,-20}{2,-5}", st[index].stnumber, st[index].stname, st[index].sex);
                Console.Write("{0,-5}{1,-5}{2,-5}", st[index].quizz1, st[index].quizz2, st[index].assigment);
                Console.Write("{0,-5}{1,-5}{2,-5}", st[index].midterm, st[index].final, st[index].total);
                Console.WriteLine();
            }
            else Console.WriteLine("The record doesn't exits.");
        }
        public void bubblesort(student[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j].total < dataset[j - 1].total)
                    {
                        student temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }
        }
        public void print()
        {
            st[0].printInfo();
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
