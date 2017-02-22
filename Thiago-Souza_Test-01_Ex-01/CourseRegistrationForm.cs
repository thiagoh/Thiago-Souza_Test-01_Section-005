using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thiago_Souza_Test_01_Ex_01 {
  public partial class CourseRegistrationForm : Form {

    private List<string> networkCourses = new List<string>();
    private List<string> mobileCourses = new List<string>();
    private List<string> softwareCourses = new List<string>();
    private List<string> selectedCourses = new List<string>();

    private static double COURSE_COST = 500.0;
    private static double CAMPUS_FACILITY_COST = 100.0;

    public CourseRegistrationForm() {
      InitializeComponent();

      studentDetailsComponent.updateStudentDetailsBtn.Click += UpdateStudentDetailsBtn_Click;

      updateCourseSummary();
      updateTotalProgramCost();

      networkCourses.AddRange(new string[]{
        "C Programming", "Network Fundamentals", "Routers", "Computer Networking", "Network Testing",
      });
      mobileCourses.AddRange(new string[]{
        "Java Programming", "IOS", "Android", "Mobile App", "SQL Lite",
      });
      softwareCourses.AddRange(new string[]{
        "C# Programming", "Database", "Testing", "Modelling", "Web Dev",
      });
    }

    private void UpdateStudentDetailsBtn_Click(object sender, EventArgs e) {
      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void updateCourseSummary() {

      if (selectedCourses.Count <= 0) {
        courseSummaryTbx.Text = "";
        return;
      }

      try {

        string summary = "";

        summary += "Student (#" + studentDetailsComponent.StudentId + "): " + studentDetailsComponent.StudentName;
        summary += " \r\nAddress:" + studentDetailsComponent.StudentAddress;
        summary += " Contact:" + studentDetailsComponent.StudentContact;

        summary += "\r\n\r\nCourses:";
        for (int i = 0; i < selectedCourses.Count; i++) {
          if (i > 0) {
            summary += ", ";
          }
          summary += selectedCourses[i];
        }

        summary += "\r\nFacilities:";

        if (activityClubCbx.Checked) {
          summary += "Activity Club ";
        }
        if (gymMembershipCbx.Checked) {
          summary += "Gym Memebership ";
        }
        if (healthCbx.Checked) {
          summary += "Health ";
        }
        if (gamingCbx.Checked) {
          summary += "Gaming Club";
        }

        courseSummaryTbx.Text = summary;

      } catch (Exception ex) {
        courseSummaryTbx.Text = ex.Message;
      }
    }

    private void updateTotalProgramCost() {

      double cost = 0;

      cost += selectedCourses.Count * COURSE_COST;

      if (activityClubCbx.Checked) {
        cost += CAMPUS_FACILITY_COST;
      }
      if (healthCbx.Checked) {
        cost += CAMPUS_FACILITY_COST;
      }
      if (gymMembershipCbx.Checked) {
        cost += CAMPUS_FACILITY_COST;
      }
      if (gamingCbx.Checked) {
        cost += CAMPUS_FACILITY_COST;
      }

      setTotalProgramCost(cost);
    }

    private void setTotalProgramCost(double cost) {

      cost = cost < 0.0 ? 0.0 : cost;
      cost = cost * 1.13;

      totalProgramCostTbx.Text = "$CAD " + Convert.ToString(Math.Round(cost, 2, MidpointRounding.AwayFromZero));
    }

    private void registerBtn_Click(object sender, EventArgs e) {

      if (programNameCbx.SelectedItem == null) {
        MessageBox.Show("No program selected! Please select a program!", "No program selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      var item = (programNameCbx.SelectedItem as string).Trim();

      MessageBox.Show("Thanks for Registering for the Program " + item, "You are registered to the program", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void exitBtn_Click(object sender, EventArgs e) {
      CourseRegistrationForm.ActiveForm.Close();
    }

    private void clearCourseSummaryBtn_Click(object sender, EventArgs e) {

      clearProgramDetails();
      selectedCourses.Clear();
      courseSummaryTbx.Text = "";

      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void clearProgramDetails() {
      programNameCbx.SelectedIndex = -1;

      listBox1.Items.Clear();

      ptFulltimeRad.Checked = false;
      ptParttimeRad.Checked = false;
      ptDistanceRad.Checked = false;

      activityClubCbx.Checked = false;
      gymMembershipCbx.Checked = false;
      healthCbx.Checked = false;
      gamingCbx.Checked = false;
    }

    private void clearBtn_Click(object sender, EventArgs e) {
      clearProgramDetails();
      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void addBtn_Click(object sender, EventArgs e) {

      selectedCourses.Clear();

      foreach (var item in listBox1.SelectedItems) {
        selectedCourses.Add(item as string);
      }

      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void studentDetailsComponent_Load(object sender, EventArgs e) {
      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void programNameCbx_SelectedIndexChanged(object sender, EventArgs e) {

      listBox1.Items.Clear();

      if (programNameCbx.SelectedItem == null) {
        return;
      }

      var item = (programNameCbx.SelectedItem as string).ToLower().Trim();

      if (item.Equals("network")) {
        listBox1.Items.AddRange(networkCourses.ToArray());
      } else if (item.Equals("software")) {
        listBox1.Items.AddRange(softwareCourses.ToArray());
      } else if (item.Equals("mobile")) {
        listBox1.Items.AddRange(mobileCourses.ToArray());
      }
    }

    private void gamingCbx_CheckedChanged(object sender, EventArgs e) {
      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void healthCbx_CheckedChanged(object sender, EventArgs e) {
      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void gymMembershipCbx_CheckedChanged(object sender, EventArgs e) {
      updateTotalProgramCost();
      updateCourseSummary();
    }

    private void activityClubCbx_CheckedChanged(object sender, EventArgs e) {
      updateTotalProgramCost();
      updateCourseSummary();
    }

  }
}
