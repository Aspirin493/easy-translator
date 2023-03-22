using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Google.Cloud.Translate.V3;
using System.Collections.Generic;
using Google.Api.Gax.ResourceNames;

namespace easy_translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string yandex_api_key = "yourkey";
        string google_project_id = "yourprojectid";

        enum translators
        {
            YANDEX,
            GOOGLE
        }

        translators current_translator;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            gunaSeparator1.Visible = true;
            gunaSeparator2.Visible = !gunaSeparator1.Visible;
            current_translator = translators.YANDEX;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            gunaSeparator2.Visible = true;
            gunaSeparator1.Visible = !gunaSeparator2.Visible;
            current_translator = translators.GOOGLE;
        }

        protected private static string lang = "en-ru"; // lang

        private async void translateBtn_Click(object sender, EventArgs e)
        {
            switch (current_translator)
            {
                case translators.YANDEX:
                    translateYandex(textbox.Text, lang);
                    break;
                case translators.GOOGLE:
                    translateGoogle(textbox.Text, lang);
                    break;
            }
        }

        async void translateYandex(string text, string targetLanguageCode)
        {
            try
            {
                string url = string.Format("https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}", yandex_api_key, HttpUtility.UrlEncode(text), targetLanguageCode);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

                string json;
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    json = reader.ReadToEnd();
                }

                TranslationResult result = Newtonsoft.Json.JsonConvert.DeserializeObject<TranslationResult>(json);

                textbox.Text = result.text[0];
            }
            catch
            {
                Console.WriteLine($"yandex translate error\napi_key:{yandex_api_key}\nmessage:{text}\nlan:{targetLanguageCode};");
            }
        }
        async void translateGoogle(string text, string targetLanguageCode)
        {
            try
            {
                TranslationServiceClient client = TranslationServiceClient.Create();

                TranslateTextRequest request = new TranslateTextRequest
                {
                    Contents = { text },
                    TargetLanguageCode = targetLanguageCode,
                    Parent = new ProjectName(google_project_id).ToString()
                };

                TranslateTextResponse response = await client.TranslateTextAsync(request);

                textbox.Text = response.Translations[0].TranslatedText;
            }
            catch
            {
                Console.WriteLine($"google translate error\napi_key:{google_project_id}\nmessage:{text}\nlan:{targetLanguageCode};");
            }
        }
        class TranslationResult
        {
            public string code { get; set; }
            public string lang { get; set; }
            public string[] text { get; set; }
        }
    }
}
