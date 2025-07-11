# HTML to PDF Emailer using IronPDF (.NET Console App)

This console application converts a given HTML string to a PDF file using [IronPDF](https://ironpdf.com/) and sends it as an email attachment via SMTP.

---

## 📌 Features

- ✅ Convert dynamic HTML content to PDF using IronPDF  
- ✅ Save the PDF in-memory (no temporary disk writes)  
- ✅ Email the generated PDF as an attachment using SMTP  
- ✅ Supports HTML formatting, images, styles, etc.

---

## 🛠️ Tech Stack

- .NET 6/7/8 (compatible with .NET Core or .NET Framework)  
- IronPDF (via NuGet)  
- System.Net.Mail for email  
- Console app (can be adapted to ASP.NET easily)

---

## 🚀 Setup Instructions

### 1. Clone or download the repository

```bash
git clone https://github.com/shubhamsky/SampleEmailWithHtml2Pdf.git
cd html-to-pdf-emailer

```


### 2. Install IronPDF via NuGet

```bash
Install-Package IronPdf
```

Or edit your `.csproj`:

```xml
<PackageReference Include="IronPdf" Version="2025.x.x" />
```

> 💡 **Note:** IronPDF is commercial software but offers a free trial.

---

## ✉️ Email Configuration

Update the following with your actual email credentials:

```csharp
new NetworkCredential("your_email@gmail.com", "your_app_password")
smtpClient.Host = "smtp.gmail.com"
smtpClient.Port = 587
```

> 🔐 Use an [App Password](https://support.google.com/accounts/answer/185833?hl=en) if using Gmail and 2FA is enabled.

---

## 📄 Sample HTML Used

```html
<html>
  <body>
    <h1>Hello from IronPDF!</h1>
    <p>This PDF was generated from HTML.</p>
  </body>
</html>
```

---

## 🧪 How to Run

```bash
dotnet run
```

If successful, you should see:  
`Email sent successfully.`

---

## ✅ Best Practices

- Use `MemoryStream` to avoid temporary file creation  
- Secure SMTP credentials using environment variables or secrets  
- Validate the recipient email before sending  
- Handle exceptions for SMTP and PDF generation failures

---

## 📂 Output

The PDF is generated in memory and **not saved to disk**. You can easily modify the code to save locally:

```csharp
pdf.SaveAs("output.pdf");
```

---

## 📃 License

This app uses [IronPDF](https://ironpdf.com/) which is **commercial**. Free and paid licenses are available on their website.

---

## 🙋‍♂️ Questions?

Feel free to open an issue or email `skychakkra@gmail.com`.
```xml
<PackageReference Include="IronPdf" Version="2025.x.x" />
```

> 💡 **Note:** IronPDF is commercial softw
