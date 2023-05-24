using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace FileInformation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void label2_DragDrop(object sender, DragEventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string[]? files = (string[]?)e.Data?.GetData(DataFormats.FileDrop, true);

            if (files != null && files.Count() > 0)
            {
                string file = files[0];

                FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(file);

                textBoxFilename.Text = Path.GetFileName(file);
                textBoxFilePath.Text = Path.GetDirectoryName(file);
                textBoxDescription.Text = fvi.FileDescription;

                textBoxInternalName.Text = fvi.InternalName;
                textBoxProductName.Text = fvi.ProductName;
                textBoxVersion.Text = fvi.ProductVersion;

                Byte[] byteArray = FileToByteArray(file);

                textBoxFileHash.Text = ComputeSha256Hash(byteArray);
            }

            Cursor = Cursors.Default;
        }

        static byte[] FileToByteArray(string fileName)
        {
            byte[] fileData = null;

            using (FileStream fs = File.OpenRead(fileName))
            {
                using (BinaryReader binaryReader = new BinaryReader(fs))
                {
                    fileData = binaryReader.ReadBytes((int)fs.Length);
                }
            }
            return fileData;
        }

        static string ComputeSha256Hash(byte[] rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(rawData);

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}