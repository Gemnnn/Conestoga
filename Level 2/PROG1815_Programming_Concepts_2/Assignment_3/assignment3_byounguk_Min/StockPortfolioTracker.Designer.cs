namespace assignment3_byounguk_Min
{
    partial class StockPortfolioTracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetNewId = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddCommission = new System.Windows.Forms.TextBox();
            this.txtAddOfShares = new System.Windows.Forms.TextBox();
            this.txtAddSharePrice = new System.Windows.Forms.TextBox();
            this.txtAddNotes = new System.Windows.Forms.RichTextBox();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.rdoSell = new System.Windows.Forms.RadioButton();
            this.rdoBuy = new System.Windows.Forms.RadioButton();
            this.txtAddCompany = new System.Windows.Forms.TextBox();
            this.txtAddSymbol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreat = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name and path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(462, 21);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\budgets\\2021\\sec3\\ByoungukMin\\transactions.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetNewId);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddCommission);
            this.groupBox1.Controls.Add(this.txtAddOfShares);
            this.groupBox1.Controls.Add(this.txtAddSharePrice);
            this.groupBox1.Controls.Add(this.txtAddNotes);
            this.groupBox1.Controls.Add(this.transactionDate);
            this.groupBox1.Controls.Add(this.rdoSell);
            this.groupBox1.Controls.Add(this.rdoBuy);
            this.groupBox1.Controls.Add(this.txtAddCompany);
            this.groupBox1.Controls.Add(this.txtAddSymbol);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAddId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 408);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/update transaction:";
            // 
            // btnGetNewId
            // 
            this.btnGetNewId.Location = new System.Drawing.Point(214, 20);
            this.btnGetNewId.Name = "btnGetNewId";
            this.btnGetNewId.Size = new System.Drawing.Size(104, 26);
            this.btnGetNewId.TabIndex = 1;
            this.btnGetNewId.Text = "Get new ID";
            this.btnGetNewId.UseVisualStyleBackColor = true;
            this.btnGetNewId.Click += new System.EventHandler(this.btnGetNewId_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 26);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add/update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddCommission
            // 
            this.txtAddCommission.Location = new System.Drawing.Point(117, 330);
            this.txtAddCommission.Name = "txtAddCommission";
            this.txtAddCommission.Size = new System.Drawing.Size(106, 21);
            this.txtAddCommission.TabIndex = 11;
            // 
            // txtAddOfShares
            // 
            this.txtAddOfShares.Location = new System.Drawing.Point(117, 305);
            this.txtAddOfShares.Name = "txtAddOfShares";
            this.txtAddOfShares.Size = new System.Drawing.Size(106, 21);
            this.txtAddOfShares.TabIndex = 10;
            // 
            // txtAddSharePrice
            // 
            this.txtAddSharePrice.Location = new System.Drawing.Point(117, 280);
            this.txtAddSharePrice.Name = "txtAddSharePrice";
            this.txtAddSharePrice.Size = new System.Drawing.Size(106, 21);
            this.txtAddSharePrice.TabIndex = 9;
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.Location = new System.Drawing.Point(117, 162);
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(214, 107);
            this.txtAddNotes.TabIndex = 8;
            this.txtAddNotes.Text = "";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(117, 125);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(214, 21);
            this.transactionDate.TabIndex = 7;
            // 
            // rdoSell
            // 
            this.rdoSell.AutoSize = true;
            this.rdoSell.Location = new System.Drawing.Point(193, 103);
            this.rdoSell.Name = "rdoSell";
            this.rdoSell.Size = new System.Drawing.Size(44, 16);
            this.rdoSell.TabIndex = 6;
            this.rdoSell.TabStop = true;
            this.rdoSell.Text = "Sell";
            this.rdoSell.UseVisualStyleBackColor = true;
            // 
            // rdoBuy
            // 
            this.rdoBuy.AutoSize = true;
            this.rdoBuy.Location = new System.Drawing.Point(117, 103);
            this.rdoBuy.Name = "rdoBuy";
            this.rdoBuy.Size = new System.Drawing.Size(45, 16);
            this.rdoBuy.TabIndex = 4;
            this.rdoBuy.TabStop = true;
            this.rdoBuy.Text = "Buy";
            this.rdoBuy.UseVisualStyleBackColor = true;
            // 
            // txtAddCompany
            // 
            this.txtAddCompany.Location = new System.Drawing.Point(117, 76);
            this.txtAddCompany.Name = "txtAddCompany";
            this.txtAddCompany.Size = new System.Drawing.Size(214, 21);
            this.txtAddCompany.TabIndex = 3;
            // 
            // txtAddSymbol
            // 
            this.txtAddSymbol.Location = new System.Drawing.Point(117, 50);
            this.txtAddSymbol.Name = "txtAddSymbol";
            this.txtAddSymbol.Size = new System.Drawing.Size(67, 21);
            this.txtAddSymbol.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "Commission:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "# of shares:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Share price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "Notes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Transaction Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Company:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ticker symbol:";
            // 
            // txtAddId
            // 
            this.txtAddId.Location = new System.Drawing.Point(117, 24);
            this.txtAddId.Name = "txtAddId";
            this.txtAddId.Size = new System.Drawing.Size(91, 21);
            this.txtAddId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transaction ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtDeleteId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 485);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete transaction:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 26);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete transacion";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(109, 30);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(120, 21);
            this.txtDeleteId.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "Transaction ID:";
            // 
            // btnCreat
            // 
            this.btnCreat.Location = new System.Drawing.Point(489, 28);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(138, 30);
            this.btnCreat.TabIndex = 1;
            this.btnCreat.Text = "Create/open file";
            this.btnCreat.UseVisualStyleBackColor = true;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(489, 511);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(158, 26);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display Transaction";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(670, 510);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(94, 26);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "Empty file";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(787, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(922, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "Messages:";
            // 
            // txtMessages
            // 
            this.txtMessages.ForeColor = System.Drawing.Color.Red;
            this.txtMessages.Location = new System.Drawing.Point(924, 514);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.Size = new System.Drawing.Size(569, 63);
            this.txtMessages.TabIndex = 7;
            this.txtMessages.Text = "";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(361, 71);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(1132, 408);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "";
            // 
            // StockPortfolioTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 582);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnCreat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "StockPortfolioTracker";
            this.Text = "Stock Portfolio Tracker";
            this.Load += new System.EventHandler(this.StockPortfolioTracker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddCommission;
        private System.Windows.Forms.TextBox txtAddOfShares;
        private System.Windows.Forms.TextBox txtAddSharePrice;
        private System.Windows.Forms.RichTextBox txtAddNotes;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.RadioButton rdoSell;
        private System.Windows.Forms.RadioButton rdoBuy;
        private System.Windows.Forms.TextBox txtAddCompany;
        private System.Windows.Forms.TextBox txtAddSymbol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Button btnGetNewId;
    }
}

