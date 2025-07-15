namespace Khoi.FAP.StudentMgt
{
    public partial class StudentListForm : Form
    {
        List<Student> _ds = new List<Student>();
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void SayHi(object sender, EventArgs e)
        {
            MessageBox.Show("Hi there!, this is my message come from vs2022 & .NET 8"
                , "Notification!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        private void SayGoodBye(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit???"
                , "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dlgOpenFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenImage(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblFileName.Text = "Image: " + dlgOpenFile.FileName;

                picAvatar.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void LoadData(object sender, EventArgs e)
        {

            _ds.Add(new Student() { Id = "SE1", Name = "Phuoc Tran", Address = "Tay Ninh" });
            _ds.Add(new Student() { Id = "SE2", Name = "Huy Tran", Address = "Ha Noi" });
            _ds.Add(new Student() { Id = "SE3", Name = "Phuoc Tran", Address = "LA" });

            dgvStudentList.DataSource = _ds;
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangeColor(object sender, EventArgs e)
        {
            btnSayHello.BackColor = Color.LightBlue;
        }

        private void BaseColor(object sender, EventArgs e)
        {
            btnSayHello.BackColor = Color.White;
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAStudent(object sender, EventArgs e)
        {
            // ta sẽ sài các hàm, thuộc tính của dgv qua dấu .
            //toàn bộ những gì trên form đều là biến object trỏ vùng new 
            //DataGridView dgv = new DataGridView();
            //             dgv.DataSource = danh sách sv;
            //             dgv.Click += chừa chỗ cái hàm của ai đó
            //             dgv.Click thì làm gì, thì gọi hàm này
            //             xài các chấm khác để biết dòng nào được chọn, lấy từng cell
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                //lấy ra dòng đầu tiên trong nhiều dòng vừa chọn, trích từng cell ra, 3 cells
                DataGridViewRow selectedRow = dgvStudentList.SelectedRows[0];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            newStudent.Id = txtId.Text;
            newStudent.Name = txtName.Text;
            newStudent.Address = txtAddress.Text;
            _ds.Add(newStudent);
            //refresh grid
            dgvStudentList.DataSource = null; // clear cái grid trước mới gán lại đc
            dgvStudentList.DataSource = _ds;
        }

        private void grpStudent_Enter(object sender, EventArgs e)
        {

        }

        private void SearchStudent(object sender, EventArgs e)
        {
            //var result = _ds.Where(xxx => xxx.Name == txtKeyword.Text).ToList();

            var result = _ds.Where(xxx => xxx.Name.ToLower().Contains(txtKeyword.Text.ToLower()) ||
            xxx.Address.ToLower().Contains(txtKeyword.Text.ToLower())).ToList();

            //trả về 1 list trong RAM
            dgvResult.DataSource = null;
            dgvResult.DataSource = result;
        }
        //private void SearchStudent(object sender, EventArgs e)
        //{
        //    var result = _ds.Where(CheckNameStudent).ToList();
        //    //trả về 1 list trong RAM
        //    dgvResult.DataSource = null;
        //    dgvResult.DataSource = result;
        //}

        private bool CheckNameStudent(Student xxx) => xxx.Name == "Phuoc Tran";
    }
}
