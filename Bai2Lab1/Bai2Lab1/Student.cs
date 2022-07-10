using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab1
{
    internal class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student() //Constructor mac dinh
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student stu) //Constrctor sao chep
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        //Constrctor tham so
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public void setSID(int sid)
        {
            this.SID = sid;
        }

        public int getSID()
        {
            return this.SID;
        }

        public void setTenSV(string tenSV)
        {
            this.TenSV = tenSV;
        }

        public string getTenSV()
        {
            return this.TenSV;
        }

        public void setKhoa(string khoa)
        {
            this.Khoa = khoa;
        }

        public string getKhoa()
        {
            return this.Khoa;
        }

        public void setDiemTB(float diemTB)
        {
            this.DiemTB = diemTB;
        }

        public float getDiemTB()
        {
            return this.DiemTB;
        }

        //Phuong thuc hien thi du lieu
        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }


        public void Nhap1SV()
        {
            
            Console.WriteLine("Nhap MaSV {0}:");
            this.setSID(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nhap TenSV {0}:");
            this.setTenSV(Console.ReadLine());
            Console.WriteLine("Nhap Khoa {0}:");
            this.setKhoa(Console.ReadLine());
            Console.WriteLine("Nhap Diem TB {0}:");
            this.setDiemTB(float.Parse(Console.ReadLine()));
        }

        public void NhapDS(Student[] DSSV,int n)
        {
            //Student[] DSSV;
            //int n;
            //Console.WriteLine("Nhap so luong SV");
            //n = int.Parse(Console.ReadLine());
            //DSSV = new Student[n]; //tao mang n phan tu
            Console.WriteLine("\n ====Nhap DS SINH VIEN====");
            for(int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.WriteLine("Nhap thong tin SV{0}", i+1);
                DSSV[i].Nhap1SV();
            }
        }

        public void XuatDS(Student[] DSSV,int n)
        {
            Console.WriteLine("\n ====Xuat DS Sinh Vien====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i].Show();
            }
            Console.ReadLine();
        }
    }

    class Tester
    {
        public static void Main()
        {
            Student[] DSSV;
            int n;
            Console.WriteLine("Nhap so luong SV");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n]; //tao mang n phan tu
            Student student = new Student();
            student.NhapDS(DSSV,n);
            student.XuatDS(DSSV,n);
        }
    }
}
