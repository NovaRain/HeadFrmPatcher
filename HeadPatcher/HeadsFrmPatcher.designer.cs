﻿namespace HeadsPatcher
{
    partial class HeadsFrmPatcher {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadsFrmPatcher));
            this.cbDisableHighlighting = new System.Windows.Forms.CheckBox();
            this.cbIncludesBackground = new System.Windows.Forms.CheckBox();
            this.bRun = new System.Windows.Forms.Button();
            this.ofdFrm = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // cbDisableHighlighting
            // 
            this.cbDisableHighlighting.AutoSize = true;
            this.cbDisableHighlighting.Location = new System.Drawing.Point(12, 12);
            this.cbDisableHighlighting.Name = "cbDisableHighlighting";
            this.cbDisableHighlighting.Size = new System.Drawing.Size(141, 17);
            this.cbDisableHighlighting.TabIndex = 3;
            this.cbDisableHighlighting.Text = "Disable corner highlights";
            this.cbDisableHighlighting.UseVisualStyleBackColor = true;
            // 
            // cbIncludesBackground
            // 
            this.cbIncludesBackground.AutoSize = true;
            this.cbIncludesBackground.Location = new System.Drawing.Point(12, 35);
            this.cbIncludesBackground.Name = "cbIncludesBackground";
            this.cbIncludesBackground.Size = new System.Drawing.Size(154, 17);
            this.cbIncludesBackground.TabIndex = 6;
            this.cbIncludesBackground.Text = "Fill transparent background";
            this.cbIncludesBackground.UseVisualStyleBackColor = true;
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(74, 60);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(75, 23);
            this.bRun.TabIndex = 10;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // ofdFrm
            // 
            this.ofdFrm.Filter = "Fallout FRM files|*.frm";
            this.ofdFrm.Multiselect = true;
            this.ofdFrm.RestoreDirectory = true;
            this.ofdFrm.Title = "Select FRM to patch";
            // 
            // HeadsFrmPatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 95);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.cbIncludesBackground);
            this.Controls.Add(this.cbDisableHighlighting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HeadsFrmPatcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Head FRM File Patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDisableHighlighting;
        private System.Windows.Forms.CheckBox cbIncludesBackground;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.OpenFileDialog ofdFrm;
    }
}