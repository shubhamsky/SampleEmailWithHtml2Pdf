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

> 💡 **Note:** IronPDF is commercial softw
