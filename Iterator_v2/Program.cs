using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate myCollection = new ConcreteAggregate();

            Student studentA = new Student(18110278, "Nguyen Ngoc Hai", "Nam");
            Student studentB = new Student(18110289, "Tran Van Hoang", "Nam");
            Student studentC = new Student(18110298, "Ta Thi Mai Huong", "Nu");
            Student studentD = new Student(18110344, "Vo Tran Minh Quan", "Nam");

            myCollection.AddItem(studentA);
            myCollection.AddItem(studentB);
            myCollection.AddItem(studentC);
            myCollection.AddItem(studentD);            

            Console.WriteLine("Straight traversal:\n");
            Iterator iterator = myCollection.CreateIterator();
            Student student = iterator.First();
            while (student != null)
            {
                student.printStudentInfo();
                student = iterator.Next();
            }

            Console.WriteLine("Reverse traversal:\n");
            myCollection.ReverseDirection();
            iterator = myCollection.CreateIterator();
            student = iterator.First();
            while (student != null)
            {
                student.printStudentInfo();
                student = iterator.Next();
            }
        }
    }
}
