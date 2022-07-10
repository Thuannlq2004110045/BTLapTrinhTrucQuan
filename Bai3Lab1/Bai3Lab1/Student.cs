using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3Lab1
{
    internal class Student : People
    {
        private float DiemTB;

        public float DiemTB1 { get => DiemTB; set => DiemTB = value; }

        public Student()
        : base()
        {
            this.DiemTB = 0;
        }
        public Student(int id, string ten, string kh, float DiemTB)
        : base(id, ten, kh)
        {
            this.DiemTB = DiemTB;
        }

        public override void Nhap1SV()
        {
            base.Nhap1SV();
            Console.WriteLine("Nhap DiemTB {0}:");
            this.DiemTB1 = float.Parse(Console.ReadLine());                
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Khoa:{0}", this.DiemTB);
        }
    }
}
