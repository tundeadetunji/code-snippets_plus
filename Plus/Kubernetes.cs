using static iNovation.Code.General;
using static iNovation.Code.Desktop;
using static Plus.KB;
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
    public partial class Kubernetes : Form
    {
        public Kubernetes()
        {
            InitializeComponent();
        }

        private string file;
        private Serializer serializer;

        private void Kubernetes_Load(object sender, EventArgs e)
        {
            file = ReadText(kubernetes_file);

            serializer = new Serializer(file);
            setupUI();
        }

        private void setupUI()
        {
            BindProperty(dropSection, serializer.keys());

            dropSection.AutoCompleteMode = AutoCompleteMode.Suggest;
            dropSection.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void dropSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropSection.Items.Count < 1) return;
            textSnippet.Text = "";
            string snippet = "";
            snippet = serializer.snippet(Content(dropSection));
            if (snippet.Length > 0)
            {
                textSnippet.Text = snippet;
                Clipboard.SetText(snippet);
            }

        }
    }
}
