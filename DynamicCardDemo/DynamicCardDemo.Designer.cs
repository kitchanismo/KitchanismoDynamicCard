using DynamicCard;

namespace DynamicCardDemo
{
    partial class DynamicCardDemo
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
            this.LblTotalQty = new System.Windows.Forms.Label();
            this.LvCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtSubtitle = new System.Windows.Forms.TextBox();
            this.TxtImagePath = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CboOrder = new System.Windows.Forms.ComboBox();
            this.CboTheme = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnPrimary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.LblTotalCards = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboStyle = new System.Windows.Forms.ComboBox();
            this.ImageDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.CboLayout = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CboCategory = new System.Windows.Forms.ComboBox();
            this.cardContainer1 = new DynamicCard.CardContainer();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTotalQty
            // 
            this.LblTotalQty.AutoSize = true;
            this.LblTotalQty.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalQty.Location = new System.Drawing.Point(889, 20);
            this.LblTotalQty.Name = "LblTotalQty";
            this.LblTotalQty.Size = new System.Drawing.Size(21, 22);
            this.LblTotalQty.TabIndex = 1;
            this.LblTotalQty.Text = "0";
            // 
            // LvCart
            // 
            this.LvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LvCart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvCart.FullRowSelect = true;
            this.LvCart.GridLines = true;
            this.LvCart.Location = new System.Drawing.Point(797, 55);
            this.LvCart.Name = "LvCart";
            this.LvCart.Size = new System.Drawing.Size(278, 244);
            this.LvCart.TabIndex = 3;
            this.LvCart.UseCompatibleStateImageBehavior = false;
            this.LvCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 44;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subtotal";
            this.columnHeader4.Width = 71;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.White;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(978, 360);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(97, 33);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "Dummy";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(188, 9);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(436, 33);
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(1010, 20);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(21, 22);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "0";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.White;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(796, 360);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(97, 33);
            this.BtnRefresh.TabIndex = 10;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(955, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(792, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. Items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(795, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Title";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.Location = new System.Drawing.Point(796, 428);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(279, 33);
            this.TxtTitle.TabIndex = 15;
            this.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSubtitle
            // 
            this.TxtSubtitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtitle.Location = new System.Drawing.Point(796, 488);
            this.TxtSubtitle.Name = "TxtSubtitle";
            this.TxtSubtitle.Size = new System.Drawing.Size(279, 33);
            this.TxtSubtitle.TabIndex = 16;
            this.TxtSubtitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtImagePath
            // 
            this.TxtImagePath.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImagePath.Location = new System.Drawing.Point(796, 547);
            this.TxtImagePath.Name = "TxtImagePath";
            this.TxtImagePath.Size = new System.Drawing.Size(206, 33);
            this.TxtImagePath.TabIndex = 17;
            this.TxtImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(792, 463);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(76, 22);
            this.lblprice.TabIndex = 18;
            this.lblprice.Text = "Subtitle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(792, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "ImagePath";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(796, 600);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(95, 33);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CboOrder
            // 
            this.CboOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboOrder.FormattingEnabled = true;
            this.CboOrder.Items.AddRange(new object[] {
            "ASC",
            "DES"});
            this.CboOrder.Location = new System.Drawing.Point(642, 9);
            this.CboOrder.Name = "CboOrder";
            this.CboOrder.Size = new System.Drawing.Size(131, 32);
            this.CboOrder.TabIndex = 21;
            this.CboOrder.Text = " - Order By -";
            this.CboOrder.SelectedIndexChanged += new System.EventHandler(this.CboOrder_SelectedIndexChanged);
            // 
            // CboTheme
            // 
            this.CboTheme.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTheme.FormattingEnabled = true;
            this.CboTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.CboTheme.Location = new System.Drawing.Point(642, 600);
            this.CboTheme.Name = "CboTheme";
            this.CboTheme.Size = new System.Drawing.Size(131, 32);
            this.CboTheme.TabIndex = 22;
            this.CboTheme.Text = " - Theme -";
            this.CboTheme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Tomato;
            // 
            // BtnPrimary
            // 
            this.BtnPrimary.BackColor = System.Drawing.Color.White;
            this.BtnPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrimary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimary.Location = new System.Drawing.Point(417, 600);
            this.BtnPrimary.Name = "BtnPrimary";
            this.BtnPrimary.Size = new System.Drawing.Size(94, 33);
            this.BtnPrimary.TabIndex = 23;
            this.BtnPrimary.Text = "Primary";
            this.BtnPrimary.UseVisualStyleBackColor = false;
            this.BtnPrimary.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(530, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Secondary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.Tomato;
            // 
            // LblTotalCards
            // 
            this.LblTotalCards.AutoSize = true;
            this.LblTotalCards.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCards.Location = new System.Drawing.Point(75, 605);
            this.LblTotalCards.Name = "LblTotalCards";
            this.LblTotalCards.Size = new System.Drawing.Size(21, 22);
            this.LblTotalCards.TabIndex = 29;
            this.LblTotalCards.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cards:";
            // 
            // CboStyle
            // 
            this.CboStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboStyle.FormattingEnabled = true;
            this.CboStyle.Items.AddRange(new object[] {
            "Mini",
            "Cart",
            "Thumbnail",
            "Custom"});
            this.CboStyle.Location = new System.Drawing.Point(796, 314);
            this.CboStyle.Name = "CboStyle";
            this.CboStyle.Size = new System.Drawing.Size(131, 32);
            this.CboStyle.TabIndex = 32;
            this.CboStyle.Text = "   - Style -";
            this.CboStyle.SelectedIndexChanged += new System.EventHandler(this.CboView_SelectedIndexChanged);
            // 
            // ImageDialog
            // 
            this.ImageDialog.BackColor = System.Drawing.Color.White;
            this.ImageDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageDialog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageDialog.Location = new System.Drawing.Point(1018, 547);
            this.ImageDialog.Name = "ImageDialog";
            this.ImageDialog.Size = new System.Drawing.Size(57, 33);
            this.ImageDialog.TabIndex = 34;
            this.ImageDialog.Text = "...";
            this.ImageDialog.UseVisualStyleBackColor = false;
            this.ImageDialog.Click += new System.EventHandler(this.ImageDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(980, 600);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 33);
            this.BtnDelete.TabIndex = 35;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.White;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(890, 600);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(95, 33);
            this.BtnUpdate.TabIndex = 36;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.CboLayout);
            this.Wrapper.Controls.Add(this.button2);
            this.Wrapper.Controls.Add(this.CboCategory);
            this.Wrapper.Controls.Add(this.BtnUpdate);
            this.Wrapper.Controls.Add(this.TxtSearch);
            this.Wrapper.Controls.Add(this.BtnDelete);
            this.Wrapper.Controls.Add(this.LblTotalQty);
            this.Wrapper.Controls.Add(this.ImageDialog);
            this.Wrapper.Controls.Add(this.LvCart);
            this.Wrapper.Controls.Add(this.cardContainer1);
            this.Wrapper.Controls.Add(this.BtnReset);
            this.Wrapper.Controls.Add(this.CboStyle);
            this.Wrapper.Controls.Add(this.LblTotal);
            this.Wrapper.Controls.Add(this.label6);
            this.Wrapper.Controls.Add(this.BtnRefresh);
            this.Wrapper.Controls.Add(this.LblTotalCards);
            this.Wrapper.Controls.Add(this.label2);
            this.Wrapper.Controls.Add(this.button1);
            this.Wrapper.Controls.Add(this.label1);
            this.Wrapper.Controls.Add(this.BtnPrimary);
            this.Wrapper.Controls.Add(this.label3);
            this.Wrapper.Controls.Add(this.CboTheme);
            this.Wrapper.Controls.Add(this.TxtTitle);
            this.Wrapper.Controls.Add(this.CboOrder);
            this.Wrapper.Controls.Add(this.TxtSubtitle);
            this.Wrapper.Controls.Add(this.BtnSave);
            this.Wrapper.Controls.Add(this.TxtImagePath);
            this.Wrapper.Controls.Add(this.label5);
            this.Wrapper.Controls.Add(this.lblprice);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1088, 647);
            this.Wrapper.TabIndex = 37;
            // 
            // CboLayout
            // 
            this.CboLayout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLayout.FormattingEnabled = true;
            this.CboLayout.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.CboLayout.Location = new System.Drawing.Point(945, 314);
            this.CboLayout.Name = "CboLayout";
            this.CboLayout.Size = new System.Drawing.Size(131, 32);
            this.CboLayout.TabIndex = 39;
            this.CboLayout.Text = "   - Layout -";
            this.CboLayout.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(888, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 38;
            this.button2.Text = "Actual";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CboCategory
            // 
            this.CboCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCategory.FormattingEnabled = true;
            this.CboCategory.Items.AddRange(new object[] {
            "Snack",
            "Softdrinks"});
            this.CboCategory.Location = new System.Drawing.Point(13, 9);
            this.CboCategory.Name = "CboCategory";
            this.CboCategory.Size = new System.Drawing.Size(153, 32);
            this.CboCategory.TabIndex = 37;
            this.CboCategory.Text = " - Category -";
            this.CboCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // cardContainer1
            // 
            this.cardContainer1.BackColor = System.Drawing.Color.White;
            this.cardContainer1.Layout = DynamicCard.Layout.Vertical;
            this.cardContainer1.Location = new System.Drawing.Point(12, 55);
            this.cardContainer1.Name = "cardContainer1";
            this.cardContainer1.OrderBy = DynamicCard.OrderBy.ASCENDING;
            this.cardContainer1.Primary = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.cardContainer1.Secondary = System.Drawing.Color.Crimson;
            this.cardContainer1.Size = new System.Drawing.Size(761, 528);
            this.cardContainer1.Style = DynamicCard.Style.Mini;
            this.cardContainer1.TabIndex = 33;
            this.cardContainer1.Theme = DynamicCard.Themes.Light;
            // 
            // DynamicCardDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1088, 647);
            this.Controls.Add(this.Wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(546, 49);
            this.MaximizeBox = false;
            this.Name = "DynamicCardDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DynamicCard Demo | kitchanismo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.Label LblTotalQty;
        public System.Windows.Forms.ListView LvCart;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnRefresh;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtSubtitle;
        private System.Windows.Forms.TextBox TxtImagePath;
        public System.Windows.Forms.Label lblprice;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CboOrder;
        private System.Windows.Forms.ComboBox CboTheme;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnPrimary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        public System.Windows.Forms.Label LblTotalCards;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboStyle;
        private CardContainer cardContainer1;
        private System.Windows.Forms.Button ImageDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.ComboBox CboCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CboLayout;
    }
}