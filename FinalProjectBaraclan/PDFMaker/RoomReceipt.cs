using FinalProjectBaraclan.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.PDFMaker
{
    public class RoomReceipt
    {
        public PdfDocument GetRoomInvoice(RoomHistory room, UserAccount user, double payment)
        {
            var document = new MigraDoc.DocumentObjectModel.Document();

            BuildRoomDocument(document,room, user,payment);

            var pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = document;

            pdfRenderer.RenderDocument();

            return pdfRenderer.PdfDocument;
        }


        public void BuildRoomDocument(Document document, RoomHistory room, UserAccount user, double payment)
        {
            Section section = document.AddSection();
            var paragraph = section.AddParagraph();

            paragraph.AddText("AcuHotel Shopping Services");
            paragraph.AddLineBreak();
            paragraph.AddText(DateTime.Now.ToString("MM-dd-yyyy"));
            paragraph.AddLineBreak();
            paragraph.AddText("Receipt Category:");
            paragraph.AddLineBreak();
            paragraph.AddText("ROOM");

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

            // Define columns
            table.AddColumn(Unit.FromCentimeter(2));  // Room Number
            table.AddColumn(Unit.FromCentimeter(6));  // Image (larger)
            table.AddColumn(Unit.FromCentimeter(2));  // Occupant
            table.AddColumn(Unit.FromCentimeter(2));  // Occupant Number
            table.AddColumn(Unit.FromCentimeter(2));  // Bed Style
            table.AddColumn(Unit.FromCentimeter(2));  // Room Style
            table.AddColumn(Unit.FromCentimeter(3));  // Date
            table.AddColumn(Unit.FromCentimeter(2));  // Price

            Row row = table.AddRow();

            row.Cells[0].AddParagraph(room.roomNumber.ToString());

            if (room.image != null && room.image.Length > 0)
            {
                string tempImagePath = Path.GetTempFileName();
                try
                {
                    File.WriteAllBytes(tempImagePath, room.image);

                    MigraDoc.DocumentObjectModel.Shapes.Image img = row.Cells[1].AddImage(tempImagePath);
                    img.Width = Unit.FromCentimeter(5.5);
                    img.Height = Unit.FromCentimeter(5.5);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding image: {ex.Message}");
                }
                finally
                {
                    try
                    {
                        if (File.Exists(tempImagePath))
                        {
                            File.Delete(tempImagePath);
                        }
                    }
                    catch { }
                }
            }
            else
            {
                row.Cells[1].AddParagraph("No image available");
            }

            row.Cells[2].AddParagraph(room.occupant.ToString());
            row.Cells[3].AddParagraph(room.occupantNumber.ToString());
            row.Cells[4].AddParagraph(room.bedStyle.ToString());
            row.Cells[5].AddParagraph(room.roomStyle.ToString());
            row.Cells[6].AddParagraph(room.date.ToString());
            row.Cells[7].AddParagraph(room.price.ToString());

            paragraph.Format.SpaceAfter = 20;

            paragraph.AddText("Room Price:");
            paragraph.AddLineBreak();
            paragraph.AddText(Convert.ToString(room.price));
            paragraph.AddLineBreak();
            paragraph.AddText("Payment:");
            paragraph.AddLineBreak();
            paragraph.AddText(Convert.ToString(payment));
            paragraph.AddText("Change:");
            paragraph.AddLineBreak();
            paragraph.AddText(Convert.ToString(payment-room.price));
        }
    }
}
