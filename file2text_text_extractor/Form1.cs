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
            this.Text = "File2text - Text Extractor";
            textBox1.Text = "Drag and drop a file here [.txt, .pdf, .png, .jpg] ...";
        }

        private string extractTextFromPdf(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while extracting text from the PDF: " + ex.Message);
            }

            return sb.ToString();
        }

        private string extractTextFromImage(string filePath)
        {
            string text = string.Empty;

            try
            {
                text = new IronOcr.IronTesseract().Read(filePath).Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while extracting text from the image: " + ex.Message);
            }

            return text;
        }


        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                string extension = System.IO.Path.GetExtension(file).ToLower(); ;

                this.Text = fileName;

                if (extension == ".txt")
                {
                    try
                    {
                        textBox1.Text = File.ReadAllText(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while reading the file: " + ex.Message);
                    }
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