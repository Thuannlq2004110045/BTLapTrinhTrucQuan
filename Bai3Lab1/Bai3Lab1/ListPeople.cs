using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai3Lab1
{
    internal class ListPeople
    {
        ArrayList arrayList = new ArrayList();
        public void NhapDS(ArrayList arraylist, int n)
        {
            Console.WriteLine("\n ====Nhap DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                People people = new Student();
                Console.WriteLine("Nhap thong tin SV{0}", i + 1);
                people.Nhap1SV();
                arraylist.Add(people);
            }
        }

        public void XuatDS(ArrayList arraylist, int n)
        {
            Console.WriteLine("\n ====Xuat DS Sinh Vien====");
            foreach (People people in arraylist)
            {
                people.Show();
            }
            Console.ReadLine();
        }
    }
}
