using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace WenxingFlash
{
    struct RecognizeResult
    {
        public string Value;
        public float Confidence;
    }
    class CaptchaRecognizer
    {
        public static async Task<RecognizeResult> RecoginzeAsync(Bitmap captcha)
        {
            return await Task.Run(() => RecoginzeText(Preprocess(captcha)));
        }

        public static Bitmap Preprocess(Bitmap input)
        {
            Bitmap image = new Bitmap(input);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color c = image.GetPixel(x, y);
                    if (c == Color.FromArgb(0xFF, 41, 163, 238))
                    {
                        c = Color.Black;
                    }
                    else
                    {
                        c = Color.White;
                    }
                    image.SetPixel(x, y, c);
                }
            }
            return image;
        }

        public static RecognizeResult RecoginzeText(Bitmap input)
        {
            using (var engine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "1234567890abcdefghijklmnopqrstuvwxyz");
                using (var page = engine.Process(input))
                {
                    return new RecognizeResult() { Value = page.GetText().Trim(), Confidence = page.GetMeanConfidence() };
                }
            }
        }
    }
}
