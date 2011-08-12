namespace PopsicleStick
{
    partial class PopsicleStickForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotCalledList = new System.Windows.Forms.ListBox();
            this.CalledList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SetCalledButton = new System.Windows.Forms.Button();
            this.SetNotCalledButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ClearCalledButton = new System.Windows.Forms.Button();
            this.CallButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotCalledList
            // 
            this.NotCalledList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NotCalledList.FormattingEnabled = true;
            this.NotCalledList.Location = new System.Drawing.Point(0, 16);
            this.NotCalledList.Name = "NotCalledList";
            this.NotCalledList.Size = new System.Drawing.Size(175, 264);
            this.NotCalledList.Sorted = true;
            this.NotCalledList.TabIndex = 0;
            // 
            // CalledList
            // 
            this.CalledList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CalledList.FormattingEnabled = true;
            this.CalledList.Location = new System.Drawing.Point(3, 16);
            this.CalledList.Name = "CalledList";
            this.CalledList.Size = new System.Drawing.Size(167, 264);
            this.CalledList.Sorted = true;
            this.CalledList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Not Called:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Called:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SetCalledButton);
            this.splitContainer1.Panel1.Controls.Add(this.SetNotCalledButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.NotCalledList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.CalledList);
            this.splitContainer1.Size = new System.Drawing.Size(390, 288);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 4;
            // 
            // SetCalledButton
            // 
            this.SetCalledButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetCalledButton.Location = new System.Drawing.Point(181, 52);
            this.SetCalledButton.Name = "SetCalledButton";
            this.SetCalledButton.Size = new System.Drawing.Size(30, 30);
            this.SetCalledButton.TabIndex = 12;
            this.SetCalledButton.Text = ">";
            this.SetCalledButton.UseVisualStyleBackColor = true;
            this.SetCalledButton.Click += new System.EventHandler(this.SetCalledButton_Click);
            // 
            // SetNotCalledButton
            // 
            this.SetNotCalledButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetNotCalledButton.Location = new System.Drawing.Point(181, 16);
            this.SetNotCalledButton.Name = "SetNotCalledButton";
            this.SetNotCalledButton.Size = new System.Drawing.Size(30, 30);
            this.SetNotCalledButton.TabIndex = 11;
            this.SetNotCalledButton.Text = "<";
            this.SetNotCalledButton.UseVisualStyleBackColor = true;
            this.SetNotCalledButton.Click += new System.EventHandler(this.SetNotCalledButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ClearCalledButton
            // 
            this.ClearCalledButton.Location = new System.Drawing.Point(93, 12);
            this.ClearCalledButton.Name = "ClearCalledButton";
            this.ClearCalledButton.Size = new System.Drawing.Size(75, 23);
            this.ClearCalledButton.TabIndex = 6;
            this.ClearCalledButton.Text = "Clear Called";
            this.ClearCalledButton.UseVisualStyleBackColor = true;
            this.ClearCalledButton.Click += new System.EventHandler(this.ClearCalledButton_Click);
            // 
            // CallButton
            // 
            this.CallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CallButton.Location = new System.Drawing.Point(12, 335);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(75, 23);
            this.CallButton.TabIndex = 10;
            this.CallButton.Text = "Call";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(93, 340);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(80, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Selected Name";
            // 
            // PopsicleStickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 370);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ClearCalledButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PopsicleStickForm";
            this.Text = "PopsicleStick";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NotCalledList;
        private System.Windows.Forms.ListBox CalledList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ClearCalledButton;
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SetCalledButton;
        private System.Windows.Forms.Button SetNotCalledButton;
    }
}

