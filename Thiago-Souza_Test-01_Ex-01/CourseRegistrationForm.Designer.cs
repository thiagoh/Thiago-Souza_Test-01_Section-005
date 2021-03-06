﻿namespace Thiago_Souza_Test_01_Ex_01 {
  partial class CourseRegistrationForm {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseRegistrationForm));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.addBtn = new System.Windows.Forms.Button();
      this.clearBtn = new System.Windows.Forms.Button();
      this.gamingCbx = new System.Windows.Forms.CheckBox();
      this.healthCbx = new System.Windows.Forms.CheckBox();
      this.gymMembershipCbx = new System.Windows.Forms.CheckBox();
      this.activityClubCbx = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.programNameCbx = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ptDistanceRad = new System.Windows.Forms.RadioButton();
      this.ptParttimeRad = new System.Windows.Forms.RadioButton();
      this.ptFulltimeRad = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.courseSummaryTbx = new System.Windows.Forms.TextBox();
      this.clearCourseSummaryBtn = new System.Windows.Forms.Button();
      this.registerBtn = new System.Windows.Forms.Button();
      this.exitBtn = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.totalProgramCostTbx = new System.Windows.Forms.TextBox();
      this.studentDetailsComponent = new Thiago_Souza_Test_01_Ex_01.StudentDetails();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.addBtn);
      this.groupBox1.Controls.Add(this.clearBtn);
      this.groupBox1.Controls.Add(this.gamingCbx);
      this.groupBox1.Controls.Add(this.healthCbx);
      this.groupBox1.Controls.Add(this.gymMembershipCbx);
      this.groupBox1.Controls.Add(this.activityClubCbx);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.listBox1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.programNameCbx);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.ptDistanceRad);
      this.groupBox1.Controls.Add(this.ptParttimeRad);
      this.groupBox1.Controls.Add(this.ptFulltimeRad);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(373, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(518, 277);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Program Details:";
      // 
      // addBtn
      // 
      this.addBtn.Location = new System.Drawing.Point(192, 235);
      this.addBtn.Name = "addBtn";
      this.addBtn.Size = new System.Drawing.Size(140, 36);
      this.addBtn.TabIndex = 14;
      this.addBtn.Text = "Add";
      this.addBtn.UseVisualStyleBackColor = true;
      this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
      // 
      // clearBtn
      // 
      this.clearBtn.Location = new System.Drawing.Point(15, 235);
      this.clearBtn.Name = "clearBtn";
      this.clearBtn.Size = new System.Drawing.Size(140, 36);
      this.clearBtn.TabIndex = 13;
      this.clearBtn.Text = "Clear";
      this.clearBtn.UseVisualStyleBackColor = true;
      this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
      // 
      // gamingCbx
      // 
      this.gamingCbx.AutoSize = true;
      this.gamingCbx.Location = new System.Drawing.Point(15, 209);
      this.gamingCbx.Name = "gamingCbx";
      this.gamingCbx.Size = new System.Drawing.Size(119, 21);
      this.gamingCbx.TabIndex = 12;
      this.gamingCbx.Text = "Gaming Club";
      this.gamingCbx.UseVisualStyleBackColor = true;
      this.gamingCbx.CheckedChanged += new System.EventHandler(this.gamingCbx_CheckedChanged);
      // 
      // healthCbx
      // 
      this.healthCbx.AutoSize = true;
      this.healthCbx.Location = new System.Drawing.Point(15, 177);
      this.healthCbx.Name = "healthCbx";
      this.healthCbx.Size = new System.Drawing.Size(74, 21);
      this.healthCbx.TabIndex = 11;
      this.healthCbx.Text = "Health";
      this.healthCbx.UseVisualStyleBackColor = true;
      this.healthCbx.CheckedChanged += new System.EventHandler(this.healthCbx_CheckedChanged);
      // 
      // gymMembershipCbx
      // 
      this.gymMembershipCbx.AutoSize = true;
      this.gymMembershipCbx.Location = new System.Drawing.Point(15, 145);
      this.gymMembershipCbx.Name = "gymMembershipCbx";
      this.gymMembershipCbx.Size = new System.Drawing.Size(151, 21);
      this.gymMembershipCbx.TabIndex = 10;
      this.gymMembershipCbx.Text = "Gym Membership";
      this.gymMembershipCbx.UseVisualStyleBackColor = true;
      this.gymMembershipCbx.CheckedChanged += new System.EventHandler(this.gymMembershipCbx_CheckedChanged);
      // 
      // activityClubCbx
      // 
      this.activityClubCbx.AutoSize = true;
      this.activityClubCbx.Location = new System.Drawing.Point(15, 113);
      this.activityClubCbx.Name = "activityClubCbx";
      this.activityClubCbx.Size = new System.Drawing.Size(116, 21);
      this.activityClubCbx.TabIndex = 9;
      this.activityClubCbx.Text = "Activity Club";
      this.activityClubCbx.UseVisualStyleBackColor = true;
      this.activityClubCbx.CheckedChanged += new System.EventHandler(this.activityClubCbx_CheckedChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(11, 83);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(155, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "Campus Facilities:";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(364, 79);
      this.listBox1.Name = "listBox1";
      this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listBox1.Size = new System.Drawing.Size(125, 180);
      this.listBox1.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(361, 55);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(122, 17);
      this.label3.TabIndex = 6;
      this.label3.Text = "List of Courses:";
      // 
      // programNameCbx
      // 
      this.programNameCbx.FormattingEnabled = true;
      this.programNameCbx.Items.AddRange(new object[] {
            "Network",
            "Mobile",
            "Software"});
      this.programNameCbx.Location = new System.Drawing.Point(168, 52);
      this.programNameCbx.Name = "programNameCbx";
      this.programNameCbx.Size = new System.Drawing.Size(174, 24);
      this.programNameCbx.TabIndex = 5;
      this.programNameCbx.SelectedIndexChanged += new System.EventHandler(this.programNameCbx_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(128, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Program Names:";
      // 
      // ptDistanceRad
      // 
      this.ptDistanceRad.AutoSize = true;
      this.ptDistanceRad.Location = new System.Drawing.Point(400, 22);
      this.ptDistanceRad.Name = "ptDistanceRad";
      this.ptDistanceRad.Size = new System.Drawing.Size(89, 21);
      this.ptDistanceRad.TabIndex = 3;
      this.ptDistanceRad.TabStop = true;
      this.ptDistanceRad.Text = "Distance";
      this.ptDistanceRad.UseVisualStyleBackColor = true;
      // 
      // ptParttimeRad
      // 
      this.ptParttimeRad.AutoSize = true;
      this.ptParttimeRad.Location = new System.Drawing.Point(280, 22);
      this.ptParttimeRad.Name = "ptParttimeRad";
      this.ptParttimeRad.Size = new System.Drawing.Size(97, 21);
      this.ptParttimeRad.TabIndex = 2;
      this.ptParttimeRad.TabStop = true;
      this.ptParttimeRad.Text = "Part-Time";
      this.ptParttimeRad.UseVisualStyleBackColor = true;
      // 
      // ptFulltimeRad
      // 
      this.ptFulltimeRad.AutoSize = true;
      this.ptFulltimeRad.Location = new System.Drawing.Point(168, 22);
      this.ptFulltimeRad.Name = "ptFulltimeRad";
      this.ptFulltimeRad.Size = new System.Drawing.Size(93, 21);
      this.ptFulltimeRad.TabIndex = 1;
      this.ptFulltimeRad.TabStop = true;
      this.ptFulltimeRad.Text = "Full-Time";
      this.ptFulltimeRad.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(11, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(133, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Program Types:";
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
      this.groupBox2.Controls.Add(this.courseSummaryTbx);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(13, 297);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(878, 133);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Course Summary:";
      // 
      // courseSummaryTbx
      // 
      this.courseSummaryTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.courseSummaryTbx.Location = new System.Drawing.Point(7, 22);
      this.courseSummaryTbx.Multiline = true;
      this.courseSummaryTbx.Name = "courseSummaryTbx";
      this.courseSummaryTbx.Size = new System.Drawing.Size(865, 105);
      this.courseSummaryTbx.TabIndex = 0;
      this.courseSummaryTbx.Text = resources.GetString("courseSummaryTbx.Text");
      // 
      // clearCourseSummaryBtn
      // 
      this.clearCourseSummaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clearCourseSummaryBtn.Location = new System.Drawing.Point(13, 462);
      this.clearCourseSummaryBtn.Name = "clearCourseSummaryBtn";
      this.clearCourseSummaryBtn.Size = new System.Drawing.Size(234, 36);
      this.clearCourseSummaryBtn.TabIndex = 15;
      this.clearCourseSummaryBtn.Text = "Clear Course Summary";
      this.clearCourseSummaryBtn.UseVisualStyleBackColor = true;
      this.clearCourseSummaryBtn.Click += new System.EventHandler(this.clearCourseSummaryBtn_Click);
      // 
      // registerBtn
      // 
      this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.registerBtn.Location = new System.Drawing.Point(253, 462);
      this.registerBtn.Name = "registerBtn";
      this.registerBtn.Size = new System.Drawing.Size(140, 36);
      this.registerBtn.TabIndex = 16;
      this.registerBtn.Text = "Register";
      this.registerBtn.UseVisualStyleBackColor = true;
      this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
      // 
      // exitBtn
      // 
      this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.exitBtn.Location = new System.Drawing.Point(399, 462);
      this.exitBtn.Name = "exitBtn";
      this.exitBtn.Size = new System.Drawing.Size(140, 36);
      this.exitBtn.TabIndex = 17;
      this.exitBtn.Text = "Exit";
      this.exitBtn.UseVisualStyleBackColor = true;
      this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(486, 434);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(259, 20);
      this.label5.TabIndex = 15;
      this.label5.Text = "Total Program Fee (13% HST): ";
      // 
      // totalProgramCostTbx
      // 
      this.totalProgramCostTbx.Enabled = false;
      this.totalProgramCostTbx.Location = new System.Drawing.Point(751, 434);
      this.totalProgramCostTbx.Name = "totalProgramCostTbx";
      this.totalProgramCostTbx.Size = new System.Drawing.Size(140, 20);
      this.totalProgramCostTbx.TabIndex = 18;
      // 
      // studentDetailsComponent
      // 
      this.studentDetailsComponent.Location = new System.Drawing.Point(13, 13);
      this.studentDetailsComponent.Name = "studentDetailsComponent";
      this.studentDetailsComponent.Size = new System.Drawing.Size(331, 277);
      this.studentDetailsComponent.StudentAddress = "";
      this.studentDetailsComponent.StudentContact = "";
      this.studentDetailsComponent.StudentId = "";
      this.studentDetailsComponent.StudentName = "";
      this.studentDetailsComponent.TabIndex = 0;
      this.studentDetailsComponent.Load += new System.EventHandler(this.studentDetailsComponent_Load);
      // 
      // CourseRegistrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(901, 506);
      this.Controls.Add(this.totalProgramCostTbx);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.exitBtn);
      this.Controls.Add(this.registerBtn);
      this.Controls.Add(this.clearCourseSummaryBtn);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.studentDetailsComponent);
      this.Name = "CourseRegistrationForm";
      this.Text = "Student Registration System";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private StudentDetails studentDetailsComponent;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton ptDistanceRad;
    private System.Windows.Forms.RadioButton ptParttimeRad;
    private System.Windows.Forms.RadioButton ptFulltimeRad;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox programNameCbx;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox gamingCbx;
    private System.Windows.Forms.CheckBox healthCbx;
    private System.Windows.Forms.CheckBox gymMembershipCbx;
    private System.Windows.Forms.CheckBox activityClubCbx;
    private System.Windows.Forms.Button clearBtn;
    private System.Windows.Forms.Button addBtn;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button clearCourseSummaryBtn;
    private System.Windows.Forms.Button registerBtn;
    private System.Windows.Forms.Button exitBtn;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox totalProgramCostTbx;
    private System.Windows.Forms.TextBox courseSummaryTbx;
  }
}

