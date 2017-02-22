using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thiago_Souza_Test_01_Ex_01 {
  public partial class StudentDetails : UserControl {

    public string StudentId {
      get {
        return studentIdTbx.Text;
      }
      set {
        studentIdTbx.Text = value;
      }
    }

    public string StudentName {
      get {
        return nameTbx.Text;
      }
      set {
        nameTbx.Text = value;
      }
    }

    public string StudentAddress {
      get {
        return addressTbx.Text;
      }
      set {
        addressTbx.Text = value;
      }
    }

    public string StudentContact {
      get {
        return contactTbx.Text;
      }
      set {
        contactTbx.Text = value;
      }
    }


    public StudentDetails() {
      InitializeComponent();
    }

    private void updateStudentDetailsBtn_Click(object sender, EventArgs e) {
      MessageBox.Show("working!");
    }
  }
}
