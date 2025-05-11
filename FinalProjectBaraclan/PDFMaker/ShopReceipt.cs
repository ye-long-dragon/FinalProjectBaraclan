using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using MigraDoc.DocumentObjectModel;
using Document = MigraDoc.DocumentObjectModel.Document;
using System.Data;
using FinalProjectBaraclan.Models;
using MigraDoc.DocumentObjectModel.Tables;

namespace FinalProjectBaraclan.PDFMaker
{
    public class ShopReceipt
    {

        public PdfDocument GetShopInvoice(DataTable data, UserAccount user, double payment)
        {
            var document = new MigraDoc.DocumentObjectModel.Document();

            BuildShopDocument(document, data, user, payment);

            var pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = document;

            pdfRenderer.RenderDocument();

            return pdfRenderer.PdfDocument;
        }

        public void BuildShopDocument(Document document, DataTable data, UserAccount user, double payment)
        {
            Section section = document.AddSection();
            var paragraph = section.AddParagraph();

            paragraph.AddText("AcuHotel Shopping Services");
            paragraph.AddLineBreak();
            paragraph.AddText(DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Year.ToString());
            paragraph.AddLineBreak();
            paragraph.AddText("Receipt Category:");
            paragraph.AddLineBreak();
            paragraph.AddText("SHOP");

            paragraph.Format.SpaceAfter = 20;

            paragraph = section.AddParagraph();
            paragraph.AddText("BILLED TO:");
            paragraph.AddLineBreak();
            paragraph.AddText(user.username);
            paragraph.AddLineBreak();
            paragraph.AddText("User ID:");
            paragraph.AddLineBreak();
            paragraph.AddText(user.finalId);

            paragraph.Format.SpaceAfter = 20;

            Table table = section.AddTable();
            table.Borders.Width = 0.75;

            // Add columns
            foreach (DataColumn column in data.Columns)
            {
                table.AddColumn();
            }

            // Add header row
            Row headerRow = table.AddRow();
            for (int i = 0; i < data.Columns.Count; i++)
            {
                headerRow.Cells[i].AddParagraph(data.Columns[i].ColumnName);
            }

            // Add data rows
            foreach (DataRow dataRow in data.Rows)
            {
                Row row = table.AddRow();
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    row.Cells[i].AddParagraph(dataRow[i].ToString());
                }
            }

            decimal pay = Convert.ToDecimal(payment);
            // Calculate total price from DataTable
            decimal totalPrice = 0;
            foreach (DataRow row in data.Rows)
            {
                totalPrice += Convert.ToDecimal(row["Price"]); // Assuming price column is named "Price"
            }

            paragraph.Format.SpaceAfter = 20;

            decimal change = pay - totalPrice;

            paragraph = section.AddParagraph();
            paragraph.AddText("TOTAL PRICE: " + totalPrice.ToString("0.00"));
            paragraph.AddLineBreak();
            paragraph.AddText("PAYMENT: " + payment.ToString("0.00"));
            paragraph.AddLineBreak();
            paragraph.AddText("CHANGE: " + change.ToString("0.00"));






        }
    }
}
