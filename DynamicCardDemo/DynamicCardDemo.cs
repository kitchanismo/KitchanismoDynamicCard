// Kitchanismo Dynamic Card
// Version 3.0
// Created by Kitchan Betsayda

// CardContainer Properties

// OrderBy  | Default 'ASCENDING'
// Style  | Default 'Mini'
// Themes  | Default 'Light'
// Layout  | Default 'Vertical'
// Primary  | Default '255,0,128'
// Secondary  | Default 'Crimson'

using System;
using System.Windows.Forms;
using DynamicCard;
using DynamicCard.Styles;

namespace DynamicCardDemo
{
    public partial class DynamicCardDemo : Form
    {
        public DynamicCardDemo()
        {
            InitializeComponent();
            InitializeCardEvent();
        }

        private void InitializeCardEvent()
        {
            cardContainer1.OnCount += HandlerCounted;
            cardContainer1.OnCount += DisplayDetails;
            cardContainer1.OnClick += DisplayDetails;
            cardContainer1.OnProgress += HandlerProgress;
            cardContainer1.OnLoaded += HandlerLoaded;
            cardContainer1.OnInvalid += HandlerInvalid;
        }

        private void HandlerInvalid(object sender, CardArgs args)
        {
            MessageBox.Show("Not Enough Stock!");
        }

        private void HandlerProgress(object sender, CardArgs args)
        {
            LblTotalCards.Text = args.TotalCards.ToString();
        }
        
        private void HandlerCounted(object sender, CardArgs args)
        {
            DisplayCart();
            LblTotalQty.Text = Cart.TotalQuantity.ToString();
            LblTotal.Text = Cart.Total.ToString();
        }

        private void HandlerLoaded(object sender, CardArgs args)
        {
            Wrapper.Enabled = true;
            LblTotalCards.Text = args.TotalCards.ToString();
        }

        //for delete and update
        private string _key;
        private CardArgs _cardArgs;

        private void DisplayDetails(object sender, CardArgs args)
        {
            TxtTitle.Text = args.Title;

            //just pick between Subtitle and Price to Show
            TxtSubtitle.Text  = (cardContainer1.Style == Style.Cart)  ? args.Price.ToString() : args.Subtitle;
            TxtImagePath.Text = args.ImagePath;

            _key = args.Key;
            _cardArgs = args;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var args = new CardArgs
            {
                Title     = TxtTitle.Text,
                Price     = (cardContainer1.Style == Style.Cart) ? double.Parse(TxtSubtitle.Text) : 0,
                Subtitle  = TxtSubtitle.Text,
                ImagePath = TxtImagePath.Text,
                Stock     = _cardArgs.Stock,
                Category  = _cardArgs.Category,
                Currency  = _cardArgs.Currency,
                Details = _cardArgs.Details
            };

            cardContainer1.Update<CustomCard>(_key, args);
        }

        private void DisplayCart()
        {
            LvCart.Items.Clear();
            foreach (var cart in Cart.List)
            {
                var list = LvCart.Items.Add(cart.Title).SubItems;
                list.Add(cart.Price.ToString());
                list.Add(cart.Quantity.ToString());
                list.Add((cart.Quantity * cart.Price).ToString());
            }
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            //just replace CustomCard with Card if custom is not use
            Wrapper.Enabled = false;
            await cardContainer1.AddRangeAsync<CustomCard>(Repository.GetCards(pageNumber));
        }
        
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtTitle.Text == "" || TxtSubtitle.Text == "" || TxtImagePath.Text == "") return;

            var args = new CardArgs
            {
                Key       = Guid.NewGuid().ToString(),
                Title     = TxtTitle.Text,
                Price     = (cardContainer1.Style == Style.Cart) ? double.Parse(TxtSubtitle.Text) : 0,
                Subtitle  = TxtSubtitle.Text,
                ImagePath = TxtImagePath.Text,
                Stock     = 10,
                Category  = "Snack",
                Currency  = "Php",
                Details   = null
            };

            await cardContainer1.AddAsync<CustomCard>(args);
            EmptyField();
        }


        private int pageNumber = 1;

        private async void button2_Click(object sender, EventArgs e)
        {
            Wrapper.Enabled = false;
            await cardContainer1.AddRangeAsync<CustomCard>(Repository.GetCards(pageNumber));
            Clear();
        }

        private async void BtnReset_Click(object sender, EventArgs e)
        {
            Wrapper.Enabled = false;
            await cardContainer1.AddRangeAsync<CustomCard>(Repository.GetDummyCards(pageNumber));
            Clear();
        }
        
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await cardContainer1.FilterAsync(TxtSearch.Text);
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await cardContainer1.FilterAsync();
            TxtSearch.Text = "";
        }

        private void CboOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardContainer1.OrderBy = (CboOrder.Text == "DES")
                ? OrderBy.DESCENDING
                : OrderBy.ASCENDING;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardContainer1.Theme = (CboTheme.Text == "Dark")
                ? Themes.Dark
                : Themes.Light;
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            cardContainer1.Layout = (CboLayout.Text == "Vertical")
                ? DynamicCard.Layout.Vertical
                : DynamicCard.Layout.Horizontal;
        }

        private async void CboView_SelectedIndexChanged(object sender, EventArgs e)
        {

            Wrapper.Enabled = false;
            
            Style view;

            switch (CboStyle.Text)
            {
                case "Mini":
                    view = Style.Mini;
                    lblprice.Text = "Subtitle";
                    break;
                case "Cart":
                    view = Style.Cart;
                    lblprice.Text = "Price";
                    break;
                case "Thumbnail":
                    view = Style.Thumbnail;
                    lblprice.Text = "Subtitle";
                    break;
                default:
                    view = Style.Custom;
                    break;
            }

            cardContainer1.Style = view;
            await cardContainer1.AddRangeAsync<CustomCard>(Repository.GetCards(pageNumber));
            Clear();
        }

        private void ImageDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG (*.jpg) |*.jpg|PNG (*.png) |*.png|(*.*) |*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
                TxtImagePath.Text = openFileDialog1.FileName;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            cardContainer1.Delete(_key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            cardContainer1.Primary = colorDialog1.Color;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            cardContainer1.Secondary = colorDialog2.Color;
        }
        
        private void Clear()
        {
            LvCart.Items.Clear();
            EmptyField();
        }

        private void EmptyField()
        {
            TxtTitle.Text = "";
            TxtSubtitle.Text = "";
            TxtImagePath.Text = "";
            LblTotalQty.Text = "";
            LblTotal.Text = "";
        }
        
        private async void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            await cardContainer1.FilterByCategoryAsync(CboCategory.Text);
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            await cardContainer1.AddRangeAsync<CustomCard>(Repository.GetCards(++pageNumber));
        }

        private async void BtnPrev_Click(object sender, EventArgs e)
        {
           await cardContainer1.AddRangeAsync<CustomCard>(Repository.GetCards(--pageNumber));
        }
    }

}
