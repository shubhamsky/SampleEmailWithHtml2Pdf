using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using IronPdf;

class Program
{
    public static void Main()
    {
        // 1. HTML content
        string htmlContent = @"
            <html>
                <head><title>Test PDF</title></head>
                <body>
                    <h1>Hello from IronPDF!</h1>
                    <p>This PDF was generated from HTML.</p>
                </body>
            </html>";

        // 2. Convert HTML to PDF
        // Create a new instance of the ChromePdfRenderer class.
        // This class is used to render HTML content to a PDF file.

        var renderer = new ChromePdfRenderer();

        // Use the renderer to convert a simple HTML string into a PDF document.
        // The RenderHtmlAsPdf method takes an HTML string as an argument and renders it as a PDF.
        var pdfDocument = renderer.RenderHtmlAsPdf(htmlContent);
        // 2. Save the PDF to a memory stream (in-memory)
        MemoryStream pdfStream = new MemoryStream();
        try
        {
            
            pdfDocument.Stream.WriteTo(pdfStream);
            pdfStream.Position = 0; // Reset the stream position for reading


            // 4. Send Email with Attachment
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your_email@gmail.com", "gmail app password"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("your_email@gmail.com"),
                Subject = "HTML to PDF Test",
                Body = "Please find the attached PDF file.",
                IsBodyHtml = true,
            };
            mailMessage.To.Add("target_to_email@gmail.com");

            // Attach PDF
            var attachment = new Attachment(pdfStream, "document.pdf", "application/pdf");
            mailMessage.Attachments.Add(attachment);

            // Send
            smtpClient.Send(mailMessage);
            pdfStream.Dispose();
            Console.WriteLine("Email sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            pdfStream.Dispose();
        }
    }
}
