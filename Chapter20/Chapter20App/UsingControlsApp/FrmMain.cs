using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var fontsList = FontFamily.Families;
            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
            foreach (var font in fontsList)
            {
                comboFont.Items.Add(font.Name);
            }
        } // 프로그램 실행 시 

        #region CustomMethod Field
        private void ChangeFont()
        {
            if (comboFont.SelectedIndex < 0) return;
            FontStyle style = FontStyle.Regular; // 00000000 
            if (chkBold.Checked) style |= FontStyle.Bold; // 00000001
            if (chkItalic.Checked) style |= FontStyle.Italic; // 00000010
            // 00000011 -> Bold + Italic 
            txtResult.Font = new Font((string)comboFont.SelectedItem, 14, style);
        }
        private void DisplayTreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
            {
                DisplayTreeToList(node);
            }
        }
        private void DisplayTreeToList(TreeNode node)
        {
            lvDummy.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath }));
            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList(item);
            }
        }

        #endregion
        #region EventHandler Field
        private void ComboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        
        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;   
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modal Form";
            form.Width = 300;
            form.Height = 100;
            form.BackColor = Color.Coral;
            form.ShowDialog();
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 100,
                BackColor = Color.Cyan
            };
            form.Show(); // Modaless
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtResult.Text, "타이틀", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            tvDummy.Nodes.Add(random.Next().ToString());
            DisplayTreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            DisplayTreeToList();
        }



        #endregion

        
    }
}
