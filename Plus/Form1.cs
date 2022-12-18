using static iNovation.Code.General;
using static iNovation.Code.Desktop;
using static Plus.KB;
namespace Plus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string file;
        private Serializer serializer;

        private void Form1_Load(object sender, EventArgs e)
        {
            file = ReadText(gcp_file);

            serializer = new Serializer(file);
            BindProperty(dropSection, serializer.keys());
        }

        private void dropSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropSection.Items.Count < 1) return;
            textSnippet.Text = "";
            string snippet = "";
            snippet = serializer.snippet(Content(dropSection));
            if (snippet.Length > 0){
                textSnippet.Text = snippet;
                Clipboard.SetText(snippet);
            }
        }
    }
}