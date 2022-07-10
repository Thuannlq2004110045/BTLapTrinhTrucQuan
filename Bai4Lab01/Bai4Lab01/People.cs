using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai4Lab01
{
    internal abstract class People
    {
        private string hoTen;
        private string namSinh;
        private string bangCap;

        public People()
        {
            hoTen = null;
            namSinh = null;
            bangCap = null;
        }

        public People(People people)
        {
            hoTen = people.hoTen;
            namSinh = people.namSinh;
            bangCap = people.bangCap;
        }

        public People(string hoTen, string namSinh, string bangCap)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.bangCap = bangCap;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }


        public override string ToString()
        {
            return " Ho Ten: " + this.hoTen + "  Nam Sinh: " + this.namSinh + "  Bang cap: " + this.bangCap;
        }
        
    }

    internal abstract class CongChuc : People
    {
        private string chucVu;
        private int soNgayCong;
        private float bacLuong;



        public CongChuc()
        : base()
        {
            this.ChucVu = null;
            this.BacLuong = 0;
        }
        public CongChuc(string hoTen, string namSinh, string bangCap, string chucVu, int soNgayCong, float bacLuong)
        : base(hoTen, namSinh, bangCap)
        {
            this.SoNgayCong = soNgayCong;
            this.ChucVu = chucVu;
            this.BacLuong = bacLuong;
        }

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public float BacLuong { get => bacLuong; set => bacLuong = value; }
        public int SoNgayCong { get => soNgayCong; set => soNgayCong = value; }


        public override string ToString()
        {
            return base.ToString() + "  Chuc vu: " + this.chucVu + "  Bac Luong: " + this.bacLuong + "  So ngay cong: " + this.soNgayCong;
        }

        public abstract float tinhLuong();
    }

    class NhaKhoaHoc : CongChuc
    {
        private int soBaiBao;

        public int SoBaiBao { get => soBaiBao; set => soBaiBao = value; }

        public NhaKhoaHoc()
        : base()
        {
            this.SoBaiBao = 0;
        }
        public NhaKhoaHoc(string hoTen, string namSinh, string bangCap, string chucVu, float bacLuong, int soBaiBao, int soNgayCong)
        : base(hoTen, namSinh, bangCap, chucVu, soNgayCong, bacLuong)
        {
            this.soBaiBao = soBaiBao;
        }

        public override string ToString()
        {
            return base.ToString() + "  So bai bao: " + this.soBaiBao + "  Luong: " + this.tinhLuong();
        }

        public override float tinhLuong()
        {
            float luong = 0;
            luong = this.SoNgayCong * this.BacLuong;
            return luong;
        }
    }

    class NhaQuanLy : CongChuc
    {
        public NhaQuanLy()
        : base()
        {

        }
        public NhaQuanLy(string hoTen, string namSinh, string bangCap, string chucVu, float bacLuong,int soNgayCong)
        : base(hoTen, namSinh, bangCap, chucVu, soNgayCong, bacLuong)
        {

        }
        public override string ToString()
        {
            return base.ToString() + "  Luong: " + this.tinhLuong();
        }
        public override float tinhLuong()
        {
            float luong = 0;
            luong = this.SoNgayCong * this.BacLuong;
            return luong;
        }
    }

    class NhanVien : People
    {
        private float luong;

        public float Luong { get => luong; set => luong = value; }

        public NhanVien()
        : base()
        {
            this.Luong = 0;
        }
        public NhanVien(string hoTen, string namSinh, string bangCap, float luong)
        : base(hoTen, namSinh, bangCap)
        {
            this.luong = luong;
        }       

        public override string ToString()
        {
            return base.ToString() + "  luong: " + this.luong;
        }        
    }

    class ListPeople
    {
        List<People> arrayList = new List<People>();

        public People Nhap()
        {

            People people = null;

            Console.WriteLine("Nhap Ho ten {0}:");
            String hoTen = Console.ReadLine();
            Console.WriteLine("Nhap Nam sinh {0}:");
            string namSinh = Console.ReadLine();
            Console.WriteLine("Nhap Bang Cap {0}:");
            string bangCap = Console.ReadLine();
            Console.WriteLine("Ban nhap loai nao? {0}:");
            int loai = int.Parse(Console.ReadLine());
            if (loai == 1)
            {
                Console.WriteLine("Nha khoa hoc");
                Console.WriteLine("Nhap Chuc vu {0}:");
                string chucVu = Console.ReadLine();
                Console.WriteLine("Nhap so ngay cong {0}:");
                int soNgayCong = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap bac luong {0}:");
                float bacLuong = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so bai bao {0}:");
                int soBaiBao = int.Parse(Console.ReadLine());
                people = new NhaKhoaHoc(hoTen, namSinh, bangCap, chucVu, bacLuong, soBaiBao, soNgayCong);
            }else if(loai == 2)
            {
                Console.WriteLine("Nha quan ly");
                Console.WriteLine("Nhap Chuc vu {0}:");
                string chucVu = Console.ReadLine();
                Console.WriteLine("Nhap so ngay cong {0}:");
                int soNgayCong = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap bac luong {0}:");
                float bacLuong = float.Parse(Console.ReadLine());
                people = new NhaQuanLy(hoTen, namSinh, bangCap, chucVu, bacLuong, soNgayCong);
            }else if(loai==3)
            {
                Console.WriteLine("Nhan vien phong thi ngiem");
                Console.WriteLine("Nhap luong ");
                float luong = float.Parse(Console.ReadLine());
                people = new NhanVien(hoTen, namSinh, bangCap, luong);
            }
            return people;
        }
        public void ThemPeople(People people)
        {
            this.arrayList.Add(people);
        }

        public void XuatDS()
        {
            Console.WriteLine("\n ====Xuat DS====");
            foreach (People people in arrayList)
            {
                Console.WriteLine(people.ToString());
                
            }
            Console.ReadLine();
        }

        public void XuatTongLuong()
        {
            float sumLuongNhaKhoaHoc = 0;
            float sumLuongNhaQuanLy = 0;
            float sumLuongNhanVienPhongThiNghiem = 0;

            foreach (NhaKhoaHoc nhaKhoaHoc in arrayList)
            {
                sumLuongNhaKhoaHoc += nhaKhoaHoc.tinhLuong();
            }
            Console.WriteLine(sumLuongNhaKhoaHoc);
            foreach (NhaQuanLy nhaQuanLy in arrayList)
            {
                sumLuongNhaQuanLy += nhaQuanLy.tinhLuong();
            }
            Console.WriteLine(sumLuongNhaQuanLy);
            foreach (NhanVien nhanVien in arrayList)
            {
                sumLuongNhanVienPhongThiNghiem += nhanVien.Luong;
            }
            Console.WriteLine(sumLuongNhanVienPhongThiNghiem);
            Console.ReadLine();
        }
    }

    internal class Tester
    {
        public static void Main()
        {
            ListPeople listPeople = new ListPeople();
            int n;
            Console.WriteLine("nhap so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                People people = listPeople.Nhap();
                listPeople.ThemPeople(people);
                
            }            
            listPeople.XuatDS();
            listPeople.XuatTongLuong();
        }
    }
}
