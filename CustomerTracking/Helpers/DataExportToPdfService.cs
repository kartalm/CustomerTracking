using CustomerTracking.NonRelationalEntities;
using CustomerTracking.Services;
using NLog;
using System;
using CustomerTracking.ViewModels;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Reflection;
using System.IO;

namespace CustomerTracking.Helpers
{
    public class DataExportToPdfService : IDataExportService
    {
        private readonly Logger _logger;

        public DataExportToPdfService()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ServiceResponse ExportData(CustomerViewModel customer)
        {
            var response = new ServiceResponse();
            
            var pdf = new PdfDocument();

            PdfPage pdfPage = pdf.AddPage();

            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            XFont font = new XFont("Verdana", 12, XFontStyle.Bold);

            Image logo = Image.FromFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Content\logo.png");

            graph.DrawImage(logo, 5, 5);

            graph.DrawString("Müşteri Adı Soyadı : " + customer.CustomerNameSurname, font, XBrushes.Black, new XRect(5, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Müşteri Telefon Numarası : " + customer.CustomerPhoneNumber, font, XBrushes.Black, new XRect(5, 165, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Araç Markası : " + customer.VehicleBrand, font, XBrushes.Black, new XRect(5, 180, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Araç Plakası : " + customer.VehicleNumberPlate, font, XBrushes.Black, new XRect(5, 195, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Ustanın Adı Soyadı : " + customer.StaffNameSurname, font, XBrushes.Black, new XRect(5, 210, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            if (customer.ReparationOperation.Length > 40)
            { 
                graph.DrawString("Yapılan İşlem : ", font, XBrushes.Black, new XRect(5, 225, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                List<string> paragraph = Enumerable.Range(0, customer.ReparationOperation.Length / 40).Select(y => customer.ReparationOperation.Substring(y * 40, 40)).OfType<string>().ToList();
                 
                for (var i = 0; i < paragraph.Count; i++)
                {
                    graph.DrawString(paragraph[i], font, XBrushes.Black, new XRect(15, 230 + (10 * (i+1)), pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                }
            }
            else
            {
                graph.DrawString("Yapılan İşlem : " + customer.ReparationOperation, font, XBrushes.Black, new XRect(5, 225, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            }
             
            var sfd = new SaveFileDialog();
            sfd.Filter = "PDF Dosyası|*.pdf";
            sfd.OverwritePrompt = true;
            sfd.CreatePrompt = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pdf.Save(sfd.FileName);

                }
                catch (Exception ex)
                {
                    response.AppException = new AppException("Pdf dosyasına dönüştürme işlemi sırasında hata oluştu. " + ex, ex);
                }
            }
            
            return response;

        }

    }
}
