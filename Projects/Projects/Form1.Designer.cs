namespace Projects
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
            this.btnAddStage = new System.Windows.Forms.Button();
            this.lstStages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddStage
            // 
            this.btnAddStage.Location = new System.Drawing.Point(426, 187);
            this.btnAddStage.Name = "btnAddStage";
            this.btnAddStage.Size = new System.Drawing.Size(124, 23);
            this.btnAddStage.TabIndex = 0;
            this.btnAddStage.Text = "Aşama Ekle";
            this.btnAddStage.UseVisualStyleBackColor = true;
            this.btnAddStage.Click += new System.EventHandler(this.btnAddStage_Click);
            // 
            // lstStages
            // 
            this.lstStages.FormattingEnabled = true;
            this.lstStages.ItemHeight = 16;
            this.lstStages.Location = new System.Drawing.Point(38, 82);
            this.lstStages.Name = "lstStages";
            this.lstStages.Size = new System.Drawing.Size(163, 244);
            this.lstStages.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstStages);
            this.Controls.Add(this.btnAddStage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStage;
        private System.Windows.Forms.ListBox lstStages;
    }
}

