# File2Text - Text Extractor

This C# application allows you to extract text from various file formats, including .txt, .pdf, .png, and .jpg files. Simply drag and drop the supported file onto the application, and it will display the extracted text in a text box.

## Requirements

- .NET Framework (version X.X or later)

## Getting Started

1. Clone the repository or download the source code.
2. Open the solution file (`file2text_text_extractor.sln`) in Visual Studio.
3. Build the solution to ensure all dependencies are resolved.

## Usage

1. Launch the application.
2. The main window will display a text box with the initial message: "Drag a .txt, .pdf, .png, or .jpg file here..."
3. Drag and drop a supported file (e.g., .txt, .pdf, .png, or .jpg) onto the text box.
4. The application will extract the text from the file and display it in the text box.

## Supported File Formats

- .txt: The content of the .txt file will be displayed as is.
- .pdf: The application uses iTextSharp library to extract text from PDF files.
- .png and .jpg: The application utilizes IronOcr library to extract text from images.

## Contributing

Contributions are welcome! If you find any issues or have ideas for improvements, please feel free to open an issue or submit a pull request.
  
## License

This project is licensed under the Apache License - see the [LICENSE](LICENSE) file for details.

<a href="https://www.buymeacoffee.com/ascensao1" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-yellow.png" alt="Buy Me A Coffee" height="41" width="174"></a>