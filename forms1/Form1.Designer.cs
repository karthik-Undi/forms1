
namespace forms1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusMessage = new System.Windows.Forms.Label();
            this.OpenCon = new System.Windows.Forms.Button();
            this.CloseCon = new System.Windows.Forms.Button();
            this.GetCount = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Excelbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Addmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database Test";
            // 
            // StatusMessage
            // 
            this.StatusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusMessage.AutoSize = true;
            this.StatusMessage.Location = new System.Drawing.Point(576, 531);
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(28, 17);
            this.StatusMessage.TabIndex = 2;
            this.StatusMessage.Text = "----";
            this.StatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenCon
            // 
            this.OpenCon.Location = new System.Drawing.Point(12, 497);
            this.OpenCon.Name = "OpenCon";
            this.OpenCon.Size = new System.Drawing.Size(149, 46);
            this.OpenCon.TabIndex = 3;
            this.OpenCon.Text = "Open Connection";
            this.OpenCon.UseVisualStyleBackColor = true;
            this.OpenCon.Click += new System.EventHandler(this.OpenCon_Click);
            // 
            // CloseCon
            // 
            this.CloseCon.Location = new System.Drawing.Point(293, 497);
            this.CloseCon.Name = "CloseCon";
            this.CloseCon.Size = new System.Drawing.Size(122, 46);
            this.CloseCon.TabIndex = 4;
            this.CloseCon.Text = "Close Conection";
            this.CloseCon.UseVisualStyleBackColor = true;
            this.CloseCon.Click += new System.EventHandler(this.CloseCon_Click);
            // 
            // GetCount
            // 
            this.GetCount.Location = new System.Drawing.Point(174, 497);
            this.GetCount.Name = "GetCount";
            this.GetCount.Size = new System.Drawing.Size(106, 46);
            this.GetCount.TabIndex = 5;
            this.GetCount.Text = "Get Count";
            this.GetCount.UseVisualStyleBackColor = true;
            this.GetCount.Click += new System.EventHandler(this.GetCount_Click);
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(625, 112);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(197, 28);
            this.IdBox.TabIndex = 6;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(625, 207);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(197, 28);
            this.NameBox.TabIndex = 7;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBox.Location = new System.Drawing.Point(625, 302);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(197, 28);
            this.SalaryBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salary";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(550, 378);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 46);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add to Table";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(693, 378);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(102, 46);
            this.Updatebtn.TabIndex = 12;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(801, 378);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(102, 46);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Excelbtn
            // 
            this.Excelbtn.Location = new System.Drawing.Point(428, 496);
            this.Excelbtn.Name = "Excelbtn";
            this.Excelbtn.Size = new System.Drawing.Size(114, 46);
            this.Excelbtn.TabIndex = 4;
            this.Excelbtn.Text = "Show Excel";
            this.Excelbtn.UseVisualStyleBackColor = true;
            this.Excelbtn.Click += new System.EventHandler(this.Excelbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note : Fill only ID to Delete";
            // 
            // Addmsg
            // 
            this.Addmsg.AutoSize = true;
            this.Addmsg.Location = new System.Drawing.Point(576, 496);
            this.Addmsg.Name = "Addmsg";
            this.Addmsg.Size = new System.Drawing.Size(28, 17);
            this.Addmsg.TabIndex = 14;
            this.Addmsg.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 595);
            this.Controls.Add(this.Addmsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.Excelbtn);
            this.Controls.Add(this.CloseCon);
            this.Controls.Add(this.OpenCon);
            this.Controls.Add(this.StatusMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusMessage;
        private System.Windows.Forms.Button OpenCon;
        private System.Windows.Forms.Button CloseCon;
        private System.Windows.Forms.Button GetCount;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Excelbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Addmsg;
    }
}

