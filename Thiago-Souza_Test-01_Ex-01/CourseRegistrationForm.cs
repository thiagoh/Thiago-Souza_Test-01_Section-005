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

    private static double COURSE_COST = 500.0;
    private static double CAMPUS_FACILITY_COST = 100.0;

    public CourseRegistrationForm() {
      InitializeComponent();

      courseSummaryTbx.Text = "";
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

    private void updateTotalProgramCost() {


    }

    private void setTotalProgramCost(double cost) {

      cost = cost < 0.0 ? 0.0 : cost;
      cost = cost * 1.13;

      totalProgramCostTbx.Text = "$CAD " + Convert.ToString(Math.Round(cost, 2, MidpointRounding.AwayFromZero));
    }

    private void registerBtn_Click(object sender, EventArgs e) {
      updateTotalProgramCost();
    }

    private void exitBtn_Click(object sender, EventArgs e) {

    }

    private void clearCourseSummaryBtn_Click(object sender, EventArgs e) {

      programNameCbx.SelectedIndex = -1;

      ptFulltimeRad.Checked = false;
      ptParttimeRad.Checked = false;
      ptDistanceRad.Checked = false;

      activityClubCbx.Checked = false;
      gymMembershipCbx.Checked = false;
      healthCbx.Checked = false;
      gamingCbx.Checked = false;
    }

    private void clearBtn_Click(object sender, EventArgs e) {
      updateTotalProgramCost();
    }

    private void addBtn_Click(object sender, EventArgs e) {
      updateTotalProgramCost();
    }

    private void studentDetailsComponent_Load(object sender, EventArgs e) {

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
    }

    private void healthCbx_CheckedChanged(object sender, EventArgs e) {
      updateTotalProgramCost();
    }

    private void gymMembershipCbx_CheckedChanged(object sender, EventArgs e) {
      updateTotalProgramCost();
    }

    private void activityClubCbx_CheckedChanged(object sender, EventArgs e) {
      updateTotalProgramCost();
    }

  }
}
