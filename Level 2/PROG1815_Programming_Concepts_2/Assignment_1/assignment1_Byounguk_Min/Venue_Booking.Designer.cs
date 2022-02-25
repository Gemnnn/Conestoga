namespace assignment1_Byounguk_Min
{
    partial class Venue_Booking
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venue_Booking));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowWaiting = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lstSeat = new System.Windows.Forms.ListBox();
            this.lstRow = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rtbReservations = new System.Windows.Forms.RichTextBox();
            this.rtbWaiting = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbWaiting);
            this.groupBox1.Controls.Add(this.rtbReservations);
            this.groupBox1.Controls.Add(this.btnShowWaiting);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Location = new System.Drawing.Point(353, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking and Reervations";
            // 
            // btnShowWaiting
            // 
            this.btnShowWaiting.Location = new System.Drawing.Point(255, 25);
            this.btnShowWaiting.Name = "btnShowWaiting";
            this.btnShowWaiting.Size = new System.Drawing.Size(158, 27);
            this.btnShowWaiting.TabIndex = 1;
            this.btnShowWaiting.Text = "Show Waiting List";
            this.btnShowWaiting.UseVisualStyleBackColor = true;
            this.btnShowWaiting.Click += new System.EventHandler(this.btnShowWaiting_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(27, 25);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(158, 27);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All Reservations";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCustomerName);
            this.groupBox2.Controls.Add(this.lblSeat);
            this.groupBox2.Controls.Add(this.lblRow);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnDebug);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.lstSeat);
            this.groupBox2.Controls.Add(this.lstRow);
            this.groupBox2.Location = new System.Drawing.Point(14, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bookings_Cancellations";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("굴림", 9F);
            this.lblCustomerName.Location = new System.Drawing.Point(212, 66);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(98, 12);
            this.lblCustomerName.TabIndex = 10;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("굴림", 9F);
            this.lblSeat.Location = new System.Drawing.Point(133, 32);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(30, 12);
            this.lblSeat.TabIndex = 9;
            this.lblSeat.Text = "Seat";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("굴림", 9F);
            this.lblRow.Location = new System.Drawing.Point(40, 32);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(30, 12);
            this.lblRow.TabIndex = 8;
            this.lblRow.Text = "Row";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("굴림", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(603, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Font = new System.Drawing.Font("굴림", 9F);
            this.btnDebug.ForeColor = System.Drawing.Color.Red;
            this.btnDebug.Location = new System.Drawing.Point(339, 147);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(254, 35);
            this.btnDebug.TabIndex = 6;
            this.btnDebug.Text = "Debug - Fill All Seats";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 9F);
            this.btnAdd.Location = new System.Drawing.Point(603, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add to Watiting";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btnCancel.Location = new System.Drawing.Point(471, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("굴림", 9F);
            this.btnBook.Location = new System.Drawing.Point(339, 106);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(122, 35);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("굴림", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(339, 63);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(386, 23);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lstSeat
            // 
            this.lstSeat.Font = new System.Drawing.Font("굴림", 10F);
            this.lstSeat.FormattingEnabled = true;
            this.lstSeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lstSeat.Location = new System.Drawing.Point(117, 58);
            this.lstSeat.Name = "lstSeat";
            this.lstSeat.Size = new System.Drawing.Size(71, 121);
            this.lstSeat.TabIndex = 1;
            // 
            // lstRow
            // 
            this.lstRow.Font = new System.Drawing.Font("굴림", 10F);
            this.lstRow.FormattingEnabled = true;
            this.lstRow.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.lstRow.Location = new System.Drawing.Point(23, 58);
            this.lstRow.Name = "lstRow";
            this.lstRow.Size = new System.Drawing.Size(71, 121);
            this.lstRow.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(12, 543);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(17, 12);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "...";
            // 
            // rtbReservations
            // 
            this.rtbReservations.Location = new System.Drawing.Point(6, 58);
            this.rtbReservations.Name = "rtbReservations";
            this.rtbReservations.Size = new System.Drawing.Size(196, 217);
            this.rtbReservations.TabIndex = 2;
            this.rtbReservations.Text = "";
            // 
            // rtbWaiting
            // 
            this.rtbWaiting.Location = new System.Drawing.Point(238, 58);
            this.rtbWaiting.Name = "rtbWaiting";
            this.rtbWaiting.Size = new System.Drawing.Size(196, 217);
            this.rtbWaiting.TabIndex = 3;
            this.rtbWaiting.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 613);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Venue Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowWaiting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ListBox lstSeat;
        private System.Windows.Forms.ListBox lstRow;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox rtbWaiting;
        private System.Windows.Forms.RichTextBox rtbReservations;
    }
}

