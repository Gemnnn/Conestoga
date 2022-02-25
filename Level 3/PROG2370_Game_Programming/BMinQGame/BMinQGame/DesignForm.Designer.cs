
namespace BMinQGame
{
    partial class DesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGernerate = new System.Windows.Forms.Button();
            this.txtColums = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntGreenBox = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGernerate);
            this.groupBox1.Controls.Add(this.txtColums);
            this.groupBox1.Controls.Add(this.txtRows);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(1, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colums :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows : ";
            // 
            // btnGernerate
            // 
            this.btnGernerate.Location = new System.Drawing.Point(402, 18);
            this.btnGernerate.Name = "btnGernerate";
            this.btnGernerate.Size = new System.Drawing.Size(134, 39);
            this.btnGernerate.TabIndex = 1;
            this.btnGernerate.Text = "Generate";
            this.btnGernerate.UseVisualStyleBackColor = true;
            this.btnGernerate.Click += new System.EventHandler(this.btnGernerate_Click);
            // 
            // txtColums
            // 
            this.txtColums.Location = new System.Drawing.Point(258, 28);
            this.txtColums.Name = "txtColums";
            this.txtColums.Size = new System.Drawing.Size(100, 20);
            this.txtColums.TabIndex = 0;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(65, 28);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bntGreenBox);
            this.panel1.Controls.Add(this.btnRedBox);
            this.panel1.Controls.Add(this.btnGreenDoor);
            this.panel1.Controls.Add(this.btnRedDoor);
            this.panel1.Controls.Add(this.btnWall);
            this.panel1.Controls.Add(this.btnNone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 556);
            this.panel1.TabIndex = 2;
            // 
            // bntGreenBox
            // 
            this.bntGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGreenBox.ImageIndex = 5;
            this.bntGreenBox.ImageList = this.imageList1;
            this.bntGreenBox.Location = new System.Drawing.Point(3, 437);
            this.bntGreenBox.Name = "bntGreenBox";
            this.bntGreenBox.Size = new System.Drawing.Size(156, 73);
            this.bntGreenBox.TabIndex = 1;
            this.bntGreenBox.Text = "Green Box";
            this.bntGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGreenBox.UseVisualStyleBackColor = true;
            this.bntGreenBox.Click += new System.EventHandler(this.ToolBoxButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "none.jpg");
            this.imageList1.Images.SetKeyName(1, "wall.jpg");
            this.imageList1.Images.SetKeyName(2, "reddoor.jpg");
            this.imageList1.Images.SetKeyName(3, "greendoor.jpg");
            this.imageList1.Images.SetKeyName(4, "redbox.jpg");
            this.imageList1.Images.SetKeyName(5, "greenbox.jpg");
            // 
            // btnRedBox
            // 
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.ImageIndex = 4;
            this.btnRedBox.ImageList = this.imageList1;
            this.btnRedBox.Location = new System.Drawing.Point(3, 358);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(156, 73);
            this.btnRedBox.TabIndex = 1;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.ToolBoxButton_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.ImageIndex = 3;
            this.btnGreenDoor.ImageList = this.imageList1;
            this.btnGreenDoor.Location = new System.Drawing.Point(3, 279);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(156, 73);
            this.btnGreenDoor.TabIndex = 1;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.ToolBoxButton_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.ImageIndex = 2;
            this.btnRedDoor.ImageList = this.imageList1;
            this.btnRedDoor.Location = new System.Drawing.Point(3, 200);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(156, 73);
            this.btnRedDoor.TabIndex = 1;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.ToolBoxButton_Click);
            // 
            // btnWall
            // 
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imageList1;
            this.btnWall.Location = new System.Drawing.Point(3, 121);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(156, 73);
            this.btnWall.TabIndex = 1;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.ToolBoxButton_Click);
            // 
            // btnNone
            // 
            this.btnNone.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.Location = new System.Drawing.Point(3, 42);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(156, 73);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.ToolBoxButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tool Box";
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGernerate;
        private System.Windows.Forms.TextBox txtColums;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button bntGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}