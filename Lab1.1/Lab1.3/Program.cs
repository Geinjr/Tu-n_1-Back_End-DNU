

using System;
using bai_1;
using bai_10;
using bai_11;
using bai_12;
using bai_13;
using bai_14;
using bai_2;
using bai_5;
using bai_6;
using bai_8;
using bai_9;
using QLDC;
//Bài 1
namespace bai_1
{
    class Program
    {
        static void Main()
        {
            QLCB qlcb = new QLCB();
            while (true)
            {
                Console.WriteLine("1. Thêm cán bộ");
                Console.WriteLine("2. Tìm kiếm theo họ tên");
                Console.WriteLine("3. Hiển thị danh sách cán bộ");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1: qlcb.ThemCanBo(); break;
                    case 2: qlcb.TimKiemTheoHoTen(); break;
                    case 3: qlcb.HienThiDanhSach(); break;
                    case 4: return;
                    default: Console.WriteLine("Chọn sai, vui lòng nhập lại!"); break;
                }
            }
        }
    }
}

//Bài 2
namespace bai_2
{
    class Program
    {
        static void Main()
        {
            QuanLyTailieu qltl = new QuanLyTailieu();
            while (true)
            {
                Console.WriteLine("1. Thêm tài liệu");
                Console.WriteLine("2. Hiển thị danh sách tài liệu");
                Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        qltl.ThemTaiLieu();
                        break;
                    case 2:
                        qltl.HienThiDanhSachTaiLieu();
                        break;
                    case 3:
                        qltl.TimKiemTheoLoai();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}

//Bài 3
namespace bai_3
{
    class Program
    {
        static void Main()
        {
            QuanLyTuyenSinh qlts = new QuanLyTuyenSinh();
            while (true)
            {
                Console.WriteLine("1. Nhập thông tin thí sinh");
                Console.WriteLine("2. Hiển thị thông tin thí sinh đã trúng tuyển");
                Console.WriteLine("3. Tìm kiếm thí sinh theo số báo danh");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        qlts.NhapThiSinh();
                        break;
                    case 2:
                        qlts.HienThiDanhSachThiSinh();
                        break;
                    case 3:
                        qlts.TimKiemTheoSoBaoDanh();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }

}

//Bài 4
namespace bai_4
{
    class Program
    {
        static void Main()
        {
            KhuPho khuPho = new KhuPho();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhập danh sách hộ dân");
                Console.WriteLine("2. Hiển thị tất cả hộ dân");
                Console.WriteLine("3. Tìm kiếm theo họ tên");
                Console.WriteLine("4. Tìm kiếm theo số nhà");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        khuPho.NhapDanhSachHoDan();
                        break;
                    case "2":
                        khuPho.HienThiTatCa();
                        break;
                    case "3":
                        Console.Write("Nhập họ tên cần tìm: ");
                        string ten = Console.ReadLine();
                        khuPho.TimKiemTheoTen(ten);
                        break;
                    case "4":
                        Console.Write("Nhập số nhà cần tìm: ");
                        int soNha = int.Parse(Console.ReadLine() ?? "0");
                        khuPho.TimKiemTheoSoNha(soNha);
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                        break;
                }
            }
        }
    }
}
}

//Bài 5


namespace bai_5
{
    class Program
    {
        static void Main()
        {
            KhachSan ks = new KhachSan();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhập danh sách khách trọ");
                Console.WriteLine("2. Hiển thị tất cả khách trọ");
                Console.WriteLine("3. Tìm kiếm theo họ tên");
                Console.WriteLine("4. Tính tiền khi trả phòng");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        ks.NhapDanhSach();
                        break;
                    case "2":
                        ks.HienThiTatCa();
                        break;
                    case "3":
                        Console.Write("Nhập họ tên cần tìm: ");
                        string ten = Console.ReadLine();
                        ks.TimKiemTheoTen(ten);
                        break;
                    case "4":
                        ks.TinhTienKhach();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}

//Bài 6


namespace bai_6
{
    class Program
    {
        static void Main()
        {
            TruongTHPT truong = new TruongTHPT();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhập danh sách học sinh");
                Console.WriteLine("2. Hiển thị học sinh nữ sinh năm 1985");
                Console.WriteLine("3. Tìm kiếm theo quê quán");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        truong.NhapDanhSach();
                        break;
                    case "2":
                        truong.HienThiNu1985();
                        break;
                    case "3":
                        Console.Write("Nhập quê quán cần tìm: ");
                        string qq = Console.ReadLine();
                        truong.TimKiemTheoQueQuan(qq);
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}

//Bài 7


namespace bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CBGV> danhSachCBGV = new List<CBGV>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Nhập danh sách cán bộ giáo viên");
                Console.WriteLine("2. Hiển thị danh sách cán bộ giáo viên");
                Console.WriteLine("3. Tìm kiếm cán bộ theo quê quán");
                Console.WriteLine("4. Hiển thị cán bộ có lương > 5 triệu");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.Write("Nhập số lượng cán bộ: ");
                        int n = int.Parse(Console.ReadLine() ?? "0");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhập thông tin cán bộ thứ {i + 1}:");
                            CBGV cb = new CBGV();
                            cb.Nhap();
                            danhSachCBGV.Add(cb);
                        }
                        break;
                    case "2":
                        Console.WriteLine("\n==> Danh sách cán bộ giáo viên:");
                        foreach (var cb in danhSachCBGV)
                        {
                            cb.HienThi();
                        }
                        break;
                    case "3":
                        Console.Write("Nhập quê quán cần tìm: ");
                        string que = Console.ReadLine();
                        Console.WriteLine($"\n==> Kết quả tìm kiếm cán bộ quê ở {que}:");
                        foreach (var cb in danhSachCBGV)
                        {
                            if (cb.QueQuan.ToLower().Contains(que.ToLower()))
                            {
                                cb.HienThi();
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n==> Danh sách cán bộ có lương thực lĩnh > 5 triệu:");
                        foreach (var cb in danhSachCBGV)
                        {
                            if (cb.TinhLuong() > 5000000)
                            {
                                cb.HienThi();
                            }
                        }
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Đang thoát...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}

//Bài 8


namespace bai_8
{
    class Program
    {
        static void Main()
        {
            QuanLyTheMuon qltm = new QuanLyTheMuon();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n====== MENU QUẢN LÝ MƯỢN SÁCH ======");
                Console.WriteLine("1. Nhập danh sách thẻ mượn");
                Console.WriteLine("2. Hiển thị tất cả thẻ mượn");
                Console.WriteLine("3. Tìm kiếm theo mã số sinh viên");
                Console.WriteLine("4. Hiển thị sinh viên quá hạn trả sách");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        qltm.NhapDanhSach();
                        break;
                    case "2":
                        qltm.HienThiTatCa();
                        break;
                    case "3":
                        Console.Write("Nhập mã số sinh viên cần tìm: ");
                        string maSV = Console.ReadLine();
                        qltm.TimKiemTheoMaSV(maSV);
                        break;
                    case "4":
                        qltm.HienThiQuaHan();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}


//Bài 9


namespace bai_9
{
    class Program
    {
        static void Main()
        {
            QuanLyBienLai qlbl = new QuanLyBienLai();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n====== MENU QUẢN LÝ BIÊN LAI ======");
                Console.WriteLine("1. Nhập danh sách biên lai");
                Console.WriteLine("2. Hiển thị tất cả biên lai");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        qlbl.NhapDanhSach();
                        break;
                    case "2":
                        qlbl.HienThiTatCa();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}

//Bài 10


namespace bai_10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nhập vào một xâu văn bản: ");
            string inputText = Console.ReadLine();

            // Khởi tạo đối tượng VanBan
            VanBan vanBan = new VanBan(inputText);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Đếm số từ trong xâu");
                Console.WriteLine("2. Đếm số ký tự 'H' (không phân biệt chữ hoa và chữ thường)");
                Console.WriteLine("3. Chuẩn hóa xâu");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine($"Số từ trong xâu: {vanBan.DemSoTu()}");
                        break;
                    case "2":
                        Console.WriteLine($"Số ký tự 'H' trong xâu: {vanBan.DemSoKyTuH()}");
                        break;
                    case "3":
                        vanBan.ChuanHoa();
                        vanBan.HienThi();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}


namespace bai_11

{
    class Program
    {
        static void Main()
        {
            // Khởi tạo hai số phức
            SoPhuc soPhucA = new SoPhuc();
            SoPhuc soPhucB = new SoPhuc();

            // Nhập vào hai số phức
            Console.WriteLine("Nhập số phức A:");
            soPhucA.Nhap();
            Console.WriteLine("Nhập số phức B:");
            soPhucB.Nhap();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Tính tổng hai số phức");
                Console.WriteLine("2. Tính hiệu hai số phức");
                Console.WriteLine("3. Tính tích hai số phức");
                Console.WriteLine("4. Tính thương hai số phức");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        SoPhuc tong = soPhucA + soPhucB;
                        Console.WriteLine("Tổng hai số phức: ");
                        tong.HienThi();
                        break;
                    case "2":
                        SoPhuc hieu = soPhucA - soPhucB;
                        Console.WriteLine("Hiệu hai số phức: ");
                        hieu.HienThi();
                        break;
                    case "3":
                        SoPhuc tich = soPhucA * soPhucB;
                        Console.WriteLine("Tích hai số phức: ");
                        tich.HienThi();
                        break;
                    case "4":
                        SoPhuc thuong = soPhucA / soPhucB;
                        Console.WriteLine("Thương hai số phức: ");
                        thuong.HienThi();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}

//Bài 12

namespace bai_12
{
    class Program
    {
        static void Main()
        {
            // Nhập kích thước cho hai ma trận
            Console.Write("Nhập số dòng của ma trận A: ");
            int dongA = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập số cột của ma trận A: ");
            int cotA = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập số dòng của ma trận B: ");
            int dongB = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập số cột của ma trận B: ");
            int cotB = int.Parse(Console.ReadLine() ?? "0");

            // Kiểm tra nếu các ma trận có cùng kích thước
            if (dongA != dongB || cotA != cotB)
            {
                Console.WriteLine("Hai ma trận phải có cùng kích thước để thực hiện các phép toán.");
                return;
            }

            // Khởi tạo hai ma trận
            MaTran maTranA = new MaTran(dongA, cotA);
            MaTran maTranB = new MaTran(dongB, cotB);

            // Nhập dữ liệu cho hai ma trận
            Console.WriteLine("Nhập ma trận A:");
            maTranA.Nhap();
            Console.WriteLine("Nhập ma trận B:");
            maTranB.Nhap();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Tính tổng hai ma trận");
                Console.WriteLine("2. Tính hiệu hai ma trận");
                Console.WriteLine("3. Tính tích hai ma trận");
                Console.WriteLine("4. Tính thương hai ma trận (Không hỗ trợ)");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        try
                        {
                            MaTran tong = maTranA + maTranB;
                            Console.WriteLine("Tổng hai ma trận:");
                            tong.HienThi();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            MaTran hieu = maTranA - maTranB;
                            Console.WriteLine("Hiệu hai ma trận:");
                            hieu.HienThi();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        try
                        {
                            MaTran tich = maTranA * maTranB;
                            Console.WriteLine("Tích hai ma trận:");
                            tich.HienThi();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            MaTran thuong = maTranA / maTranB;
                            Console.WriteLine("Thương hai ma trận:");
                            thuong.HienThi();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}

//Bài 13



namespace bai_13
{
    class Program
    {
        static void Main(string[] args)
        {
            QLPTGT qlptgt = new QLPTGT();
            bool run = true;

            while (run)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhập đăng ký phương tiện");
                Console.WriteLine("2. Tìm phương tiện theo màu hoặc năm sản xuất");
                Console.WriteLine("3. Kết thúc chương trình");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        qlptgt.NhapPhuongTien();
                        break;
                    case "2":
                        qlptgt.TimPhuongTien();
                        break;
                    case "3":
                        qlptgt.KetThuc();
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}

//Bài 14



namespace bai_14
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo A = new PhanSo();
            PhanSo B = new PhanSo();

            // Nhập 2 phân số
            Console.WriteLine("Nhập phân số A:");
            A.NhapPhanSo();
            Console.WriteLine("Nhập phân số B:");
            B.NhapPhanSo();

            // Hiển thị 2 phân số
            Console.WriteLine("Phân số A: ");
            A.HienThiPhanSo();
            Console.WriteLine("Phân số B: ");
            B.HienThiPhanSo();

            // Thực hiện yêu cầu của người dùng
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine("\nChọn thao tác bạn muốn thực hiện:");
                Console.WriteLine("1. Cộng hai phân số");
                Console.WriteLine("2. Trừ hai phân số");
                Console.WriteLine("3. Chia hai phân số");
                Console.WriteLine("4. Kết thúc chương trình");
                Console.Write("Lựa chọn của bạn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PhanSo resultAdd = A.Cong(B);
                        Console.WriteLine("Kết quả cộng: ");
                        resultAdd.HienThiPhanSo();
                        break;
                    case 2:
                        PhanSo resultSub = A.Tru(B);
                        Console.WriteLine("Kết quả trừ: ");
                        resultSub.HienThiPhanSo();
                        break;
                    case 3:
                        PhanSo resultDiv = A.Chia(B);
                        if (resultDiv != null)
                        {
                            Console.WriteLine("Kết quả chia: ");
                            resultDiv.HienThiPhanSo();
                        }
                        break;
                    case 4:
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}
