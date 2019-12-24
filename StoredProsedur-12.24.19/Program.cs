using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProsedur_12._24._19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable students = new DataTable();
            students = DbHelper.GetAllStudents();
            PrintTable(students);
            Console.WriteLine(DbHelper.GetStudentCountWithAge(23));
            Console.ReadKey();
        }

        static void PrintTable(DataTable students)
        {
            foreach (DataColumn column in students.Columns)
            {
                Console.Write($"{column,-15} ");
            }
            Console.WriteLine();
            foreach ( DataRow  row in students.Rows)
            {
                foreach (DataColumn column in students.Columns)
                {
                    Console.Write($"{row[column],-15} ");
                }
                Console.WriteLine();
            }
        }
    }
}
