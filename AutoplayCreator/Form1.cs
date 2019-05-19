using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoplayCreator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string text = "";

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void OpenIcon_FileOk(object sender, CancelEventArgs e) {
            Icon IEIcon = Icon.ExtractAssociatedIcon(openIcon.FileName);
            Image im = IEIcon.ToBitmap();
            iconBox.Image = im;
        }

        private void PickIcon_Click(object sender, EventArgs e) {
            openIcon.Title = "Pick an Icon (.ico, on the same drive)";
            openIcon.DefaultExt = "ico";
            openIcon.Filter = "Icons (*.ico)|*.ico|Executables (*.exe)|*.exe";
            openIcon.ShowDialog();
        }

        private void Compile_Click(object sender, EventArgs e) {
            text += "[autorun]\n";
            text += "label=" + name.Text + "\n";
            text += "open=" + openExe.FileName + "\n";
            text += "icon=" + openIcon.FileName + ",0";
            if (compileContent.Checked) {
                text += "\n[Content]\n";
                text += "MusicFiles=" + music.Checked;
                text += "PictureFiles=" + picture.Checked;
                text += "VideoFiles=" + video.Checked;
            }
            saveAutorun.Title = "Save autorun.inf";
            saveAutorun.DefaultExt = "inf";
            saveAutorun.Filter ="Information|*.inf";
            if (saveAutorun.ShowDialog() == DialogResult.OK) {
                using (StreamWriter sw = new StreamWriter(saveAutorun.FileName)) {
                    sw.WriteLine(text);
                }
            }
            text = "";
        }

        private void PickExe_Click(object sender, EventArgs e) {
            openExe.Title = "Pick Executable (on the same drive)";
            openExe.DefaultExt = "exe";
            openExe.Filter = "Executables (*.exe)|*.exe|Batch files (*.bat)|*.bat|NT batch files (*.cmd)|*.cmd";
            openExe.ShowDialog();
        }

        private void Fork_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/githubcatw/AutoPlayMaker");
        }

        private void CompileContent_CheckedChanged(object sender, EventArgs e) {
            if (!compileContent.Checked) {
                picture.Enabled = false;
                music.Enabled = false;
                video.Enabled = false;
            }
            else {
                picture.Enabled = true;
                music.Enabled = true;
                video.Enabled = true;
            }
        }
    }
}
