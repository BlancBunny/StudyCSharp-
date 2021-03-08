
namespace FileCopyApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnFindSource = new System.Windows.Forms.Button();
            this.btnFindTarget = new System.Windows.Forms.Button();
            this.btnAsyncCopy = new System.Windows.Forms.Button();
            this.btnSyncCopy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(85, 13);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(214, 21);
            this.txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(85, 41);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(214, 21);
            this.txtTarget.TabIndex = 3;
            // 
            // btnFindSource
            // 
            this.btnFindSource.Location = new System.Drawing.Point(305, 11);
            this.btnFindSource.Name = "btnFindSource";
            this.btnFindSource.Size = new System.Drawing.Size(31, 23);
            this.btnFindSource.TabIndex = 4;
            this.btnFindSource.Text = "...";
            this.btnFindSource.UseVisualStyleBackColor = true;
            this.btnFindSource.Click += new System.EventHandler(this.BtnFindSource_Click);
            // 
            // btnFindTarget
            // 
            this.btnFindTarget.Location = new System.Drawing.Point(305, 39);
            this.btnFindTarget.Name = "btnFindTarget";
            this.btnFindTarget.Size = new System.Drawing.Size(31, 23);
            this.btnFindTarget.TabIndex = 5;
            this.btnFindTarget.Text = "...";
            this.btnFindTarget.UseVisualStyleBackColor = true;
            this.btnFindTarget.Click += new System.EventHandler(this.BtnFindTarget_Click);
            // 
            // btnAsyncCopy
            // 
            this.btnAsyncCopy.Location = new System.Drawing.Point(24, 78);
            this.btnAsyncCopy.Name = "btnAsyncCopy";
            this.btnAsyncCopy.Size = new System.Drawing.Size(87, 23);
            this.btnAsyncCopy.TabIndex = 6;
            this.btnAsyncCopy.Text = "Async Copy";
            this.btnAsyncCopy.UseVisualStyleBackColor = true;
            this.btnAsyncCopy.Click += new System.EventHandler(this.BtnAsyncCopy_Click);
            // 
            // btnSyncCopy
            // 
            this.btnSyncCopy.Location = new System.Drawing.Point(137, 78);
            this.btnSyncCopy.Name = "btnSyncCopy";
            this.btnSyncCopy.Size = new System.Drawing.Size(94, 23);
            this.btnSyncCopy.TabIndex = 7;
            this.btnSyncCopy.Text = "Sync Copy";
            this.btnSyncCopy.UseVisualStyleBackColor = true;
            this.btnSyncCopy.Click += new System.EventHandler(this.BtnSyncCopy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pbCopy
            // 
            this.pbCopy.Location = new System.Drawing.Point(18, 119);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(318, 19);
            this.pbCopy.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 153);
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSyncCopy);
            this.Controls.Add(this.btnAsyncCopy);
            this.Controls.Add(this.btnFindTarget);
            this.Controls.Add(this.btnFindSource);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Async File Copy App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnFindSource;
        private System.Windows.Forms.Button btnFindTarget;
        private System.Windows.Forms.Button btnAsyncCopy;
        private System.Windows.Forms.Button btnSyncCopy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar pbCopy;
    }
}

