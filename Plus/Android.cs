using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Plus.KB;
using static iNovation.Code.General;
using static iNovation.Code.Desktop;

namespace Plus
{
    public partial class Android : Form
    {
        public Android()
        {
            InitializeComponent();
        }

        private string file;
        private Serializer serializer;

        private void Android_Load(object sender, EventArgs e)
        {
            file = ReadText(android_file);

            serializer = new Serializer(file);
            BindProperty(dropSection, serializer.keys());

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
