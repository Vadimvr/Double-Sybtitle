using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Double_Sybtitle
{
    public interface IDoubleSubtitle
    {
        void SeveFile();
    }
    class DoubleSubtitle:IDoubleSubtitle
    {
        List<string> content = new List<string>();
        string endText = "</ font >";
        
        
        string LightAndFontSize1 { get; set; }
        string LightAndFontSize2 { get; set; }
        public string Path { get; private set; }

        public DoubleSubtitle(ISubtitle firstSubtitle, ISubtitle secondSubtitle, string path, string size1 = "40", string color1 = "#ffffff", string size2 = "40", string color2 = "00ff00")
        {
            LightAndFontSize1 = $"< font color=\"{color1}\" size={size1}>";
            LightAndFontSize2 = $"< font color=\"{color2}\" size={size2}>";
            Path = path;
            CreateDoubleSubtitle(firstSubtitle, secondSubtitle);


        }
        void CreateDoubleSubtitle(ISubtitle firstSubtitle, ISubtitle secondSubtitle)
        {
            int i = 0;
            while (firstSubtitle.Content.Count > 1 || secondSubtitle.Content.Count > 1)
            {
                content.Add(i++.ToString());
                int x = firstSubtitle.Content[0].Substring(0, 8).CompareTo(secondSubtitle.Content[0].Substring(0, 8));

                if ((firstSubtitle.Content.Count > 1 && secondSubtitle.Content.Count > 1) && x == 0)
                {
                    //add timeline
                    content.Add(firstSubtitle.Content[0]);

                    //delete time line
                    firstSubtitle.Content.RemoveAt(0);
                    secondSubtitle.Content.RemoveAt(0);

                    //add text line
                    content.Add(LightAndFontSize1 + firstSubtitle.Content[0] + endText);
                    content.Add(LightAndFontSize2 + secondSubtitle.Content[0] + endText);

                    //delate text line
                    firstSubtitle.Content.RemoveAt(0);
                    secondSubtitle.Content.RemoveAt(0);
                }
                else if ((firstSubtitle.Content.Count > 1 && secondSubtitle.Content.Count > 1) && x == 1)
                {
                    //add time line and delete time line
                    content.Add(secondSubtitle.Content[0]);
                    secondSubtitle.Content.RemoveAt(0);

                    //add text line and delete text line
                    content.Add(LightAndFontSize2 + secondSubtitle.Content[0] + endText);
                    secondSubtitle.Content.RemoveAt(0);
                }
                else
                {
                    //add time line and delete time line
                    content.Add(firstSubtitle.Content[0]);
                    firstSubtitle.Content.RemoveAt(0);

                    //add text line and delete text line
                    content.Add(LightAndFontSize1 + firstSubtitle.Content[0] + endText);
                    firstSubtitle.Content.RemoveAt(0);
                }

                content.Add("\n");
            }

        }
        public void Print()
        {
            foreach (var item in content)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public void SeveFile()
        {
            StreamWriter sr = File.CreateText(Path);
            foreach (var item in content)
            {
                if (item == "\n")
                    sr.Write(item);
                else
                    sr.Write(item + "\n");
            }
            sr.Close();
        }

    }
}
