namespace Dictionary
{
    partial class FormDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDictionary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSpeakEnglish = new System.Windows.Forms.Button();
            this.comboBoxWord = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSpeakExplaination = new System.Windows.Forms.Button();
            this.buttonSpeakMeaning = new System.Windows.Forms.Button();
            this.textBoxExplanation = new System.Windows.Forms.TextBox();
            this.textBoxMeaning = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSpeakEnglish);
            this.panel1.Controls.Add(this.comboBoxWord);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 603);
            this.panel1.TabIndex = 1;
            // 
            // buttonSpeakEnglish
            // 
            this.buttonSpeakEnglish.BackgroundImage = global::Dictionary.Properties.Resources.audio;
            this.buttonSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakEnglish.Location = new System.Drawing.Point(229, 1);
            this.buttonSpeakEnglish.Name = "buttonSpeakEnglish";
            this.buttonSpeakEnglish.Size = new System.Drawing.Size(59, 35);
            this.buttonSpeakEnglish.TabIndex = 1;
            this.buttonSpeakEnglish.UseVisualStyleBackColor = true;
            this.buttonSpeakEnglish.Click += new System.EventHandler(this.buttonSpeakEnglish_Click);
            // 
            // comboBoxWord
            // 
            this.comboBoxWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxWord.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWord.FormattingEnabled = true;
            this.comboBoxWord.Location = new System.Drawing.Point(5, 1);
            this.comboBoxWord.Name = "comboBoxWord";
            this.comboBoxWord.Size = new System.Drawing.Size(206, 585);
            this.comboBoxWord.TabIndex = 0;
            this.comboBoxWord.SelectedIndexChanged += new System.EventHandler(this.comboBoxWord_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSpeakExplaination);
            this.panel2.Controls.Add(this.buttonSpeakMeaning);
            this.panel2.Controls.Add(this.textBoxExplanation);
            this.panel2.Controls.Add(this.textBoxMeaning);
            this.panel2.Location = new System.Drawing.Point(329, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 603);
            this.panel2.TabIndex = 2;
            // 
            // buttonSpeakExplaination
            // 
            this.buttonSpeakExplaination.BackgroundImage = global::Dictionary.Properties.Resources.audio;
            this.buttonSpeakExplaination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakExplaination.Location = new System.Drawing.Point(508, 536);
            this.buttonSpeakExplaination.Name = "buttonSpeakExplaination";
            this.buttonSpeakExplaination.Size = new System.Drawing.Size(59, 35);
            this.buttonSpeakExplaination.TabIndex = 3;
            this.buttonSpeakExplaination.UseVisualStyleBackColor = true;
            // 
            // buttonSpeakMeaning
            // 
            this.buttonSpeakMeaning.BackgroundImage = global::Dictionary.Properties.Resources.audio;
            this.buttonSpeakMeaning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpeakMeaning.Location = new System.Drawing.Point(508, 3);
            this.buttonSpeakMeaning.Name = "buttonSpeakMeaning";
            this.buttonSpeakMeaning.Size = new System.Drawing.Size(59, 35);
            this.buttonSpeakMeaning.TabIndex = 2;
            this.buttonSpeakMeaning.UseVisualStyleBackColor = true;
            // 
            // textBoxExplanation
            // 
            this.textBoxExplanation.Location = new System.Drawing.Point(13, 56);
            this.textBoxExplanation.Multiline = true;
            this.textBoxExplanation.Name = "textBoxExplanation";
            this.textBoxExplanation.Size = new System.Drawing.Size(466, 515);
            this.textBoxExplanation.TabIndex = 1;
            // 
            // textBoxMeaning
            // 
            this.textBoxMeaning.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeaning.Location = new System.Drawing.Point(13, 3);
            this.textBoxMeaning.Name = "textBoxMeaning";
            this.textBoxMeaning.Size = new System.Drawing.Size(466, 34);
            this.textBoxMeaning.TabIndex = 0;
            // 
            // FormDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDictionary_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxExplanation;
        private System.Windows.Forms.TextBox textBoxMeaning;
        private System.Windows.Forms.ComboBox comboBoxWord;
        private System.Windows.Forms.Button buttonSpeakEnglish;
        private System.Windows.Forms.Button buttonSpeakExplaination;
        private System.Windows.Forms.Button buttonSpeakMeaning;
    }
}

