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

namespace FileCopyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFindSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = dialog.FileName;
            }
        }
        private void BtnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = dialog.FileName;
            }
        }
        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(txtSource.Text, txtTarget.Text);
            MessageBox.Show($"{totalCopied}로 비동기 복사 완료");
        }
        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(txtSource.Text, txtTarget.Text);
            MessageBox.Show($"{totalCopied}로 동기 복사 완료");
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private long CopySync(string sourcePath, string targetPath)
        {
            btnAsyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024]; // 1MB buffer
                    int nRead = 0;
                    while ((nRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0) // 파일이 더 이상 없을때까지
                    {
                        targetStream.Write(buffer, 0, nRead); // 파일 복사 
                        totalCopied += nRead;

                        // Progress Bar Display
                        pbCopy.Value = (int)(totalCopied / sourceStream.Length * 100);
                    }
                }
            }
            btnAsyncCopy.Enabled = true;
            return totalCopied; 
        }

        private async Task<long> CopyAsync(string sourcePath, string targetPath)
        {
            btnSyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024]; // 1MB buffer
                    int nRead = 0;
                    while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0) // 파일이 더 이상 없을때까지
                    {
                        await targetStream.WriteAsync(buffer, 0, nRead); // 파일 복사 
                        totalCopied += nRead;

                        // Progress Bar Display
                        pbCopy.Value = (int)(totalCopied / sourceStream.Length * 100);
                    }
                }
            }
            btnSyncCopy.Enabled = true;
            return totalCopied;
        }
    }
}
