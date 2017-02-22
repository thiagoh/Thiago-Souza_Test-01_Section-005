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

    private static double COURSE_VALUE = 500.0;

    public CourseRegistrationForm() {
      InitializeComponent();

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

    private void clarCourseSummaryBtn_Click(object sender, EventArgs e) {

    }

    private void registerBtn_Click(object sender, EventArgs e) {

    }

    private void exitBtn_Click(object sender, EventArgs e) {

    }

    private void clearBtn_Click(object sender, EventArgs e) {

    }

    private void addBtn_Click(object sender, EventArgs e) {

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
  }
}
