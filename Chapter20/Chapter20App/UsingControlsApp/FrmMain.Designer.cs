
namespace UsingControlsApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.PrbDisplay = new System.Windows.Forms.ProgressBar();
            this.TrbHandle = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.BtnModaless = new System.Windows.Forms.Button();
            this.BtnModal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpTreeList = new System.Windows.Forms.GroupBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpTreeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.lblFont);
            this.groupBox1.Controls.Add(this.comboFont);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 48);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(353, 23);
            this.txtResult.TabIndex = 5;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chkItalic.Location = new System.Drawing.Point(235, 21);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(62, 19);
            this.chkItalic.TabIndex = 4;
            this.chkItalic.Text = "기울임";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBold.Location = new System.Drawing.Point(179, 21);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(50, 19);
            this.chkBold.TabIndex = 3;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(6, 23);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(42, 15);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font : ";
            // 
            // comboFont
            // 
            this.comboFont.FormattingEnabled = true;
            this.comboFont.Location = new System.Drawing.Point(51, 19);
            this.comboFont.Name = "comboFont";
            this.comboFont.Size = new System.Drawing.Size(121, 23);
            this.comboFont.TabIndex = 2;
            this.comboFont.SelectedIndexChanged += new System.EventHandler(this.ComboFont_SelectedIndexChanged);
            // 
            // PrbDisplay
            // 
            this.PrbDisplay.Location = new System.Drawing.Point(4, 74);
            this.PrbDisplay.Name = "PrbDisplay";
            this.PrbDisplay.Size = new System.Drawing.Size(353, 23);
            this.PrbDisplay.TabIndex = 2;
            // 
            // TrbHandle
            // 
            this.TrbHandle.LargeChange = 2;
            this.TrbHandle.Location = new System.Drawing.Point(4, 22);
            this.TrbHandle.Maximum = 100;
            this.TrbHandle.Name = "TrbHandle";
            this.TrbHandle.Size = new System.Drawing.Size(353, 45);
            this.TrbHandle.TabIndex = 1;
            this.TrbHandle.Scroll += new System.EventHandler(this.TrbHandle_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMsgBox);
            this.groupBox2.Controls.Add(this.BtnModaless);
            this.groupBox2.Controls.Add(this.BtnModal);
            this.groupBox2.Location = new System.Drawing.Point(13, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modal, Modaless";
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(234, 22);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(124, 33);
            this.BtnMsgBox.TabIndex = 2;
            this.BtnMsgBox.Text = "MessageBox";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // BtnModaless
            // 
            this.BtnModaless.Location = new System.Drawing.Point(122, 22);
            this.BtnModaless.Name = "BtnModaless";
            this.BtnModaless.Size = new System.Drawing.Size(106, 33);
            this.BtnModaless.TabIndex = 1;
            this.BtnModaless.Text = "Modaless";
            this.BtnModaless.UseVisualStyleBackColor = true;
            this.BtnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(7, 23);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(109, 32);
            this.BtnModal.TabIndex = 0;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PrbDisplay);
            this.groupBox3.Controls.Add(this.TrbHandle);
            this.groupBox3.Location = new System.Drawing.Point(13, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // grpTreeList
            // 
            this.grpTreeList.Controls.Add(this.btnAddChild);
            this.grpTreeList.Controls.Add(this.btnAddRoot);
            this.grpTreeList.Controls.Add(this.tvDummy);
            this.grpTreeList.Controls.Add(this.lvDummy);
            this.grpTreeList.Location = new System.Drawing.Point(13, 280);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.Size = new System.Drawing.Size(370, 172);
            this.grpTreeList.TabIndex = 3;
            this.grpTreeList.TabStop = false;
            this.grpTreeList.Text = "TreeView && ListView";
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(112, 132);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(101, 23);
            this.btnAddChild.TabIndex = 3;
            this.btnAddChild.Text = "자식추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(7, 132);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(99, 23);
            this.btnAddRoot.TabIndex = 2;
            this.btnAddRoot.Text = "루트추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(6, 22);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(165, 103);
            this.tvDummy.TabIndex = 1;
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(178, 22);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(186, 103);
            this.lvDummy.TabIndex = 0;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 464);
            this.Controls.Add(this.grpTreeList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpTreeList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox comboFont;
        private System.Windows.Forms.ProgressBar PrbDisplay;
        private System.Windows.Forms.TrackBar TrbHandle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.Button BtnModaless;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpTreeList;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.TreeView tvDummy;
        private System.Windows.Forms.ListView lvDummy;
    }
}

