using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_4
{
    public partial class Form2 : Form
    {
        /*
            * Quy định MSSV từ 0000 đến 9999
            * SDT theo định dạng VN
            * Họ và tên viết cách nhau 1 dấu khoảng trắng
            * Điểm theo dạng float với 1 chữ số thập phân
            */

        private int result;
        private int i = 1;

        // gán số lượng sinh viên cần nhập
        public Form2(int result)
        {
            InitializeComponent();
            this.result = result;
        }

        // ktra số lượng sinh viên đã nhập đủ số lượng hay chưa
        private bool checkStuCount()
        {
            if (i <= result)
                return true;
            else return false;
        }

        // tạo class sinhVien để lưu thông tin sinh viên
        [Serializable]
        public class sinhVien
        {
            public string? mssv { get; set; }
            public string? hoVaTen { get; set; }
            public string? sdt { get; set; }
            public string? dToan { get; set; }
            public string? dVan { get; set; }
        }

        // tạo class để lưu thông tin các sinh viên
        [Serializable]
        public class ds_sinhvien
        {
            // list thông tin sinh viên
            public List<sinhVien> listSinhVien { get; set; }

            // khởi tạo list sinh viên theo mặc định
            public ds_sinhvien()
            {
                listSinhVien = new List<sinhVien>();
            }

            // thêm sinh viên mới vào list
            public void add_sinhvien(sinhVien tt_sinhvien)
            {
                listSinhVien.Add(tt_sinhvien);
            }

            // lưu vào file
            public void SaveToFile(string fileName)
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, this);
                }
            }
        }

        public static ds_sinhvien list_sinhvien = new ds_sinhvien();

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // ktra nếu tất cả textbox đã có dữ liệu
        private bool AreAllTextboxesFilled()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
                return false;
            else
                return true;

        }

        // ktra điều kiện tất cả các textbox
        private void textbox_condition()
        {
            
            if (!AreAllTextboxesFilled())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            if (!int.TryParse(textBox1.Text, out int mssv) || mssv < 0 || mssv > 9999)
            {
                MessageBox.Show("Vui lòng nhập giá trị thích hợp.");
                textBox1.Text = "";
                return;
            }
            // bỏ khoảng trắng thừa
            string input = textBox2.Text.Trim();

            // ktra chuỗi nhập vào có số hay kí tự đặc biệt hay ko
            if (input.Any(c => char.IsDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c)))
            {
                MessageBox.Show("Vui lòng nhập tên hợp lệ");
                textBox2.Text = "";
                return;
            }

            // ktra chuỗi nhập vào có là " " ko
            if (!input.Contains(" "))
            {
                MessageBox.Show("Vui lòng nhập tên hợp lệ");
                textBox2.Text = "";
                return;
            }

            // kiểm tra mỗi từ có cách nhau bằng " " hay ko
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                if (word.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên hợp lệ");
                    textBox2.Text = "";
                    return;
                }
            }

            // sử dụng 'long' do sđt nằm ngoài khoảng của 'int'
            if (!long.TryParse(textBox3.Text, out long sdt) || sdt < 1 || sdt > 999999999)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại thích hợp.");
                textBox3.Text = "";
                return;
            }

            // the CultureInfo.InvariantCulture parameter is used to specify that the decimal point should always be interpreted
            // as a decimal separator, regardless of the user's culture settings.
            if (!float.TryParse(textBox4.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float dToan) || dToan < 0.0 || dToan > 10.0)
            {
                MessageBox.Show("Vui lòng nhập điểm Toán thích hợp.");
                textBox4.Text = "";
                return;
            }
            else if (textBox4.Text.Contains(".") && textBox4.Text.Split('.')[1].Length > 1)
            {
                MessageBox.Show("Vui lòng nhập điểm Toán với tối đa 1 số thập phân.");
                textBox4.Text = "";
                return;
            }

            if (!float.TryParse(textBox5.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float dVan) || dVan < 0.0 || dVan > 10.0)
            {
                MessageBox.Show("Vui lòng nhập điểm Toán thích hợp.");
                textBox5.Text = "";
                return;
            }
            else if (textBox5.Text.Contains(".") && textBox5.Text.Split('.')[1].Length > 1)
            {
                MessageBox.Show("Vui lòng nhập điểm Văn với tối đa 1 số thập phân.");
                textBox5.Text = "";
                return;
            }

            // tạo biến để lưu thông tin sinh viên
            var sinhVien = new sinhVien
            {
                mssv = textBox1.Text,
                hoVaTen = textBox2.Text,
                sdt = textBox3.Text,
                dToan = textBox4.Text,
                dVan = textBox5.Text
            };

            list_sinhvien.add_sinhvien(sinhVien);
            // tăng bộ đếm khi nhập thông tin thành công
            i++;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            list_sinhvien.SaveToFile("C:\\Users\\hgbao\\OneDrive\\Máy tính\\uit\\nam2_hk2\\Lap_Trinh_Mang\\thuc-hanh\\Lab_2\\Lab_2_4\\input.txt");
        }

        // ktra từng textbox khi bấm 'enter'
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkStuCount())
                    textbox_condition();
                else 
                {
                    MessageBox.Show("Đã nhập đủ số lượng");
                    LoadFromFile();
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(checkStuCount())
                    textbox_condition();
                else
                {
                    MessageBox.Show("Đã nhập đủ số lượng");
                    LoadFromFile();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkStuCount())
                    textbox_condition();
                else
                {
                    MessageBox.Show("Đã nhập đủ số lượng");
                    LoadFromFile();
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkStuCount())
                    textbox_condition();
                else
                {
                    MessageBox.Show("Đã nhập đủ số lượng");
                    LoadFromFile();
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkStuCount())
                    textbox_condition();
                else
                {
                    MessageBox.Show("Đã nhập đủ số lượng");
                    LoadFromFile();
                }
            }
        }

        public void LoadFromFile()
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("C:\\Users\\hgbao\\OneDrive\\Máy tính\\uit\\nam2_hk2\\Lap_Trinh_Mang\\thuc-hanh\\Lab_2\\Lab_2_4\\input.txt"
                , FileMode.Open, FileAccess.Read))
            {
                var obj = formatter.Deserialize(stream);

                // Write the object to the output file
                using (var writer = new StreamWriter("C:\\Users\\hgbao\\OneDrive\\Máy tính\\uit\\nam2_hk2\\Lap_Trinh_Mang\\thuc-hanh\\Lab_2\\Lab_2_4\\output.txt"))
                {
                    writer.Write(obj.ToString()); // Or write the object in your desired format
                }
            }
        }
    }
}
