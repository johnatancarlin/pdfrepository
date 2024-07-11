using SkiaSharp;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.IO;

namespace PdfLibrary
{
    public class PdfProcessor
    {
        public PdfProcessor()
        {
            PdfDocument pdf = new PdfDocument();
            pdf.LoadFromFile("testdoc.pdf");
            Stream stream = pdf.SaveAsImage(0);
            SKBitmap bitmap = SKBitmap.Decode(stream);
            SKImage sKImage = SKImage.FromBitmap(bitmap);
            FileStream fileStream = File.OpenWrite("testdoc.jpg");
            sKImage.Encode(SKEncodedImageFormat.Jpeg, 100).SaveTo(fileStream);

        }
    }
}
