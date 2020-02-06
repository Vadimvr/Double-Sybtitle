using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Double_Sybtitle
{
    public interface ISubtitle
    {
        string Path {  set; }
        List<string> Content { get; }
    }
    class Subtitle: ISubtitle
    {
        List<string> content;

        public string Path { private get;set; }
        public List<string> Content
        {
            get { return content; }
            private set { content.AddRange(value); }
        }
        public Subtitle(string path)
        {
            Path = path;
            content = new List<string>();
            SubtitleToList();

        }
        void SubtitleToList()
        {
             StreamReader sr = File.OpenText(Path);
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == "/n" || (s.Length < 4 && s.DefaultIfEmpty().All(char.IsDigit)))
                        continue;
                    else
                    {
                        string temp = s.Length > 7 ? $"{s[0]}{s[1]}{s[3]}{s[4]}{s[6]}{s[7]}" : "dddd";

                        if (temp.DefaultIfEmpty().All(char.IsDigit))
                        {
                            Content.Add(s);
                            Content.Add("");
                        }
                        else
                            content[content.Count - 1] += "\n" + s;
                    }
                }
                Content.Add("99:99:99,999 --> 99:99:99,999");
                Content.Add("END");
            }
            sr.Close();
        }
    }
}
