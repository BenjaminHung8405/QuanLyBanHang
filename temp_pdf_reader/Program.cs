using System;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"c:\Study\QuanLyBanHang\PDF\IMS501_HuongDanThucHanh_Buoi07.pdf";
        using (PdfDocument pdfDoc = new PdfDocument(new PdfReader(filePath)))
        {
            for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
            {
                var page = pdfDoc.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page);
                Console.WriteLine($"Page {i}:\n{text}\n");
            }
        }
    }
}
