namespace ClozeMaker
{
   partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtCloze = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExclude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoExcludeWords = new System.Windows.Forms.RadioButton();
            this.rdoIncludeWords = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(12, 42);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(415, 430);
            this.txtSource.TabIndex = 1;
            this.txtSource.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // txtCloze
            // 
            this.txtCloze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCloze.Location = new System.Drawing.Point(445, 42);
            this.txtCloze.Multiline = true;
            this.txtCloze.Name = "txtCloze";
            this.txtCloze.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCloze.Size = new System.Drawing.Size(411, 574);
            this.txtCloze.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cloze";
            // 
            // txtExclude
            // 
            this.txtExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExclude.Location = new System.Drawing.Point(12, 500);
            this.txtExclude.Multiline = true;
            this.txtExclude.Name = "txtExclude";
            this.txtExclude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExclude.Size = new System.Drawing.Size(415, 118);
            this.txtExclude.TabIndex = 4;
            this.txtExclude.TextChanged += new System.EventHandler(this.TxtExclude_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Option words";
            // 
            // radioButton1
            // 
            this.rdoExcludeWords.AutoSize = true;
            this.rdoExcludeWords.Checked = true;
            this.rdoExcludeWords.Location = new System.Drawing.Point(3, 3);
            this.rdoExcludeWords.Name = "rdoExcludeWords";
            this.rdoExcludeWords.Size = new System.Drawing.Size(94, 17);
            this.rdoExcludeWords.TabIndex = 6;
            this.rdoExcludeWords.TabStop = true;
            this.rdoExcludeWords.Text = "Exclude words";
            this.rdoExcludeWords.UseVisualStyleBackColor = true;
            this.rdoExcludeWords.CheckedChanged += new System.EventHandler(this.RdoExcludeWords_CheckedChanged);
            // 
            // radioButton2
            // 
            this.rdoIncludeWords.AutoSize = true;
            this.rdoIncludeWords.Location = new System.Drawing.Point(105, 3);
            this.rdoIncludeWords.Name = "rdoIncludeWords";
            this.rdoIncludeWords.Size = new System.Drawing.Size(91, 17);
            this.rdoIncludeWords.TabIndex = 7;
            this.rdoIncludeWords.Text = "Include words";
            this.rdoIncludeWords.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoIncludeWords);
            this.panel1.Controls.Add(this.rdoExcludeWords);
            this.panel1.Location = new System.Drawing.Point(135, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 22);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExclude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCloze);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cloze Maker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtSource;
      private System.Windows.Forms.TextBox txtCloze;
      private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExclude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoExcludeWords;
        private System.Windows.Forms.RadioButton rdoIncludeWords;
        private System.Windows.Forms.Panel panel1;
    }
}

