using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;
using System.Threading;

namespace LocalizationTranslatorForUnity
{
    public partial class Form1 : Form
    {

        readonly List<Language> languages = new List<Language>();
        readonly Language Detectlanguage = new Language("Detect language", "auto");
        readonly Language Afrikaans = new Language("Afrikaans", "af");
        readonly Language Albanian = new Language("Albanian", "sq");
        readonly Language Amharic = new Language("Amharic", "am");
        readonly Language Arabic = new Language("Arabic", "ar");
        readonly Language Armenian = new Language("Armenian", "hy");
        readonly Language Azerbaijani = new Language("Azerbaijani", "az");
        readonly Language Basque = new Language("Basque", "eu");
        readonly Language Belarusian = new Language("Belarusian", "be");
        readonly Language Bengali = new Language("Bengali", "bn");
        readonly Language Bosnian = new Language("Bosnian", "bs");
        readonly Language Bulgarian = new Language("Bulgarian", "bg");
        readonly Language Catalan = new Language("Catalan", "ca");
        readonly Language Cebuano = new Language("Cebuano", "ceb");
        readonly Language Chichewa = new Language("Chichewa", "ny");
        readonly Language Chinese = new Language("Chinese", "zh-CN");
        readonly Language Corsican = new Language("Corsican", "co");
        readonly Language Croatian = new Language("Croatian", "hr");
        readonly Language Czech = new Language("Czech", "cs");
        readonly Language Danish = new Language("Danish", "da");
        readonly Language Dutch = new Language("Dutch", "nl");
        readonly Language English = new Language("English", "en");
        readonly Language Esperanto = new Language("Esperanto", "eo");
        readonly Language Estonian = new Language("Estonian", "et");
        readonly Language Filipino = new Language("Filipino", "tl");
        readonly Language Finnish = new Language("Finnish", "fi");
        readonly Language French = new Language("French", "fr");
        readonly Language Frisian = new Language("Frisian", "fy");
        readonly Language Galician = new Language("Galician", "gl");
        readonly Language Georgian = new Language("Georgian", "ka");
        readonly Language German = new Language("German", "de");
        readonly Language Greek = new Language("Greek", "el");
        readonly Language Gujarati = new Language("Gujarati", "gu");
        readonly Language HaitianCreole = new Language("Haitian Creole", "ht");
        readonly Language Hausa = new Language("Hausa", "ha");
        readonly Language Hawaiian = new Language("Hawaiian", "haw");
        readonly Language Hebrew = new Language("Hebrew", "iw");
        readonly Language Hindi = new Language("Hindi", "hi");
        readonly Language Hmong = new Language("Hmong", "hmn");
        readonly Language Hungarian = new Language("Hungarian", "hu");
        readonly Language Icelandic = new Language("Icelandic", "is");
        readonly Language Igbo = new Language("Igbo", "ig");
        readonly Language Indonesian = new Language("Indonesian", "id");
        readonly Language Irish = new Language("Irish", "ga");
        readonly Language Italian = new Language("Italian", "it");
        readonly Language Japanese = new Language("Japanese", "ja");
        readonly Language Javanese = new Language("Javanese", "jw");
        readonly Language Kannada = new Language("Kannada", "kn");
        readonly Language Kazakh = new Language("Kazakh", "kk");
        readonly Language Khmer = new Language("Khmer", "km");
        readonly Language Korean = new Language("Korean", "ko");
        readonly Language Kurdish = new Language("Kurdish", "ku");
        readonly Language Kyrgyz = new Language("Kyrgyz", "ky");
        readonly Language Lao = new Language("Lao", "lo");
        readonly Language Latin = new Language("Latin", "la");
        readonly Language Latvian = new Language("Latvian", "lv");
        readonly Language Lithuanian = new Language("Lithuanian", "lt");
        readonly Language Luxembourgish = new Language("Luxembourgish", "lb");
        readonly Language Macedonian = new Language("Macedonian", "mk");
        readonly Language Malagasy = new Language("Malagasy", "mg");
        readonly Language Malay = new Language("Malay", "ms");
        readonly Language Malayalam = new Language("Malayalam", "ml");
        readonly Language Maltese = new Language("Maltese", "mt");
        readonly Language Maori = new Language("Maori", "mi");
        readonly Language Marathi = new Language("Marathi", "mr");
        readonly Language Mongolian = new Language("Mongolian", "mn");
        readonly Language Myanmar = new Language("Myanmar", "my");
        readonly Language Nepali = new Language("Nepali", "ne");
        readonly Language Norwegian = new Language("Norwegian", "no");
        readonly Language Pashto = new Language("Pashto", "ps");
        readonly Language Persian = new Language("Persian", "fa");
        readonly Language Polish = new Language("Polish", "pl");
        readonly Language Portuguese = new Language("Portuguese", "pt");
        readonly Language Punjabi = new Language("Punjabi", "pa");
        readonly Language Romanian = new Language("Romanian", "ro");
        readonly Language Russian = new Language("Russian", "ru");
        readonly Language Samoan = new Language("Samoan", "sm");
        readonly Language ScotsGaelic = new Language("Scots Gaelic", "gd");
        readonly Language Serbian = new Language("Serbian", "sr");
        readonly Language Sesotho = new Language("Sesotho", "st");
        readonly Language Shona = new Language("Shona", "sn");
        readonly Language Sindhi = new Language("Sindhi", "sd");
        readonly Language Sinhala = new Language("Sinhala", "si");
        readonly Language Slovak = new Language("Slovak", "sk");
        readonly Language Slovenian = new Language("Slovenian", "sl");
        readonly Language Somali = new Language("Somali", "so");
        readonly Language Spanish = new Language("Spanish", "es");
        readonly Language Sundanese = new Language("Sundanese", "su");
        readonly Language Swahili = new Language("Swahili", "sw");
        readonly Language Swedish = new Language("Swedish", "sv");
        readonly Language Tajik = new Language("Tajik", "tg");
        readonly Language Tamil = new Language("Tamil", "ta");
        readonly Language Telugu = new Language("Telugu", "te");
        readonly Language Thai = new Language("Thai", "th");
        readonly Language Turkish = new Language("Turkish", "tr");
        readonly Language Ukrainian = new Language("Ukrainian", "uk");
        readonly Language Urdu = new Language("Urdu", "ur");
        readonly Language Uzbek = new Language("Uzbek", "uz");
        readonly Language Vietnamese = new Language("Vietnamese", "vi");
        readonly Language Welsh = new Language("Welsh", "cy");
        readonly Language Xhosa = new Language("Xhosa", "xh");
        readonly Language Yiddish = new Language("Yiddish", "yi");
        readonly Language Yoruba = new Language("Yoruba", "yo");
        readonly Language Zulu = new Language("Zulu", "zu");


        private bool connected, istranslating,webloaded,filedownloaded;
        WebBrowser webBrowser;
        public Form1()
        {
            InitializeComponent();
            languages.Add(Detectlanguage);
            languages.Add(Afrikaans);
            languages.Add(Albanian);
            languages.Add(Amharic);
            languages.Add(Arabic);
            languages.Add(Armenian);
            languages.Add(Azerbaijani);
            languages.Add(Basque);
            languages.Add(Belarusian);
            languages.Add(Bengali);
            languages.Add(Bosnian);
            languages.Add(Bulgarian);
            languages.Add(Catalan);
            languages.Add(Cebuano);
            languages.Add(Chichewa);
            languages.Add(Chinese);
            languages.Add(Corsican);
            languages.Add(Croatian);
            languages.Add(Czech);
            languages.Add(Danish);
            languages.Add(Dutch);
            languages.Add(English);
            languages.Add(Esperanto);
            languages.Add(Estonian);
            languages.Add(Filipino);
            languages.Add(Finnish);
            languages.Add(French);
            languages.Add(Frisian);
            languages.Add(Galician);
            languages.Add(Georgian);
            languages.Add(German);
            languages.Add(Greek);
            languages.Add(Gujarati);
            languages.Add(HaitianCreole);
            languages.Add(Hausa);
            languages.Add(Hawaiian);
            languages.Add(Hebrew);
            languages.Add(Hindi);
            languages.Add(Hmong);
            languages.Add(Hungarian);
            languages.Add(Icelandic);
            languages.Add(Igbo);
            languages.Add(Indonesian);
            languages.Add(Irish);
            languages.Add(Italian);
            languages.Add(Japanese);
            languages.Add(Javanese);
            languages.Add(Kannada);
            languages.Add(Kazakh);
            languages.Add(Khmer);
            languages.Add(Korean);
            languages.Add(Kurdish);
            languages.Add(Kyrgyz);
            languages.Add(Lao);
            languages.Add(Latin);
            languages.Add(Latvian);
            languages.Add(Lithuanian);
            languages.Add(Luxembourgish);
            languages.Add(Macedonian);
            languages.Add(Malagasy);
            languages.Add(Malay);
            languages.Add(Malayalam);
            languages.Add(Maltese);
            languages.Add(Maori);
            languages.Add(Marathi);
            languages.Add(Mongolian);
            languages.Add(Myanmar);
            languages.Add(Nepali);
            languages.Add(Norwegian);
            languages.Add(Pashto);
            languages.Add(Persian);
            languages.Add(Polish);
            languages.Add(Portuguese);
            languages.Add(Punjabi);
            languages.Add(Romanian);
            languages.Add(Russian);
            languages.Add(Samoan);
            languages.Add(ScotsGaelic);
            languages.Add(Serbian);
            languages.Add(Sesotho);
            languages.Add(Shona);
            languages.Add(Sindhi);
            languages.Add(Sinhala);
            languages.Add(Slovak);
            languages.Add(Slovenian);
            languages.Add(Somali);
            languages.Add(Spanish);
            languages.Add(Sundanese);
            languages.Add(Swahili);
            languages.Add(Swedish);
            languages.Add(Tajik);
            languages.Add(Tamil);
            languages.Add(Telugu);
            languages.Add(Thai);
            languages.Add(Turkish);
            languages.Add(Ukrainian);
            languages.Add(Urdu);
            languages.Add(Uzbek);
            languages.Add(Vietnamese);
            languages.Add(Welsh);
            languages.Add(Xhosa);
            languages.Add(Yiddish);
            languages.Add(Yoruba);
            languages.Add(Zulu);

            string[] languagesstrings = new string[languages.Count];
            for (int i = 0; i < languages.Count; i++)
            {
                languagesstrings[i] = languages[i].name;
            }
            comboBox1.Items.AddRange(languagesstrings.ToArray());
            comboBox2.Items.AddRange(languagesstrings.ToArray());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            connected = true;
            richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox3.MaxLength = 1;
        }
        public void EasyString()
        {
            List<string> languages = new List<string>();
            string willmodify = "new Language(auto, Detect language )                                  new Language(af, Afrikaans )                                  new Language(sq, Albanian )                                  new Language(am, Amharic )                                  new Language(ar, Arabic )                                  new Language(hy, Armenian )                                  new Language(az, Azerbaijani )                                  new Language(eu, Basque )                                  new Language(be, Belarusian )                                  new Language(bn, Bengali )                                  new Language(bs, Bosnian )                                  new Language(bg, Bulgarian )                                  new Language(ca, Catalan )                                  new Language(ceb, Cebuano )                                  new Language(ny, Chichewa )                                  new Language(zh-CN, Chinese )                                  new Language(co, Corsican )                                  new Language(hr, Croatian )                                  new Language(cs, Czech )                                  new Language(da, Danish )                                  new Language(nl, Dutch )                                  new Language(en, English )                                  new Language(eo, Esperanto )                                  new Language(et, Estonian )                                  new Language(tl, Filipino )                                  new Language(fi, Finnish )                                  new Language(fr, French )                                  new Language(fy, Frisian )                                  new Language(gl, Galician )                                  new Language(ka, Georgian )                                  new Language(de, German )                                  new Language(el, Greek )                                  new Language(gu, Gujarati )                                  new Language(ht, Haitian Creole )                                  new Language(ha, Hausa )                                  new Language(haw, Hawaiian )                                  new Language(iw, Hebrew )                                  new Language(hi, Hindi )                                  new Language(hmn, Hmong )                                  new Language(hu, Hungarian )                                  new Language(is, Icelandic )                                  new Language(ig, Igbo )                                  new Language(id, Indonesian )                                  new Language(ga, Irish )                                  new Language(it, Italian )                                  new Language(ja, Japanese )                                  new Language(jw, Javanese )                                  new Language(kn, Kannada )                                  new Language(kk, Kazakh )                                  new Language(km, Khmer )                                  new Language(ko, Korean )                                  new Language(ku, Kurdish )                                  new Language(ky, Kyrgyz )                                  new Language(lo, Lao )                                  new Language(la, Latin )                                  new Language(lv, Latvian )                                  new Language(lt, Lithuanian )                                  new Language(lb, Luxembourgish )                                  new Language(mk, Macedonian )                                  new Language(mg, Malagasy )                                  new Language(ms, Malay )                                  new Language(ml, Malayalam )                                  new Language(mt, Maltese )                                  new Language(mi, Maori )                                  new Language(mr, Marathi )                                  new Language(mn, Mongolian )                                  new Language(my, Myanmar )                                  new Language(ne, Nepali )                                  new Language(no, Norwegian )                                  new Language(ps, Pashto )                                  new Language(fa, Persian )                                  new Language(pl, Polish )                                  new Language(pt, Portuguese )                                  new Language(pa, Punjabi )                                  new Language(ro, Romanian )                                  new Language(ru, Russian )                                  new Language(sm, Samoan )                                  new Language(gd, Scots Gaelic )                                  new Language(sr, Serbian )                                  new Language(st, Sesotho )                                  new Language(sn, Shona )                                  new Language(sd, Sindhi )                                  new Language(si, Sinhala )                                  new Language(sk, Slovak )                                  new Language(sl, Slovenian )                                  new Language(so, Somali )                                  new Language(es, Spanish )                                  new Language(su, Sundanese )                                  new Language(sw, Swahili )                                  new Language(sv, Swedish )                                  new Language(tg, Tajik )                                  new Language(ta, Tamil )                                  new Language(te, Telugu )                                  new Language(th, Thai )                                  new Language(tr, Turkish )                                  new Language(uk, Ukrainian )                                  new Language(ur, Urdu )                                  new Language(uz, Uzbek )                                  new Language(vi, Vietnamese )                                  new Language(cy, Welsh )                                  new Language(xh, Xhosa )                                  new Language(yi, Yiddish )                                  new Language(yo, Yoruba )                                  new Language(zu, Zulu ) ";
            int startindex = 0;
            int midcutindex = 0;
            int endindex = 0;
            for (int i = 0; i < willmodify.Length; i++)
            {
                if (willmodify[i] == '(')
                {
                    startindex = i;
                }
                if (willmodify[i] == ',')
                {
                    midcutindex = i;
                }
                if (willmodify[i] == ')')
                {
                    endindex = i;
                    Debug.WriteLine("readonly Language " + willmodify.Substring(midcutindex + 2, endindex - midcutindex - 3) + "=new Language(" + '"' + willmodify.Substring(midcutindex + 2, endindex - midcutindex - 3) + '"' + "," + '"' + willmodify.Substring(startindex + 1, midcutindex - startindex - 1) + '"' + ");");
                    languages.Add(willmodify.Substring(midcutindex + 2, endindex - midcutindex - 3));
                }
            }
            for (int j = 0; j < languages.Count; j++)
            {
                Debug.WriteLine("languages.Add(" + languages[j] + ");");
            }
        }

        string TranslateTextAsync(string input)
        {
            Thread.Sleep(500);
            // Set the language from/to in the url (or pass it into this function)
            HttpClient httpClient = new HttpClient();
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             languages[comboBox1.SelectedIndex].code, languages[comboBox2.SelectedIndex].code, Uri.EscapeUriString(input));
            string result = httpClient.GetStringAsync(url).Result;

            // Get all json data
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

            // Extract just the first array element (This is the only data we are interested in)
            var translationItems = jsonData[0];

            // Translation Data
            string translation = "";

            // Loop through the collection extracting the translated objects
            foreach (object item in translationItems)
            {
                // Convert the item array to IEnumerable
                IEnumerable translationLineObject = item as IEnumerable;

                // Convert the IEnumerable translationLineObject to a IEnumerator
                IEnumerator translationLineString = translationLineObject.GetEnumerator();

                // Get first object in IEnumerator
                translationLineString.MoveNext();

                // Save its value (translated text)
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            // Remove first blank character
            if (translation.Length > 1) { translation = translation.Substring(1); };

            // Return translation
            httpClient.Dispose();
            return translation;
        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public  bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            connected = CheckForInternetConnection();
            //EasyString();
            if (connected)
            {
                istranslating = false;
                if (richTextBox2.Text.Length > 0)
                {
                    if (richTextBox3.Text.Length > 0 && richTextBox3.Text[0] != ' ')
                    {
                        char controllingchar = richTextBox3.Text[0];
                        String main = richTextBox2.Text;
                        string modified = "";

                        bool start = true;
                        int startindex = 5000, endindex = 5000;

                        for (int i = 0; i < main.Length; i++)
                        {
                            if (main[i] == controllingchar)
                            {
                                if (start)
                                {
                                    startindex = i;
                                    istranslating = true;
                                }
                                else
                                {
                                    endindex = i;
                                    istranslating = false;
                                    modified += controllingchar+TranslateTextAsync(main.Substring(startindex+1, endindex - startindex-1)) + controllingchar;


                                }

                                start = !start;
                            }
                            else
                            {
                                if (!istranslating)
                                    modified += main[i];
                            }
                        }
                        richTextBox1.Text = modified;
                    }
                    else
                        richTextBox1.Text = TranslateTextAsync(richTextBox2.Text);
                }
            }
        }

    }
    public class Language
    {
        public string name = "";
        public string code = "";
        public Language(string inputname, string inputcode)
        {
            name = inputname;
            code = inputcode;
        }

    }
}
