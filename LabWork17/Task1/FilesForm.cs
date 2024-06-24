namespace Task1
{
    public partial class FilesForm : Form
    {

        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles("*", SearchOption.AllDirectories);

        }

        public FilesForm()
        {
            InitializeComponent();

            var files = GetFiles("C:\\temp\\ispp-21");

            var result = files
                .Select(file => new { file.FullName, file.DirectoryName, file.Length, file.CreationTime })
                .OrderBy(file => file.FullName)
                .ThenByDescending(f => f.CreationTime);

            filesDataGridView.DataSource = result.ToList();
        }

        private void ButtonTask2_Click(object sender, EventArgs e)
        {
            var files = GetFiles("C:\\temp\\ispp-21");

            var result = files
                .Select(file => new { file.Extension })
                .Distinct();

            filesDataGridView.DataSource = result.ToList();
        }

        private void ButtonTask3_Click(object sender, EventArgs e)
        {
            var files = GetFiles("C:\\temp\\ispp-21");

            var result = files
                .GroupBy(file => new { file.Extension })
                .Select(group => new
                {
                    group.Key.Extension,
                    Count = group.Count()
                });

            filesDataGridView.DataSource = result.ToList();
        }
    }
}
