namespace Khoi.FAP.StudentMgt
{
    partial class StudentListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSayHello = new Button();
            btnExit = new Button();
            dlgOpenFile = new OpenFileDialog();
            btnImage = new Button();
            picAvatar = new PictureBox();
            lblFileName = new Label();
            pnlImage = new Panel();
            dgvStudentList = new DataGridView();
            btnLoadData = new Button();
            lblID = new Label();
            lblName = new Label();
            lblAddress = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            grpStudent = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            grpStudent.SuspendLayout();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(48, 52);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(142, 41);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say hi";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += SayHi;
            btnSayHello.MouseLeave += BaseColor;
            btnSayHello.MouseHover += ChangeColor;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.InactiveCaption;
            btnExit.Location = new Point(228, 52);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 41);
            btnExit.TabIndex = 1;
            btnExit.Text = "Quit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += SayGoodBye;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "JPEG files |*.jpg;*.jpeg|PNG files|*.png";
            dlgOpenFile.FileOk += dlgOpenFile_FileOk;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(48, 116);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(142, 41);
            btnImage.TabIndex = 2;
            btnImage.Text = "Choose Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += OpenImage;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.Fixed3D;
            picAvatar.Location = new Point(16, 25);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(452, 317);
            picAvatar.SizeMode = PictureBoxSizeMode.AutoSize;
            picAvatar.TabIndex = 3;
            picAvatar.TabStop = false;
            picAvatar.Click += picAvatar_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(196, 137);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(58, 20);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "Image: ";
            lblFileName.Click += label1_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.Controls.Add(picAvatar);
            pnlImage.Location = new Point(32, 185);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(471, 355);
            pnlImage.TabIndex = 5;
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(600, 223);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 51;
            dgvStudentList.Size = new Size(464, 317);
            dgvStudentList.TabIndex = 6;
            dgvStudentList.CellContentClick += dgvStudentList_CellContentClick;
            dgvStudentList.SelectionChanged += ShowAStudent;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(534, 63);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(131, 42);
            btnLoadData.TabIndex = 7;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += LoadData;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(26, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 8;
            lblID.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 78);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(26, 122);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address:";
            // 
            // txtId
            // 
            txtId.Location = new Point(140, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(195, 27);
            txtId.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 27);
            txtName.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 119);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 13;
            // 
            // grpStudent
            // 
            grpStudent.BackColor = SystemColors.ButtonFace;
            grpStudent.Controls.Add(txtAddress);
            grpStudent.Controls.Add(txtName);
            grpStudent.Controls.Add(txtId);
            grpStudent.Controls.Add(lblAddress);
            grpStudent.Controls.Add(lblName);
            grpStudent.Controls.Add(lblID);
            grpStudent.FlatStyle = FlatStyle.System;
            grpStudent.Location = new Point(684, 52);
            grpStudent.Name = "grpStudent";
            grpStudent.Size = new Size(380, 154);
            grpStudent.TabIndex = 14;
            grpStudent.TabStop = false;
            grpStudent.Text = "  Student Information  ";
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1123, 602);
            Controls.Add(grpStudent);
            Controls.Add(btnLoadData);
            Controls.Add(dgvStudentList);
            Controls.Add(pnlImage);
            Controls.Add(lblFileName);
            Controls.Add(btnImage);
            Controls.Add(btnExit);
            Controls.Add(btnSayHello);
            Name = "StudentListForm";
            Text = "Student List";
            Load += StudentListForm_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            grpStudent.ResumeLayout(false);
            grpStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Button btnExit;
        private OpenFileDialog dlgOpenFile;
        private Button btnImage;
        private PictureBox picAvatar;
        private Label lblFileName;
        private Panel pnlImage;
        private DataGridView dgvStudentList;
        private Button btnLoadData;
        private Label lblID;
        private Label lblName;
        private Label lblAddress;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private GroupBox grpStudent;
    }
}
