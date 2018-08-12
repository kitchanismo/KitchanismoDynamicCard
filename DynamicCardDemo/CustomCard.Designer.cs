namespace DynamicCardDemo
{
    partial class CustomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCard));
            this.TxtArea = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtitle.Location = new System.Drawing.Point(14, 151);
            this.LblSubtitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSubtitle.Size = new System.Drawing.Size(250, 37);
            this.LblSubtitle.Text = "Subtitle";
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(14, 102);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTitle.Size = new System.Drawing.Size(313, 37);
            this.LblTitle.Text = "Title";
            // 
            // CardImage
            // 
            this.CardImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CardImage.ErrorImage")));
            this.CardImage.Image = ((System.Drawing.Image)(resources.GetObject("CardImage.Image")));
            this.CardImage.Margin = new System.Windows.Forms.Padding(5);
            this.CardImage.Size = new System.Drawing.Size(357, 86);
            this.CardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(17, 191);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(325, 96);
            this.TxtArea.TabIndex = 3;
            this.TxtArea.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(249, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CustomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtArea);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Name = "CustomCard";
            this.Size = new System.Drawing.Size(357, 360);
            this.Controls.SetChildIndex(this.CardImage, 0);
            this.Controls.SetChildIndex(this.LblSubtitle, 0);
            this.Controls.SetChildIndex(this.LblTitle, 0);
            this.Controls.SetChildIndex(this.TxtArea, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtArea;
        private System.Windows.Forms.Button button1;
    }
}
