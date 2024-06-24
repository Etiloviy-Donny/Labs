using Word = Microsoft.Office.Interop.Word;

namespace PractWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void taskCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var app = new Word.Application();
            app.Visible = true;
            var document = app.Documents.Add(Path.Combine(Environment.CurrentDirectory, "״אבכמם.docx"));

            document.Content.Find.Execute(FindText: "ׂוךסעָחֿמכÿֲגמהא", ReplaceWith: inputTextBox.Text, Replace: Word.WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "הה.לל.דדדד קק:לל", ReplaceWith: DateTime.Now.ToString(), Replace: Word.WdReplace.wdReplaceAll);

            int rows = Convert.ToInt32(taskCountTextBox.Text);
            for (int i = 1; i < rows - 1; i++)
            {
                document.Tables[1].Rows.Add(document.Tables[1].Rows[i + 2]);
            }
        }
    }
}
