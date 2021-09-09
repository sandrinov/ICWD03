
namespace SchoolWinForm
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
            this.cmb_grades = new System.Windows.Forms.ComboBox();
            this.lst_students = new System.Windows.Forms.ListBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_resultSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_grades
            // 
            this.cmb_grades.FormattingEnabled = true;
            this.cmb_grades.Location = new System.Drawing.Point(94, 53);
            this.cmb_grades.Name = "cmb_grades";
            this.cmb_grades.Size = new System.Drawing.Size(121, 21);
            this.cmb_grades.TabIndex = 0;
            // 
            // lst_students
            // 
            this.lst_students.FormattingEnabled = true;
            this.lst_students.Location = new System.Drawing.Point(259, 50);
            this.lst_students.Name = "lst_students";
            this.lst_students.Size = new System.Drawing.Size(198, 264);
            this.lst_students.TabIndex = 1;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(259, 344);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(129, 45);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Order By Name";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(489, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 24);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Find";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(595, 53);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 20);
            this.txt_search.TabIndex = 4;
            // 
            // lbl_resultSearch
            // 
            this.lbl_resultSearch.AutoSize = true;
            this.lbl_resultSearch.Location = new System.Drawing.Point(495, 128);
            this.lbl_resultSearch.Name = "lbl_resultSearch";
            this.lbl_resultSearch.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultSearch.TabIndex = 5;
            this.lbl_resultSearch.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultSearch);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.lst_students);
            this.Controls.Add(this.cmb_grades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_grades;
        private System.Windows.Forms.ListBox lst_students;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_resultSearch;
    }
}

