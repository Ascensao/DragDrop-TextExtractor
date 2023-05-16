# C# File-to-Text Converter App

This C# application allows you to extract text from various file formats, including .txt, .pdf, .png, and .jpg files. Simply drag and drop the supported file onto the application, and it will display the extracted text in a text box.

## Buy me a coffe
Whether you use this project, have learned something from it, or just like it, please consider supporting it by buying me a coffee, so I can dedicate more time on open-source projects like this :)

<a href="https://www.buymeacoffee.com/ascensao1" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-yellow.png" alt="Buy Me A Coffee" height="41" width="174"></a>

## Requirements

- .NET Framework (version X.X or later)

## Getting Started

1. Clone the repository or download the source code.
2. Open the solution file (`c_sharp_file2text.sln`) in Visual Studio.
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
  
## Author

Bernardo Ascensao

## License

This project is licensed under the MIT License - see the LICENSE file for details.
