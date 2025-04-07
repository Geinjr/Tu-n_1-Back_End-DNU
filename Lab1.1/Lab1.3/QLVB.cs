using System;

namespace bai_10
{
    public class VanBan
    {
        public string Text { get; set; }

        // Hàm tạo không có đối số
        public VanBan()
        {
            Text = string.Empty;
        }

        // Hàm tạo có đối số
        public VanBan(string st)
        {
            Text = st;
        }

        // Phương thức đếm số từ trong xâu
        public int DemSoTu()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return 0;

            string[] words = Text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Phương thức đếm số ký tự 'H' không phân biệt chữ hoa và chữ thường
        public int DemSoKyTuH()
        {
            int count = 0;
            foreach (char c in Text)
            {
                if (char.ToLower(c) == 'h')
                    count++;
            }
            return count;
        }

        // Phương thức chuẩn hóa xâu (xóa khoảng trắng thừa)
        public void ChuanHoa()
        {
            Text = Text.Trim(); // Xóa khoảng trắng ở đầu và cuối
            while (Text.Contains("  ")) // Đảm bảo không có khoảng trắng liền nhau
            {
                Text = Text.Replace("  ", " ");
            }
        }

        // Phương thức hiển thị xâu
        public void HienThi()
        {
            Console.WriteLine($"Xâu văn bản: '{Text}'");
        }
    }
}
