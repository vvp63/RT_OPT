using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RT_OPT
{
    public partial class MainForm : Form
    {

        //Settings

        private void LoadSettings()
        {
            //  Считываем параметры
            string vOldTriFile = gTriFile;
            gTriFile = RT_OPT.Properties.Settings.Default.TriFile.ToString();
            gLogFile = RT_OPT.Properties.Settings.Default.LogFile.ToString();
            gSetOrderStr = RT_OPT.Properties.Settings.Default.SetOrderStr.ToString();
            gDropOrderStr = RT_OPT.Properties.Settings.Default.DropOrderStr.ToString();
            gRequoteInterval = RT_OPT.Properties.Settings.Default.RequoteInterval;

            tbTriFile.Text = gTriFile;
            tbLogFile.Text = gLogFile;
            tbSetOrderStr.Text = gSetOrderStr;
            tbDropOrderStr.Text = gDropOrderStr;
            tbQuoteInterval.Text = gRequoteInterval.ToString();

            timer_Requote.Interval = gRequoteInterval;

            if (gTriFile != vOldTriFile) System.IO.File.WriteAllText(tbTriFile.Text, "");
        }

        private void bTriFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            tbTriFile.Text = openFileDialog.FileName;
        }

        private void bSelectLogFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            tbLogFile.Text = openFileDialog.FileName;
        }

        private void bSaveSettings_Click(object sender, EventArgs e)
        {
            RT_OPT.Properties.Settings.Default.TriFile = tbTriFile.Text;
            RT_OPT.Properties.Settings.Default.LogFile = tbLogFile.Text;
            RT_OPT.Properties.Settings.Default.SetOrderStr = tbSetOrderStr.Text;
            RT_OPT.Properties.Settings.Default.DropOrderStr = tbDropOrderStr.Text;
            int vInterval; int.TryParse(tbQuoteInterval.Text, out vInterval);
            RT_OPT.Properties.Settings.Default.RequoteInterval = vInterval;
            RT_OPT.Properties.Settings.Default.Save();
            LoadSettings();
            TextLog("Settings saved");
        }

    }



}
