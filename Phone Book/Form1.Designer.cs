
namespace Phone_Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.familytxt = new System.Windows.Forms.TextBox();
            this.telltxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchcombobox = new System.Windows.Forms.ComboBox();
            this.findtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.prebtn = new System.Windows.Forms.Button();
            this.lastbtn = new System.Windows.Forms.Button();
            this.firstbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Family";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tell_number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(128, 17);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(212, 26);
            this.nametxt.TabIndex = 4;
            // 
            // familytxt
            // 
            this.familytxt.Location = new System.Drawing.Point(128, 59);
            this.familytxt.Name = "familytxt";
            this.familytxt.ReadOnly = true;
            this.familytxt.Size = new System.Drawing.Size(212, 26);
            this.familytxt.TabIndex = 5;
            // 
            // telltxt
            // 
            this.telltxt.Location = new System.Drawing.Point(128, 104);
            this.telltxt.Name = "telltxt";
            this.telltxt.ReadOnly = true;
            this.telltxt.Size = new System.Drawing.Size(212, 26);
            this.telltxt.TabIndex = 6;
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(128, 145);
            this.citytxt.Name = "citytxt";
            this.citytxt.ReadOnly = true;
            this.citytxt.Size = new System.Drawing.Size(212, 26);
            this.citytxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search_by";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Find";
            // 
            // searchcombobox
            // 
            this.searchcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchcombobox.FormattingEnabled = true;
            this.searchcombobox.Items.AddRange(new object[] {
            "name",
            "family",
            "tell_number",
            "city"});
            this.searchcombobox.Location = new System.Drawing.Point(466, 15);
            this.searchcombobox.Name = "searchcombobox";
            this.searchcombobox.Size = new System.Drawing.Size(157, 28);
            this.searchcombobox.TabIndex = 10;
            // 
            // findtxt
            // 
            this.findtxt.Location = new System.Drawing.Point(466, 59);
            this.findtxt.Name = "findtxt";
            this.findtxt.Size = new System.Drawing.Size(157, 26);
            this.findtxt.TabIndex = 11;
            this.findtxt.TextChanged += new System.EventHandler(this.findtxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(255, 174);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(18, 200);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(79, 31);
            this.newbtn.TabIndex = 13;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Enabled = false;
            this.savebtn.Location = new System.Drawing.Point(103, 200);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(79, 31);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(188, 200);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(79, 31);
            this.editbtn.TabIndex = 15;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(273, 200);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(79, 31);
            this.delbtn.TabIndex = 16;
            this.delbtn.Text = "Del";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(18, 247);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(79, 31);
            this.nextbtn.TabIndex = 17;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // prebtn
            // 
            this.prebtn.Location = new System.Drawing.Point(103, 247);
            this.prebtn.Name = "prebtn";
            this.prebtn.Size = new System.Drawing.Size(79, 31);
            this.prebtn.TabIndex = 18;
            this.prebtn.Text = "Pre";
            this.prebtn.UseVisualStyleBackColor = true;
            this.prebtn.Click += new System.EventHandler(this.prebtn_Click);
            // 
            // lastbtn
            // 
            this.lastbtn.Location = new System.Drawing.Point(188, 247);
            this.lastbtn.Name = "lastbtn";
            this.lastbtn.Size = new System.Drawing.Size(79, 31);
            this.lastbtn.TabIndex = 19;
            this.lastbtn.Text = "Last";
            this.lastbtn.UseVisualStyleBackColor = true;
            this.lastbtn.Click += new System.EventHandler(this.lastbtn_Click);
            // 
            // firstbtn
            // 
            this.firstbtn.Location = new System.Drawing.Point(273, 247);
            this.firstbtn.Name = "firstbtn";
            this.firstbtn.Size = new System.Drawing.Size(79, 31);
            this.firstbtn.TabIndex = 20;
            this.firstbtn.Text = "first";
            this.firstbtn.UseVisualStyleBackColor = true;
            this.firstbtn.Click += new System.EventHandler(this.firstbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 290);
            this.Controls.Add(this.firstbtn);
            this.Controls.Add(this.lastbtn);
            this.Controls.Add(this.prebtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findtxt);
            this.Controls.Add(this.searchcombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.telltxt);
            this.Controls.Add(this.familytxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Family";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox familytxt;
        private System.Windows.Forms.TextBox telltxt;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox searchcombobox;
        private System.Windows.Forms.TextBox findtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button prebtn;
        private System.Windows.Forms.Button lastbtn;
        private System.Windows.Forms.Button firstbtn;
    }
}

