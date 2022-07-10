using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai3Lab1
{
    internal class Tester
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            ListPeople list = new ListPeople();
            int n;
            Console.WriteLine("Nhap so luong SV");
            n = int.Parse(Console.ReadLine());
            list.NhapDS(arrayList,n);
            list.XuatDS(arrayList,n);
        }
    }
}
