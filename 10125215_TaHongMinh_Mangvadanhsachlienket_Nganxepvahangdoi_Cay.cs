//PHAN 1; BAI TAP CHƯƠNG 4: MANG VA DANH SACH LIEN KET
//Bai1
//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.Write("Nhập số phần tử n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhập a[{i}]: ");
//            a[i] = int.Parse(Console.ReadLine());
//        }
//        Console.Write("Dãy số vừa nhập: ");
//        for (int i = 0; i < a.Length; i++)
//        {
//            Console.Write(a[i] + " ");
//        }
//        Console.WriteLine();
//        Console.Write("Nhập giá trị x cần chèn: ");
//        int x = int.Parse(Console.ReadLine());
//        Console.Write($"Nhập vị trí k cần chèn (0 -> {a.Length}): ");
//        int k = int.Parse(Console.ReadLine());
//        if (k >= 0 && k <= a.Length)
//        {
//            int[] tmp = new int[a.Length + 1];
//            for (int i = 0; i < k; i++)
//            {
//                tmp[i] = a[i];
//            }
//            tmp[k] = x;
//            for (int i = k; i < a.Length; i++)
//            {
//                tmp[i + 1] = a[i];
//            }
//            a = tmp;

//            Console.Write("Dãy số sau khi chèn: ");
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.Write(a[i] + " ");
//            }
//            Console.WriteLine();
//        }
//        else
//        {
//            Console.WriteLine("Vị trí chèn k không hợp lệ!");
//        }
//    }
//}


//Bai2
//using System;
//using System.Text;
//struct NhanVien
//{
//    public string MaNV;
//    public string Hoten;
//    public int Namsinh;
//    public string Phongban;
//    public int LuongCB;
//    public int Thuong;
//}
//class Program
//{
//    static NhanVien[] DS;
//    static int ThucLinh(int x)
//    {
//        return DS[x].LuongCB + DS[x].Thuong;
//    }
//    static void HienThiNhanVien(NhanVien nv)
//    {
//        int tl = nv.LuongCB + nv.Thuong;
//        Console.WriteLine($"Mã NV: {nv.MaNV} | Họ tên: {nv.Hoten} | Năm sinh: {nv.Namsinh} | Phòng: {nv.Phongban} | Lương CB: {nv.LuongCB} | Thưởng: {nv.Thuong} | Thực lĩnh: {tl}");
//    }
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.Write("Nhập số lượng nhân viên: ");
//        int n = int.Parse(Console.ReadLine());
//        DS = new NhanVien[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i + 1} ---");
//            Console.Write("Mã nhân viên: "); DS[i].MaNV = Console.ReadLine();
//            Console.Write("Họ và tên: "); DS[i].Hoten = Console.ReadLine();
//            Console.Write("Năm sinh: "); DS[i].Namsinh = int.Parse(Console.ReadLine());
//            Console.Write("Phòng ban: "); DS[i].Phongban = Console.ReadLine();
//            Console.Write("Lương cơ bản: "); DS[i].LuongCB = int.Parse(Console.ReadLine());
//            Console.Write("Thưởng: "); DS[i].Thuong = int.Parse(Console.ReadLine());
//        }
//        long tongThucLinh = 0;
//        for (int i = 0; i < DS.Length; i++)
//        {
//            tongThucLinh += ThucLinh(i);
//        }
//        Console.WriteLine($"\na. Tổng thực lĩnh của tất cả nhân viên: {tongThucLinh}");
//        int minLuongCB = int.MaxValue;
//        for (int i = 0; i < DS.Length; i++)
//        {
//            if (DS[i].LuongCB < minLuongCB)
//                minLuongCB = DS[i].LuongCB;
//        }
//        Console.WriteLine("\nb. Danh sách nhân viên có mức lương cơ bản thấp nhất:");
//        for (int i = 0; i < DS.Length; i++)
//        {
//            if (DS[i].LuongCB == minLuongCB)
//                HienThiNhanVien(DS[i]);
//        }
//        int demThuong = 0;
//        for (int i = 0; i < DS.Length; i++)
//        {
//            if (DS[i].Thuong >= 1200000)
//                demThuong++;
//        }
//        Console.WriteLine($"\nc. Số lượng nhân viên có mức thưởng >= 1.200.000: {demThuong}");
//        for (int i = 0; i < DS.Length - 1; i++)
//        {
//            for (int j = i + 1; j < DS.Length; j++)
//            {
//                int cmpPhong = string.Compare(DS[i].Phongban, DS[j].Phongban);
//                if (cmpPhong > 0 || (cmpPhong == 0 && string.Compare(DS[i].MaNV, DS[j].MaNV) < 0))
//                {
//                    NhanVien temp = DS[i];
//                    DS[i] = DS[j];
//                    DS[j] = temp;
//                }
//            }
//        }
//        Console.WriteLine("\nd. Danh sách nhân viên sau khi sắp xếp:");
//        for (int i = 0; i < DS.Length; i++)
//        {
//            HienThiNhanVien(DS[i]);
//        }
//        Console.WriteLine("\ne. Danh sách nhân viên sau khi tăng lương cơ bản 5%:");
//        for (int i = 0; i < DS.Length; i++)
//        {
//            DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
//            HienThiNhanVien(DS[i]);
//        }
//    }
//}

//Bai3
//using System;
//using System.Text;
//class Program
//{
//    static int TongMaTran(int[,] a, int n)
//    {
//        int t = 0;
//        for (int i = 0; i < n; i++)
//            for (int j = 0; j < n; j++)
//                t += a[i, j];
//        return t;
//    }
//    static int DuongNhoNhat(int[,] a, int n)
//    {
//        int min = int.MaxValue;
//        for (int i = 0; i < n; i++)
//            for (int j = 0; j < n; j++)
//                if (a[i, j] > 0 && a[i, j] < min)
//                    min = a[i, j];
//        return (min == int.MaxValue) ? -1 : min;
//    }
//    static int TongCheoPhu(int[,] a, int n)
//    {
//        int t = 0;
//        for (int i = 0; i < n; i++)
//            t += a[i, n - 1 - i];
//        return t;
//    }
//    static bool KiemTraCheoChinhTangDan(int[,] a, int n)
//    {
//        int[] tg = new int[n];
//        for (int i = 0; i < n; i++)
//            tg[i] = a[i, i];

//        for (int i = 0; i <= n - 2; i++)
//        {
//            for (int j = i + 1; j <= n - 1; j++)
//            {
//                if (tg[i] >= tg[j])
//                    return false;
//            }
//        }
//        return true;
//    }
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.Write("Nhập cấp n của ma trận vuông (0 < n < 100): ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] a = new int[n, n];
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"a[{i},{j}] = ");
//                a[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine($"a. Tổng các phần tử của ma trận: {TongMaTran(a, n)}");
//        int minDuong = DuongNhoNhat(a, n);
//        if (minDuong != -1)
//            Console.WriteLine($"b. Giá trị dương nhỏ nhất: {minDuong}");
//        else
//            Console.WriteLine("b. Ma trận không có phần tử dương.");
//        Console.WriteLine($"c. Tổng các phần tử trên đường chéo phụ: {TongCheoPhu(a, n)}");
//        Console.WriteLine($"d. Đường chéo chính tăng dần: {KiemTraCheoChinhTangDan(a, n)}");
//    }
//}

//Bai4
//using System;
//using System.Text;
//public class Node
//{
//    public int Data;
//    public Node Next;
//    public Node(int data)
//    {
//        Data = data;
//        Next = null;
//    }
//}
//class Program
//{
//    static Node pHead = null;
//    static void ThemCuoi(int value)
//    {
//        Node newNode = new Node(value);
//        if (pHead == null)
//        {
//            pHead = newNode;
//            return;
//        }
//        Node p = pHead;
//        while (p.Next != null)
//            p = p.Next;
//        p.Next = newNode;
//    }
//    static void HienThi()
//    {
//        Node p = pHead;
//        while (p != null)
//        {
//            Console.Write(p.Data + " -> ");
//            p = p.Next;
//        }
//        Console.WriteLine("null");
//    }
//    static int DemBangX(int x)
//    {
//        int d = 0;
//        Node p = pHead;
//        while (p != null)
//        {
//            if (p.Data == x)
//                d++;
//            p = p.Next;
//        }
//        return d;
//    }
//    static int TimDuongNhoNhat()
//    {
//        int minduong = int.MaxValue;
//        Node p = pHead;
//        while (p != null)
//        {
//            if (p.Data > 0 && p.Data < minduong)
//                minduong = p.Data;
//            p = p.Next;
//        }
//        return (minduong == int.MaxValue) ? -1 : minduong;
//    }
//    static void XoaXDauTien(int x)
//    {
//        if (pHead == null) return;
//        if (pHead.Data == x)
//        {
//            pHead = pHead.Next;
//            return;
//        }
//        Node t = pHead;
//        Node p = pHead.Next;
//        while (p != null && p.Data != x)
//        {
//            t = p;
//            p = p.Next;
//        }
//        if (p != null)
//        {
//            t.Next = p.Next;
//        }
//    }
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.Write("Nhập số lượng phần tử: ");
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhập phần tử thứ {i + 1}: ");
//            ThemCuoi(int.Parse(Console.ReadLine()));
//        }
//        Console.Write("Danh sách đã nhập: ");
//        HienThi();
//        Console.Write("Nhập giá trị x cần đếm và xóa: ");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"a. Số lượng phần tử bằng {x}: {DemBangX(x)}");
//        Console.WriteLine($"b. Phần tử dương nhỏ nhất: {TimDuongNhoNhat()}");
//        XoaXDauTien(x);
//        Console.Write($"c. Danh sách sau khi xóa phần tử {x} đầu tiên: ");
//        HienThi();
//    }
//}


//Bai5
//using System;
//using System.Text;
//public class Node
//{
//    public int Data;
//    public Node Next;

//    public Node(int data)
//    {
//        Data = data;
//        Next = null;
//    }
//}
//class Program
//{
//    static Node l = null;
//    static void ThemCuoi(int value)
//    {
//        Node newNode = new Node(value);
//        if (l == null)
//        {
//            l = newNode;
//            return;
//        }
//        Node p = l;
//        while (p.Next != null)
//            p = p.Next;
//        p.Next = newNode;
//    }
//    static int TimMax()
//    {
//        int max = int.MinValue;
//        Node p = l;
//        while (p != null)
//        {
//            if (p.Data > max)
//                max = p.Data;
//            p = p.Next;
//        }
//        return max;
//    }
//    static int TinhTong()
//    {
//        int t = 0;
//        Node p = l;
//        while (p != null)
//        {
//            t += p.Data;
//            p = p.Next;
//        }
//        return t;
//    }
//    static bool KTNT(int x)
//    {
//        if (x < 2) return false;
//        for (int i = 2; i <= Math.Sqrt(x); i++)
//        {
//            if (x % i == 0) return false;
//        }
//        return true;
//    }
//    static int DemSoNguyenTo()
//    {
//        int dem = 0;
//        Node p = l;
//        while (p != null)
//        {
//            if (KTNT(p.Data))
//                dem++;
//            p = p.Next;
//        }
//        return dem;
//    }
//    static void DemAmDuongKhong()
//    {
//        int demAm = 0, demDuong = 0, demKhong = 0;
//        Node p = l;
//        while (p != null)
//        {
//            if (p.Data < 0) demAm++;
//            else if (p.Data > 0) demDuong++;
//            else demKhong++;
//            p = p.Next;
//        }
//        Console.WriteLine($"d. Số âm: {demAm} | Số bằng 0: {demKhong} | Số dương: {demDuong}");
//    }
//    static int DemBangX(int x)
//    {
//        int dem = 0;
//        Node p = l;
//        while (p != null)
//        {
//            if (p.Data == x)
//                dem++;
//            p = p.Next;
//        }
//        return dem;
//    }
//    static int TimDuongNhoNhat()
//    {
//        int minduong = int.MaxValue;
//        Node p = l;
//        while (p != null)
//        {
//            if (p.Data > 0 && p.Data < minduong)
//                minduong = p.Data;
//            p = p.Next;
//        }
//        return (minduong == int.MaxValue) ? -1 : minduong;
//    }
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.Write("Nhập số lượng phần tử của danh sách l: ");
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhập phần tử thứ {i + 1}: ");
//            ThemCuoi(int.Parse(Console.ReadLine()));
//        }
//        Console.WriteLine($"a. Phần tử lớn nhất: {TimMax()}");
//        Console.WriteLine($"b. Tổng các phần tử: {TinhTong()}");
//        Console.WriteLine($"c. Số lượng số nguyên tố: {DemSoNguyenTo()}");
//        DemAmDuongKhong();
//        Console.Write("Nhập giá trị x cần đếm: ");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"e. Số lượng phần tử bằng {x}: {DemBangX(x)}");
//        int minDuong = TimDuongNhoNhat();
//        if (minDuong != -1)
//            Console.WriteLine($"f. Phần tử dương nhỏ nhất: {minDuong}");
//        else
//            Console.WriteLine("f. Danh sách không có số dương.");
//    }
//}


//PHẦN 2: BAI TAP CHƯƠNG 5: NGAN XEP VA HANG DOI

//Bai1
//using System;
//using System.Collections.Generic;
//using System.Text;
//class Program
//{
//    static bool LaNgoacMo(char c)
//    {
//        return c == '(' || c == '[' || c == '{';
//    }
//    static bool LaNgoacDong(char c)
//    {
//        return c == ')' || c == ']' || c == '}';
//    }
//    static bool KhopCapNgoac(char mo, char dong)
//    {
//        return (mo == '(' && dong == ')') ||
//               (mo == '[' && dong == ']') ||
//               (mo == '{' && dong == '}');
//    }
//    static bool KiemTraBieuThuc(string bieuThuc)
//    {
//        Stack<char> stack = new Stack<char>();
//        foreach (char c in bieuThuc)
//        {
//            if (LaNgoacMo(c))
//            {
//                stack.Push(c);
//            }
//            else if (LaNgoacDong(c))
//            {
//                if (stack.Count == 0)
//                    return false;
//                char dinh = stack.Pop();
//                if (!KhopCapNgoac(dinh, c))
//                    return false;
//            }
//        }
//        return stack.Count == 0;
//    }
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.Write("Nhập biểu thức toán học: ");
//        string input = Console.ReadLine();
//        if (KiemTraBieuThuc(input))
//            Console.WriteLine("Biểu thức hợp lệ.");
//        else
//            Console.WriteLine("Biểu thức không hợp lệ.");
//    }
//}

//Bai2
//using System;
//using System.Collections.Generic;
//using System.Text;

//class Program
//{
//    static Stack<string> backStack = new Stack<string>();
//    static Stack<string> forwardStack = new Stack<string>();
//    static string trangHienTai = null;

//    static void TruyCapTrangMoi(string url)
//    {
//        if (trangHienTai != null)
//        {
//            backStack.Push(trangHienTai);
//        }
//        trangHienTai = url;
//        forwardStack.Clear();
//        Console.WriteLine($"Đã truy cập: {trangHienTai}");
//    }

//    static void QuayLaiBack()
//    {
//        if (backStack.Count == 0)
//        {
//            Console.WriteLine("Không có trang nào để quay lại (Back rỗng).");
//            return;
//        }
//        forwardStack.Push(trangHienTai);
//        trangHienTai = backStack.Pop();
//        Console.WriteLine($"Đã quay lại (Back) -> Đang xem: {trangHienTai}");
//    }

//    static void ChuyenTiepForward()
//    {
//        if (forwardStack.Count == 0)
//        {
//            Console.WriteLine("Không có trang nào để chuyển tiếp (Forward rỗng).");
//            return;
//        }
//        backStack.Push(trangHienTai);
//        trangHienTai = forwardStack.Pop();
//        Console.WriteLine($"Đã chuyển tiếp (Forward) -> Đang xem: {trangHienTai}");
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        while (true)
//        {
//            Console.WriteLine($"\nTrang hiện tại: {(trangHienTai ?? "(Chưa mở trang)")}");
//            Console.WriteLine("1. Truy cập trang mới (Visit)");
//            Console.WriteLine("2. Quay lại (Back)");
//            Console.WriteLine("3. Chuyển tiếp (Forward)");
//            Console.WriteLine("0. Thoát");
//            Console.Write("Chọn chức năng: ");

//            string chon = Console.ReadLine();
//            switch (chon)
//            {
//                case "1":
//                    Console.Write("Nhập địa chỉ trang (URL): ");
//                    string url = Console.ReadLine();
//                    TruyCapTrangMoi(url);
//                    break;
//                case "2":
//                    QuayLaiBack();
//                    break;
//                case "3":
//                    ChuyenTiepForward();
//                    break;
//                case "0":
//                    return;
//                default:
//                    Console.WriteLine("Lựa chọn không hợp lệ!");
//                    break;
//            }
//        }
//    }
//}

//Bai3
//using System;
//using System.Collections.Generic;
//using System.Text;

//class StackFrame
//{
//    public string TenHam { get; set; }
//    public string ThamSo { get; set; }
//    public string DiaChiTraVe { get; set; }

//    public StackFrame(string tenHam, string thamSo, string diaChiTraVe)
//    {
//        TenHam = tenHam;
//        ThamSo = thamSo;
//        DiaChiTraVe = diaChiTraVe;
//    }

//    public override string ToString()
//    {
//        return $"[{TenHam}({ThamSo}) | Trả về: {DiaChiTraVe}]";
//    }
//}

//class Program
//{
//    static Stack<StackFrame> callStack = new Stack<StackFrame>();

//    static void GoiHam(string tenHam, string thamSo, string diaChiTraVe)
//    {
//        StackFrame frame = new StackFrame(tenHam, thamSo, diaChiTraVe);
//        callStack.Push(frame);
//        Console.WriteLine($"-> Đã gọi hàm: {frame}");
//        InCallStack();
//    }

//    static void TraVeTuHam()
//    {
//        if (callStack.Count == 0)
//        {
//            Console.WriteLine("Call Stack đang rỗng, không có hàm nào để trả về.");
//            return;
//        }
//        StackFrame frame = callStack.Pop();
//        Console.WriteLine($"<- Hàm kết thúc và trả về: {frame.TenHam} (quay về {frame.DiaChiTraVe})");
//        InCallStack();
//    }

//    static void InCallStack()
//    {
//        Console.WriteLine("Trạng thái Call Stack hiện tại (từ đỉnh xuống đáy):");
//        if (callStack.Count == 0)
//        {
//            Console.WriteLine("  (Trống)");
//            return;
//        }
//        foreach (var item in callStack)
//        {
//            Console.WriteLine("  " + item);
//        }
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        // Khởi tạo hàm Main ban đầu
//        GoiHam("Main", "args", "OS_Exit");

//        while (true)
//        {
//            Console.WriteLine("\n1. Gọi hàm mới (Call Function)");
//            Console.WriteLine("2. Kết thúc & trả về từ hàm hiện tại (Return)");
//            Console.WriteLine("3. Xem Call Stack");
//            Console.WriteLine("0. Thoát");
//            Console.Write("Chọn chức năng: ");

//            string chon = Console.ReadLine();
//            switch (chon)
//            {
//                case "1":
//                    Console.Write("Tên hàm: ");
//                    string ten = Console.ReadLine();
//                    Console.Write("Tham số truyền vào: ");
//                    string ts = Console.ReadLine();
//                    Console.Write("Địa chỉ/dòng lệnh trả về: ");
//                    string ret = Console.ReadLine();
//                    GoiHam(ten, ts, ret);
//                    break;
//                case "2":
//                    TraVeTuHam();
//                    break;
//                case "3":
//                    InCallStack();
//                    break;
//                case "0":
//                    return;
//                default:
//                    Console.WriteLine("Lựa chọn không hợp lệ!");
//                    break;
//            }
//        }
//    }
//}

//Bai4
//using System;
//using System.Collections.Generic;
//using System.Text;

//class YeuCauIn
//{
//    public int MaYeuCau { get; set; }
//    public string TenTaiLieu { get; set; }
//    public int SoTrang { get; set; }

//    public override string ToString()
//    {
//        return $"[#{MaYeuCau} - {TenTaiLieu} ({SoTrang} trang)]";
//    }
//}

//class Program
//{
//    static Queue<YeuCauIn> hangDoiIn = new Queue<YeuCauIn>();
//    static int boDemMa = 1;

//    static void ThemYeuCauIn(string tenTaiLieu, int soTrang)
//    {
//        YeuCauIn yc = new YeuCauIn
//        {
//            MaYeuCau = boDemMa++,
//            TenTaiLieu = tenTaiLieu,
//            SoTrang = soTrang
//        };
//        hangDoiIn.Enqueue(yc);
//        Console.WriteLine($"Đã thêm vào hàng đợi in (Enqueue): {yc}");
//    }

//    static void XuLyYeuCauIn()
//    {
//        if (hangDoiIn.Count == 0)
//        {
//            Console.WriteLine("Hàng đợi in đang trống.");
//            return;
//        }
//        YeuCauIn yc = hangDoiIn.Dequeue();
//        Console.WriteLine($"Đang in và hoàn tất (Dequeue): {yc}");
//    }

//    static void HienThiHangDoi()
//    {
//        Console.WriteLine($"Số yêu cầu đang chờ in: {hangDoiIn.Count}");
//        if (hangDoiIn.Count == 0)
//        {
//            Console.WriteLine("  (Trống)");
//            return;
//        }
//        foreach (var yc in hangDoiIn)
//        {
//            Console.WriteLine("  " + yc);
//        }
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        while (true)
//        {
//            Console.WriteLine("\n=== HỆ THỐNG IN ẤN (QUEUE - FIFO) ===");
//            Console.WriteLine("1. Gửi yêu cầu in mới (Enqueue)");
//            Console.WriteLine("2. Xử lý yêu cầu in tiếp theo (Dequeue)");
//            Console.WriteLine("3. Xem danh sách chờ in");
//            Console.WriteLine("0. Thoát");
//            Console.Write("Chọn chức năng: ");

//            string chon = Console.ReadLine();
//            switch (chon)
//            {
//                case "1":
//                    Console.Write("Nhập tên tài liệu: ");
//                    string ten = Console.ReadLine();
//                    Console.Write("Nhập số trang: ");
//                    int trang = int.Parse(Console.ReadLine());
//                    ThemYeuCauIn(ten, trang);
//                    break;
//                case "2":
//                    XuLyYeuCauIn();
//                    break;
//                case "3":
//                    HienThiHangDoi();
//                    break;
//                case "0":
//                    return;
//                default:
//                    Console.WriteLine("Lựa chọn không hợp lệ!");
//                    break;
//            }
//        }
//    }
//}

//Bai5
//using System;
//using System.Collections.Generic;
//using System.Text;

//class GoiTin
//{
//    public int SoThuTu { get; set; }
//    public string NoiDung { get; set; }
//    public int DoTreMs { get; set; }
//    public bool BiLoi { get; set; }

//    public override string ToString()
//    {
//        string trangThai = BiLoi ? "LỖI ĐƯỜNG TRUYỀN" : "HỢP LỆ";
//        return $"[Gói #{SoThuTu} | Nội dung: '{NoiDung}' | Trễ: {DoTreMs}ms | {trangThai}]";
//    }
//}

//class Program
//{
//    static Queue<GoiTin> duongTruyen = new Queue<GoiTin>();
//    static Random rand = new Random();
//    static int stt = 1;

//    static void GuiGoiTin(string noiDung)
//    {
//        int doTre = rand.Next(10, 151);
//        bool loi = rand.Next(1, 101) <= 15;

//        GoiTin goi = new GoiTin
//        {
//            SoThuTu = stt++,
//            NoiDung = noiDung,
//            DoTreMs = doTre,
//            BiLoi = loi
//        };

//        duongTruyen.Enqueue(goi);
//        Console.WriteLine($"Đã gửi gói tin vào hàng đợi: {goi}");
//    }

//    static void NhanVaXuLyGoiTin()
//    {
//        if (duongTruyen.Count == 0)
//        {
//            Console.WriteLine("Không có gói tin nào trong hàng đợi.");
//            return;
//        }

//        GoiTin goi = duongTruyen.Dequeue();
//        if (goi.BiLoi)
//        {
//            Console.WriteLine($"[CẢNH BÁO] Nhận gói {goi} -> Bị lỗi, cần yêu cầu gửi lại!");
//        }
//        else
//        {
//            Console.WriteLine($"[THÀNH CÔNG] Đã xử lý gói {goi}");
//        }
//    }

//    static void XemCacGoiCho()
//    {
//        Console.WriteLine($"Số gói tin đang chờ xử lý: {duongTruyen.Count}");
//        foreach (var goi in duongTruyen)
//        {
//            Console.WriteLine("  " + goi);
//        }
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        while (true)
//        {
//            Console.WriteLine("\n=== MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU (QUEUE) ===");
//            Console.WriteLine("1. Gửi gói tin mới (Enqueue)");
//            Console.WriteLine("2. Nhận & xử lý gói tin đầu tiên (Dequeue)");
//            Console.WriteLine("3. Xem các gói tin đang chờ");
//            Console.WriteLine("0. Thoát");
//            Console.Write("Chọn chức năng: ");

//            string chon = Console.ReadLine();
//            switch (chon)
//            {
//                case "1":
//                    Console.Write("Nhập nội dung gói tin: ");
//                    string nd = Console.ReadLine();
//                    GuiGoiTin(nd);
//                    break;
//                case "2":
//                    NhanVaXuLyGoiTin();
//                    break;
//                case "3":
//                    XemCacGoiCho();
//                    break;
//                case "0":
//                    return;
//                default:
//                    Console.WriteLine("Lựa chọn không hợp lệ!");
//                    break;
//            }
//        }
//    }
//}

//Bai6
//using System;
//using System.Collections.Generic;
//using System.Text;

//class KhachHang
//{
//    public int SoThuTu { get; set; }
//    public string HoTen { get; set; }
//    public string LoaiDichVu { get; set; }
//    public DateTime ThoiGianDen { get; set; }

//    public override string ToString()
//    {
//        return $"[STT {SoThuTu:D3} | {HoTen} | Dịch vụ: {LoaiDichVu} | Đến lúc: {ThoiGianDen:HH:mm:ss}]";
//    }
//}

//class Program
//{
//    static Queue<KhachHang> hangDoiKhach = new Queue<KhachHang>();
//    static int soThuTuTiepTheo = 1;

//    static void KhachDen(string hoTen, string loaiDichVu)
//    {
//        KhachHang kh = new KhachHang
//        {
//            SoThuTu = soThuTuTiepTheo++,
//            HoTen = hoTen,
//            LoaiDichVu = loaiDichVu,
//            ThoiGianDen = DateTime.Now
//        };
//        hangDoiKhach.Enqueue(kh);
//        Console.WriteLine($"Khách hàng mới xếp hàng (Enqueue): {kh}");
//    }

//    static void PhucVuKhachTiepTheo()
//    {
//        if (hangDoiKhach.Count == 0)
//        {
//            Console.WriteLine("Hiện không có khách hàng nào đang chờ.");
//            return;
//        }
//        KhachHang kh = hangDoiKhach.Dequeue();
//        TimeSpan thoiGianCho = DateTime.Now - kh.ThoiGianDen;
//        Console.WriteLine($"Đang phục vụ (Dequeue): {kh} | Thời gian chờ: {thoiGianCho.TotalSeconds:F1}s");
//    }

//    static void HienThiTrangThai()
//    {
//        Console.WriteLine($"--- TRẠNG THÁI HÀNG ĐỢI (Đang chờ: {hangDoiKhach.Count} khách) ---");
//        if (hangDoiKhach.Count == 0)
//        {
//            Console.WriteLine("  Hàng đợi trống.");
//            return;
//        }
//        int viTri = 1;
//        foreach (var kh in hangDoiKhach)
//        {
//            Console.WriteLine($"  Vị trí {viTri++}: {kh}");
//        }
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        while (true)
//        {
//            Console.WriteLine("\n=== QUẢN LÝ HÀNG ĐỢI KHÁCH HÀNG (QUEUE - FIFO) ===");
//            Console.WriteLine("1. Khách hàng đến lấy số (Enqueue)");
//            Console.WriteLine("2. Nhân viên rảnh - gọi khách tiếp theo (Dequeue)");
//            Console.WriteLine("3. Hiển thị trạng thái hàng đợi");
//            Console.WriteLine("0. Thoát");
//            Console.Write("Chọn chức năng: ");

//            string chon = Console.ReadLine();
//            switch (chon)
//            {
//                case "1":
//                    Console.Write("Nhập họ tên khách hàng: ");
//                    string ten = Console.ReadLine();
//                    Console.Write("Nhập loại dịch vụ (VD: Rút tiền, Mở tài khoản, Tư vấn): ");
//                    string dv = Console.ReadLine();
//                    KhachDen(ten, dv);
//                    break;
//                case "2":
//                    PhucVuKhachTiepTheo();
//                    break;
//                case "3":
//                    HienThiTrangThai();
//                    break;
//                case "0":
//                    return;
//                default:
//                    Console.WriteLine("Lựa chọn không hợp lệ!");
//                    break;
//            }
//        }
//    }
//}


//PHAN 6: BAI TAP CHUOG 6: CAY

//Bai1
//using System;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static int DemSoNut(Node root)
//    {
//        if (root == null) return 0;
//        return 1 + DemSoNut(root.Left) + DemSoNut(root.Right);
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(10);
//        root.Left = new Node(5);
//        root.Right = new Node(15);
//        root.Left.Left = new Node(2);
//        root.Left.Right = new Node(8);

//        Console.WriteLine("Tổng số nút trên cây nhị phân: " + DemSoNut(root));
//    }
//}

//Bai2
//using System;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static int TinhTongCacNut(Node root)
//    {
//        if (root == null) return 0;
//        return root.Data + TinhTongCacNut(root.Left) + TinhTongCacNut(root.Right);
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(10);
//        root.Left = new Node(5);
//        root.Right = new Node(15);
//        root.Left.Left = new Node(2);
//        root.Left.Right = new Node(8);

//        Console.WriteLine("Tổng giá trị các nút trên cây: " + TinhTongCacNut(root));
//    }
//}

//Bai3
//using System;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static void HienThiCacNut(Node root)
//    {
//        if (root == null) return;
//        HienThiCacNut(root.Left);
//        Console.Write(root.Data + " ");
//        HienThiCacNut(root.Right);
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(10);
//        root.Left = new Node(5);
//        root.Right = new Node(15);
//        root.Left.Left = new Node(2);
//        root.Left.Right = new Node(8);

//        Console.Write("Các giá trị trên cây nhị phân: ");
//        HienThiCacNut(root);
//        Console.WriteLine();
//    }
//}

//Bai4
//using System;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static void HienThiNutChan(Node root)
//    {
//        if (root == null) return;
//        HienThiNutChan(root.Left);
//        if (root.Data % 2 == 0)
//        {
//            Console.Write(root.Data + " ");
//        }
//        HienThiNutChan(root.Right);
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(10);
//        root.Left = new Node(5);
//        root.Right = new Node(14);
//        root.Left.Left = new Node(2);
//        root.Left.Right = new Node(7);

//        Console.Write("Các nút có giá trị chẵn trên cây: ");
//        HienThiNutChan(root);
//        Console.WriteLine();
//    }
//}

//Bai5
//using System;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static int DemNutChan(Node root)
//    {
//        if (root == null) return 0;
//        int dem = (root.Data % 2 == 0) ? 1 : 0;
//        return dem + DemNutChan(root.Left) + DemNutChan(root.Right);
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(10);
//        root.Left = new Node(5);
//        root.Right = new Node(14);
//        root.Left.Left = new Node(2);
//        root.Left.Right = new Node(7);

//        Console.WriteLine("Số lượng nút có giá trị chẵn: " + DemNutChan(root));
//    }
//}

//Bai6
//using System;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static int DemSoConTrucTiep(Node node)
//    {
//        if (node == null) return 0;
//        int soCon = 0;
//        if (node.Left != null) soCon++;
//        if (node.Right != null) soCon++;
//        return soCon;
//    }
//    static int DemTongConChau(Node node)
//    {
//        if (node == null) return 0;
//        int dem = 0;
//        if (node.Left != null) dem += 1 + DemTongConChau(node.Left);
//        if (node.Right != null) dem += 1 + DemTongConChau(node.Right);
//        return dem;
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(10);
//        root.Left = new Node(5);
//        root.Right = new Node(15);
//        root.Left.Left = new Node(2);

//        Console.WriteLine($"Số con trực tiếp của nút {root.Data}: {DemSoConTrucTiep(root)}");
//        Console.WriteLine($"Số con trực tiếp của nút {root.Left.Data}: {DemSoConTrucTiep(root.Left)}");
//        Console.WriteLine($"Tổng số con cháu của nút {root.Data}: {DemTongConChau(root)}");
//    }
//}

//Bai7
//using System;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static void DuyetCay(Node node)
//    {
//        if (node == null) return;
//        Console.Write(node.Data + " ");
//        DuyetCay(node.Left);
//        DuyetCay(node.Right);
//    }

//    static void HienThiCayConTrai(Node root)
//    {
//        if (root == null || root.Left == null)
//        {
//            Console.WriteLine("Cây con trái rỗng.");
//            return;
//        }
//        Console.Write("Các nút trên cây con trái: ");
//        DuyetCay(root.Left);
//        Console.WriteLine();
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(10);
//        root.Left = new Node(5);
//        root.Right = new Node(15);
//        root.Left.Left = new Node(2);
//        root.Left.Right = new Node(8);

//        HienThiCayConTrai(root);
//    }
//}

//Bai8
//using System;
//using System.Collections.Generic;
//using System.Text;

//class Node
//{
//    public int Data;
//    public Node Left, Right;
//    public Node(int data) { Data = data; Left = Right = null; }
//}

//class Program
//{
//    static void DuyetTruoc(Node root)
//    {
//        if (root == null) return;
//        Console.Write(root.Data + " ");
//        DuyetTruoc(root.Left);
//        DuyetTruoc(root.Right);
//    }
//    static void DuyetGiua(Node root)
//    {
//        if (root == null) return;
//        DuyetGiua(root.Left);
//        Console.Write(root.Data + " ");
//        DuyetGiua(root.Right);
//    }
//    static void DuyetSau(Node root)
//    {
//        if (root == null) return;
//        DuyetSau(root.Left);
//        DuyetSau(root.Right);
//        Console.Write(root.Data + " ");
//    }
//    static void DuyetTheoMuc(Node root)
//    {
//        if (root == null) return;
//        Queue<Node> queue = new Queue<Node>();
//        queue.Enqueue(root);

//        while (queue.Count > 0)
//        {
//            Node current = queue.Dequeue();
//            Console.Write(current.Data + " ");

//            if (current.Left != null) queue.Enqueue(current.Left);
//            if (current.Right != null) queue.Enqueue(current.Right);
//        }
//    }

//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        Node root = new Node(1);
//        root.Left = new Node(2);
//        root.Right = new Node(3);
//        root.Left.Left = new Node(4);
//        root.Left.Right = new Node(5);
//        root.Right.Right = new Node(6);

//        Console.Write("Duyệt trước (Pre-order): ");
//        DuyetTruoc(root);
//        Console.WriteLine();

//        Console.Write("Duyệt giữa (In-order):   ");
//        DuyetGiua(root);
//        Console.WriteLine();

//        Console.Write("Duyệt sau (Post-order):  ");
//        DuyetSau(root);
//        Console.WriteLine();

//        Console.Write("Duyệt theo mức (Queue):  ");
//        DuyetTheoMuc(root);
//        Console.WriteLine();
//    }
//}