namespace Thiago_Souza_Test_01_Ex_01 {
  partial class StudentDetails {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.contactTbx = new System.Windows.Forms.TextBox();
      this.addressTbx = new System.Windows.Forms.TextBox();
      this.nameTbx = new System.Windows.Forms.TextBox();
      this.studentIdTbx = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.updateStudentDetailsBtn = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.updateStudentDetailsBtn);
      this.groupBox1.Controls.Add(this.contactTbx);
      this.groupBox1.Controls.Add(this.addressTbx);
      this.groupBox1.Controls.Add(this.nameTbx);
      this.groupBox1.Controls.Add(this.studentIdTbx);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(327, 273);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Student Details";
      // 
      // contactTbx
      // 
      this.contactTbx.Location = new System.Drawing.Point(113, 163);
      this.contactTbx.Name = "contactTbx";
      this.contactTbx.Size = new System.Drawing.Size(174, 22);
      this.contactTbx.TabIndex = 7;
      // 
      // addressTbx
      // 
      this.addressTbx.Location = new System.Drawing.Point(113, 125);
      this.addressTbx.Name = "addressTbx";
      this.addressTbx.Size = new System.Drawing.Size(174, 22);
      this.addressTbx.TabIndex = 6;
      // 
      // nameTbx
      // 
      this.nameTbx.Location = new System.Drawing.Point(113, 81);
      this.nameTbx.Name = "nameTbx";
      this.nameTbx.Size = new System.Drawing.Size(174, 22);
      this.nameTbx.TabIndex = 5;
      // 
      // studentIdTbx
      // 
      this.studentIdTbx.Location = new System.Drawing.Point(113, 39);
      this.studentIdTbx.Name = "studentIdTbx";
      this.studentIdTbx.Size = new System.Drawing.Size(174, 22);
      this.studentIdTbx.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(38, 163);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(68, 17);
      this.label4.TabIndex = 3;
      this.label4.Text = "Contact:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(34, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Address:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(52, 81);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Name:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Student ID:";
      // 
      // updateStudentDetailsBtn
      // 
      this.updateStudentDetailsBtn.Location = new System.Drawing.Point(37, 215);
      this.updateStudentDetailsBtn.Name = "updateStudentDetailsBtn";
      this.updateStudentDetailsBtn.Size = new System.Drawing.Size(250, 32);
      this.updateStudentDetailsBtn.TabIndex = 8;
      this.updateStudentDetailsBtn.Text = "Update Student Details";
      this.updateStudentDetailsBtn.UseVisualStyleBackColor = true;
      this.updateStudentDetailsBtn.Click += new System.EventHandler(this.updateStudentDetailsBtn_Click);
      // 
      // StudentDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "StudentDetails";
      this.Size = new System.Drawing.Size(331, 277);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox studentIdTbx;
    private System.Windows.Forms.TextBox contactTbx;
    private System.Windows.Forms.TextBox addressTbx;
    private System.Windows.Forms.TextBox nameTbx;
    private System.Windows.Forms.Button updateStudentDetailsBtn;
  }
}
