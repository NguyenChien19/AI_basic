namespace Lap05_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Click += textBox3_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox và MaskedTextBox
            string hoTen = textHoTen.Text;
            string diaChi = textDiaChi.Text;
            string ngaySinh = maskedTextNgaySinh.Text;
            string dienThoaiBan = maskedTextDienThoaiBan.Text;
            string dienThoaiDiDong = maskedTextDienThoaiDiDong.Text;

            // Thực hiện xử lý với dữ liệu đã lấy
            MessageBox.Show($"Họ tên: {hoTen}\nĐịa chỉ: {diaChi}\nNgày sinh: {ngaySinh}\nĐiện thoại bàn: {dienThoaiBan}\nĐiện thoại di động: {dienThoaiDiDong}");
        }

        private void textHoTen_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            // Xử lý khi nút được nhấn
        }
        //private void LayD
        private void textBox3_Click(object sender, EventArgs e)
        {
            string hoTen = textHoTen.Text;
            string diaChi = textDiaChi.Text;
            string ngaySinh = maskedTextNgaySinh.Text;
            string dienThoaiBan = maskedTextDienThoaiBan.Text;
            string dienThoaiDiDong = maskedTextDienThoaiDiDong.Text;

            // Thực hiện xử lý với dữ liệu đã lấy
            MessageBox.Show($"Họ tên: {hoTen}\nĐịa chỉ: {diaChi}\nNgày sinh: {ngaySinh}\nĐiện thoại bàn: {dienThoaiBan}\nĐiện thoại di động: {dienThoaiDiDong}");

        }
    }
}