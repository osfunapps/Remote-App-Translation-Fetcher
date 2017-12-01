using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Remotes_App_Translation_Project
{
    partial class TranslationsForm
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
            this.languagesCB = new System.Windows.Forms.ComboBox();
            this.appNameOutputTB = new System.Windows.Forms.TextBox();
            this.summaryOutputTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appDescriptionOutputRTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.keywordsTB = new System.Windows.Forms.RichTextBox();
            this.developerMailTB = new System.Windows.Forms.TextBox();
            this.appNameTB = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.acRemotesCB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagesCB
            // 
            this.languagesCB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.languagesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languagesCB.FormattingEnabled = true;
            this.languagesCB.Location = new System.Drawing.Point(177, 13);
            this.languagesCB.Name = "languagesCB";
            this.languagesCB.Size = new System.Drawing.Size(272, 21);
            this.languagesCB.TabIndex = 0;
            this.languagesCB.SelectedIndexChanged += new System.EventHandler(this.languagesCB_SelectedIndexChanged);
            // 
            // appNameOutputTB
            // 
            this.appNameOutputTB.Enabled = false;
            this.appNameOutputTB.Location = new System.Drawing.Point(16, 29);
            this.appNameOutputTB.Name = "appNameOutputTB";
            this.appNameOutputTB.Size = new System.Drawing.Size(210, 20);
            this.appNameOutputTB.TabIndex = 2;
            this.appNameOutputTB.TextChanged += new System.EventHandler(this.appNameOutputTB_TextChanged);
            // 
            // summaryOutputTB
            // 
            this.summaryOutputTB.Enabled = false;
            this.summaryOutputTB.Location = new System.Drawing.Point(16, 63);
            this.summaryOutputTB.Multiline = true;
            this.summaryOutputTB.Name = "summaryOutputTB";
            this.summaryOutputTB.Size = new System.Drawing.Size(347, 39);
            this.summaryOutputTB.TabIndex = 3;
            this.summaryOutputTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTBSelectAll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.appDescriptionOutputRTB);
            this.groupBox1.Controls.Add(this.appNameOutputTB);
            this.groupBox1.Controls.Add(this.summaryOutputTB);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(298, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 473);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // appDescriptionOutputRTB
            // 
            this.appDescriptionOutputRTB.Enabled = false;
            this.appDescriptionOutputRTB.Location = new System.Drawing.Point(16, 117);
            this.appDescriptionOutputRTB.Multiline = true;
            this.appDescriptionOutputRTB.Name = "appDescriptionOutputRTB";
            this.appDescriptionOutputRTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.appDescriptionOutputRTB.Size = new System.Drawing.Size(347, 337);
            this.appDescriptionOutputRTB.TabIndex = 4;
            this.appDescriptionOutputRTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTBSelectAll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.keywordsTB);
            this.groupBox2.Controls.Add(this.developerMailTB);
            this.groupBox2.Controls.Add(this.appNameTB);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 250);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "App Props";
            // 
            // keywordsTB
            // 
            this.keywordsTB.Location = new System.Drawing.Point(17, 117);
            this.keywordsTB.Name = "keywordsTB";
            this.keywordsTB.Size = new System.Drawing.Size(233, 117);
            this.keywordsTB.TabIndex = 5;
            this.keywordsTB.Tag = "Keywords. \n\nLike: \"TV Volume up volume down control india set top box\"";
            this.keywordsTB.Text = "";
            // 
            // developerMailTB
            // 
            this.developerMailTB.Location = new System.Drawing.Point(58, 70);
            this.developerMailTB.Name = "developerMailTB";
            this.developerMailTB.Size = new System.Drawing.Size(158, 20);
            this.developerMailTB.TabIndex = 6;
            this.developerMailTB.Tag = "developer@mail";
            // 
            // appNameTB
            // 
            this.appNameTB.Location = new System.Drawing.Point(58, 29);
            this.appNameTB.Name = "appNameTB";
            this.appNameTB.Size = new System.Drawing.Size(158, 20);
            this.appNameTB.TabIndex = 5;
            this.appNameTB.Tag = "App Name";
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(29, 435);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(233, 70);
            this.goBtn.TabIndex = 8;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // acRemotesCB
            // 
            this.acRemotesCB.AutoSize = true;
            this.acRemotesCB.Location = new System.Drawing.Point(29, 322);
            this.acRemotesCB.Name = "acRemotesCB";
            this.acRemotesCB.Size = new System.Drawing.Size(80, 17);
            this.acRemotesCB.TabIndex = 9;
            this.acRemotesCB.Text = "AC Remote";
            this.acRemotesCB.UseVisualStyleBackColor = true;
            // 
            // TranslationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 535);
            this.Controls.Add(this.acRemotesCB);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.languagesCB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "TranslationsForm";
            this.Text = "Translation Fetcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languagesCB;
        private System.Windows.Forms.TextBox appNameOutputTB;
        private System.Windows.Forms.TextBox summaryOutputTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox keywordsTB;
        private System.Windows.Forms.TextBox developerMailTB;
        private System.Windows.Forms.TextBox appNameTB;
        private System.Windows.Forms.Button goBtn;
        private TextBox appDescriptionOutputRTB;
        private CheckBox acRemotesCB;
    }
}

