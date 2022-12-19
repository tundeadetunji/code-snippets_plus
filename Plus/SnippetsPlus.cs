using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plus
{
    public partial class SnippetsPlus : Form
    {
        public SnippetsPlus()
        {
            InitializeComponent();
        }

        private void buttonGCP_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Form1")
                    counter += 1;
            }
            iNovation.Code.Feedback f = new iNovation.Code.Feedback();
            if (counter < 1){
                f.say("Opening GCP section");
            }
            Form1 gcp = new Form1();
            gcp.Show();
            gcp.Focus();
        }

        private void buttonAndroid_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Android")
                    counter += 1;
            }
            iNovation.Code.Feedback f = new iNovation.Code.Feedback();
            if (counter < 1)
            {
                f.say("Opening Android section");
            }
            Android android = new Android();
            android.Show();
            android.Focus();
        }

        private void buttonKubernetes_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Kubernetes")
                    counter += 1;
            }
            iNovation.Code.Feedback f = new iNovation.Code.Feedback();
            if (counter < 1)
            {
                f.say("Opening Kubernetes section");
            }
            Kubernetes kubernetes = new Kubernetes();
            kubernetes.Show();
            kubernetes.Focus();

        }
    }
}
