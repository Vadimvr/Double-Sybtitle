using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Double_Sybtitle
{
    public interface IMainForm
    {
        string Path1 { get; }
        string Path2 { get; }
        string FileName { get; }
        string FilePath { get; }
        string Color1 { get; }
        string Color2 { get; }
        string Size1 { get; }
        string Size2 { get; }

        event EventHandler FirstFileOpenClick;
        event EventHandler SecondFileClick;
        event EventHandler FileSeveClick;
    }
    public partial class MainForm : Form, IMainForm
    {

        string _pathFirstSubtitles;
        string _pathSecondSubtitles;
        string _fileName = "New file.str";
        string _filePath = @"D:\";
        string _colorFirstFile = "#ffffff";
        string _colorSecondFile = "#ffffff";
        string _size1 = "40";
        string _size2 = "40";
        bool trueOpenFirst = false;
        bool trueOpenSecond = false;

        SaveFileDialog sfd = new SaveFileDialog();
        OpenFileDialog dlg = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
            buttonOpenFirsFile.Click += OpenFirsFile_Click;
            buttonOpenSecondFile.Click += OpenSecondFile_Click;
            buttonSeveFile.Click += SeveFile_Click;

        }

        #region IMinForm
        public event EventHandler FirstFileOpenClick;
        public event EventHandler SecondFileClick;
        public event EventHandler FileSeveClick;
        public string Path1
        {
            get { return _pathFirstSubtitles; }
            set { _pathFirstSubtitles = value; }
        }
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        public string Path2
        {
            get { return _pathSecondSubtitles; }
            set { _pathSecondSubtitles = value; }
        }
        string IMainForm.Color1
        {
            get { return _colorFirstFile; }

        }

        string IMainForm.Color2
        {
            get { return _colorSecondFile; }

        }

        string IMainForm.Size1 { get { return _size1; } }
        string IMainForm.Size2 { get { return _size2; } }


        #endregion
        #region события

        private void OpenFirsFile_Click(object sender, EventArgs e)
        {

            dlg.Filter = "|*.srt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Path1 = dlg.InitialDirectory + dlg.FileName;
                FilePath = dlg.InitialDirectory;
                FileName = dlg.FileName.Length > 5 ? dlg.FileName.Substring(0, dlg.FileName.Length - 6) + "double" : "double";
                if (FirstFileOpenClick != null)
                {
                    FirstFileOpenClick(this, EventArgs.Empty);
                    trueOpenFirst = true;
                }
            }
        }

        private void OpenSecondFile_Click(object sender, EventArgs e)
        {

            dlg.Filter = "|*.srt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Path2 = dlg.InitialDirectory + dlg.FileName;
                if (SecondFileClick != null)
                {
                    SecondFileClick(this, EventArgs.Empty);
                    trueOpenSecond = true;
                }
            }
        }

        private void SeveFile_Click(object sender, EventArgs e)
        {
            sfd.Filter = "|*.srt";
            sfd.InitialDirectory = _filePath;
            sfd.FileName = FileName;

            if ( trueOpenFirst && trueOpenSecond && sfd.ShowDialog() == DialogResult.OK )
            {
                FileName = sfd.FileName;
                FilePath = sfd.InitialDirectory;
                if (FirstFileOpenClick != null)
                    FileSeveClick(this, EventArgs.Empty);
            }
        }

        private void ColorSecondSybtitle_Click(object sender, EventArgs e)
        {
            if (colorDiolog.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDiolog.Color;
                ColorSecondSybtitle.ForeColor = c;
                _colorSecondFile = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
        }

        private void ColorFirstSubtitle_Click(object sender, EventArgs e)
        {
            if (colorDiolog.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDiolog.Color;
                ColorFirstSubtitle.ForeColor = c;
                _colorFirstFile = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _size1 = numericUpDown1.Value.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _size2 = numericUpDown1.Value.ToString();
        }
        #endregion
    }
}
