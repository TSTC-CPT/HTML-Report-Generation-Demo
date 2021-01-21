
namespace HTML_Demo
{
    partial class frmMain
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(25, 65);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(106, 24);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(135, 62);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(144, 29);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(135, 113);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(144, 29);
            this.tbxLastName.TabIndex = 2;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(25, 116);
            this.lblLast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(104, 24);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last Name:";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(135, 163);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(144, 29);
            this.tbxAge.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(79, 166);
            this.lblAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 24);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.ItemHeight = 24;
            this.lbxPeople.Location = new System.Drawing.Point(285, 62);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(340, 124);
            this.lbxPeople.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add Person";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(471, 198);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(154, 39);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "&Create Report";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(135, 14);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(490, 29);
            this.tbxTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Report Title:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(299, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 39);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 258);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxPeople);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
    }
}

