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
            setupUI();
        }

        private void setupUI()
        {

            dropSnippet.AutoCompleteMode = AutoCompleteMode.Suggest;
            dropSnippet.AutoCompleteSource = AutoCompleteSource.ListItems;

            BindProperty(dropSection, sections);
            
        }

        private void buttonSection_Click(object sender, EventArgs e)
        {
            //moved to dropSection_SelectedIndexChanged
        }

        private void dropSnippet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropSnippet.Items.Count < 1) return;

            textSnippet.Text = "";
            string snippet = "";
            snippet = serializer.snippet(Content(dropSnippet));
            if (snippet.Length > 0)
            {
                textSnippet.Text = snippet;
                Clipboard.SetText(snippet);
            }
        }

        private void dropSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControls(new object[]{dropSection, dropSnippet, textSnippet}, false);

            dropSnippet.DataSource = null;
            dropSnippet.Items.Clear();
            textSnippet.Text = "";

            file = ReadText(files.GetValueOrDefault(Content(dropSection)));
            serializer = new Serializer(file);

            BindProperty(dropSnippet, serializer.keys());

            EnableControls(new object[] { dropSection, dropSnippet, textSnippet }, true);

        }
    }
}