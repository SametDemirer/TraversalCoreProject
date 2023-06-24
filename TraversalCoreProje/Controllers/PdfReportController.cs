using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();

            return File("/PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya3.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.AddCell("Misafir Adı");
            pdfTable.AddCell("Misafir Soyadı");
            pdfTable.AddCell("Misafir Tc");

            pdfTable.AddCell("Samet");
            pdfTable.AddCell("Demirer");
            pdfTable.AddCell("11451634105");

            pdfTable.AddCell("Hafsa");
            pdfTable.AddCell("Demirer");
            pdfTable.AddCell("125645184");

            pdfTable.AddCell("Ahmet");
            pdfTable.AddCell("Yılmaz");
            pdfTable.AddCell("11451634105");

            document.Add(pdfTable);

            document.Close();

            return File("/PdfReports/dosya3.pdf", "application/pdf", "dosya3.pdf");
        }

    }
}
