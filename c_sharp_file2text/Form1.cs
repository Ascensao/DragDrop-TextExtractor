using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using IronOcr;


namespace c_sharp_file2text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Drag a .txt, .pdf, .png, or .jpg file here...";
        }

        private string extractTextFromPdf(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int pageNo = 1; pageNo <= reader.NumberOfPages; pageNo++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text = PdfTextExtractor.GetTextFromPage(reader, pageNo, strategy);
                    text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                    sb.AppendLine(text);
                }
            }

            return sb.ToString();
        }

        private string extractTextFromImage(string filePath)
        {
            return new IronOcr.IronTesseract().Read(filePath).Text;
        }


        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                string extension = System.IO.Path.GetExtension(file);

                if (extension == ".txt")
                {
                    textBox1.Text = File.ReadAllText(file);
                }
                else if (extension == ".pdf")
                {
                    textBox1.Text = extractTextFromPdf(file);
                }
                else if (extension == ".png" || extension == ".jpg")
                {
                    textBox1.Text = extractTextFromImage(file);
                }
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}