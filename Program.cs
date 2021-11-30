using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject
{
     class forExample
    {
        //public giúp thành phần mang thuộc tính này có thể dùng ở bất kì vị trí nào
        public string tiengcuoi;
        public string tanso;
        //private chỉ nội bộ bên trong lớp chứa nó mới có quyền truy cập.
        private string tiengkhoc;
        // tương tự như private nhưng có thể truy cập tại lớp được  kế thừa
        protected string tansokhoc;

        
       
       

    }

    class Amthanh : forExample
    {
        public  Amthanh()
        {
            //public giúp tiengcuoi và tanso từ lớp forExample có thể truy cập được
            tiengcuoi = "Hehehe";
            tanso = "75Hz";
            //vi để thuộc tính private cho tieng khoc nên không thể truy cập ở ngoài lớp forExample được
            // tiengkhoc = "huhu";
            //Amthanh đã kế thừa forExample nên dùng được tần số khóc
            tansokhoc = "50HZ";
        }
     
        }
       
    }

public class Program
{

    /* static sẽ tạo ra 1 thành viên tĩnh 
     * có 4 loại thành viên tĩnh: biến tĩnh, lớp tĩnh ,phương thức tĩnh, phương thức khởi tạo tĩnh

     */
    //1 lớp tĩnh
    static class MauSac
    {
        /* khai báo biến tĩnh MauChuDao là 1 chuỗi ký tự lưu tên màu tương ứng */
        public static string MauChuDao;
        /* Dùng static constructor để kiểm tra ngày hiện tại và khởi tạo giá trị cho biến tĩnh MauChuDao */
        static MauSac()
        {

            DateTime now = DateTime.Now;

            /* switch case lấy ra thứ của ngày hiện tại và so sánh với 7 ngày trong tuần */
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Monday:
                    MauChuDao = "Blue";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
            }
        }

    }
    class tinhtoan
    {
        //khai báo phương thức tĩnh tính lũy thừa 
        public static long LuyThua(int coso, int somu)
        {
            long KetQua = 1;
            for (int i = 0; i < somu; i++)
            {
                KetQua *= coso;
            }

            return KetQua;
        }
    }



    static void Main(string[] args)
    {

        Console.WriteLine(" Mau chu dao cua hom nay: " + MauSac.MauChuDao);
        /*
   Gọi phương thức thông qua tên lớp và không cần khởi tạo đối tượng.
       */
        Console.WriteLine("Lũy thừa của 3 là: " + tinhtoan.LuyThua(3, 3));
        //vidu ve if else va ?:

        string stra;


        Console.WriteLine("nhap vao ");
        stra = Console.ReadLine();

        if (stra == "hehehe")
        {
            Console.WriteLine("tieng cuoi");
        }
        else

        {
            Console.WriteLine("khong phai tieng cuoi");
        }

        // toan tu ngoi 3


       string check = (stra == "hehehe") ? "tieng cuoi" : "khong phai tieng cuoi";
        Console.WriteLine(check);



        }
    }


