using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Sybtitle
{
    class Presenter
    {
        IMainForm mainForm;
        ISubtitle firstSubtitle;
        ISubtitle secondSubtitle;
        IDoubleSubtitle doubleSubtitle;

        public Presenter(IMainForm form)
        {
            mainForm = form;
            mainForm.FirstFileOpenClick += mainForm_FirstFileOpenClick;
            mainForm.SecondFileClick += mainForm_SecondFileClick;
            mainForm.FileSeveClick += mainForm_FileSeveClick;
        }

        private void mainForm_FileSeveClick(object sender, EventArgs e)
        {
            doubleSubtitle = new DoubleSubtitle(
                firstSubtitle, secondSubtitle, mainForm.FileName,
                mainForm.Size1, mainForm.Color1,
                mainForm.Size2, mainForm.Color2);
            

            doubleSubtitle.SeveFile();
         
        }

        private void mainForm_SecondFileClick(object sender, EventArgs e)
        {
            secondSubtitle = new Subtitle(mainForm.Path2);
        }

        private void mainForm_FirstFileOpenClick(object sender, EventArgs e)
        {
            firstSubtitle = new Subtitle(mainForm.Path1);
        }
    }
}
