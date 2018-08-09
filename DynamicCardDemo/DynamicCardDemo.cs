// Kitchanismo Dynamic Card
// Version 2.5.1
// Created by Kitchan Betsayda
// CardContainer Properties

// Currency | Default 'PHP'
// OrderBy  | Default 'ASCENDING'
// Theme  | Default 'Light'
// Primary  | Default '255,0,128'
// Secondary  | Default 'Crimson'

using DynamicCard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DynamicCardDemo
{
    public partial class DynamicCardDemo : Form
    {
        public DynamicCardDemo()
        {
            InitializeComponent();
            InitializeCard();
        }
        
        private void InitializeCard()
        {
            cardContainer1.OnCounted += HandlerCount;
            cardContainer1.OnLoaded += HandlerLoad;
        }
        
        private void HandlerCount(object sender, CardArgs args)
        {
            DisplayCart();
            DisplayDetails(args);
            LblTotalQty.Text = Card.TotalQuantity.ToString();
            LblTotal.Text = Card.Total.ToString();
        }

        private void HandlerLoad(object sender, CardArgs args)
        {
            LblTotalCards.Text = args.TotalCards.ToString();
        }

        private void DisplayDetails(CardArgs args)
        {
            TxtTitle.Text = args.Title;
            TxtPrice.Text = args.Price.ToString("N");
            TxtImagePath.Text = args.ImagePath;
        }

        private void DisplayCart()
        {
            LvCart.Items.Clear();
            
            foreach (var cart in Card.List)
            {
                var list = LvCart.Items.Add(cart.Title).SubItems;
                list.Add(cart.Price.ToString());
                list.Add(cart.Quantity.ToString());
                list.Add((cart.Quantity * cart.Price).ToString());
            }
        }
        
        private async void Form2_Load(object sender, EventArgs e)
        {
            await cardContainer1.AddRangeAsync(GetCards());
        }

       
        // test 100 data for responsiveness of async 
        private static IEnumerable<CardArgs> GetCards()
        {
            var cards = new List<CardArgs>();

            var products = new Array[100];

            foreach (var product in products)
            {
                cards.Add(new CardArgs
                {
                    Key = Guid.NewGuid().ToString(),
                    Title = Guid.NewGuid().ToString(),
                    Price = 10,
                    ImagePath = null,
                });
            }
            return cards;
        }

        //actual items in repository
        //private static IEnumerable<CardArgs> GetCards()
        //{
        //    var cards = new List<CardArgs>();

        //    var appPath = Application.StartupPath + @"\img\";

        //    var products = ProductRepository.GetAll();

        //    foreach (var product in products)
        //    {
        //        cards.Add(new CardArgs
        //        {
        //            Key = product.Id.ToString(),
        //            Title = product.Title,
        //            Price = product.Price,
        //            ImagePath = appPath + product.ImageSource,
        //        });
        //    }
        //    return cards;
        //}


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtTitle.Text == "" || TxtPrice.Text == "" || TxtImagePath.Text == "") return;
         
            if (cardContainer1.AddAsync(GetCard()) != null)
            {
                MessageBox.Show("Added");
                EmptyField();
            }
        }

        private CardArgs GetCard()
        {
            return new CardArgs
            {
                Key = Guid.NewGuid().ToString(),
                Title = TxtTitle.Text,
                Price = double.Parse((TxtPrice.Text == "") ? "0" : TxtPrice.Text),
                ImagePath = TxtImagePath.Text
            };
        }
        
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
           await cardContainer1.Load(TxtSearch.Text); 
        }
        
        private async void BtnReset_Click(object sender, EventArgs e)
        {
            cardContainer1.Reset();
            await cardContainer1.AddRangeAsync(GetCards());
            Clear();
        }

        private void Clear()
        {
            LvCart.Items.Clear();
            EmptyField();
        }

        private void EmptyField()
        {
            TxtTitle.Text = "";
            TxtPrice.Text = "";
            TxtImagePath.Text = "";
            LblTotalQty.Text = "";
            LblTotal.Text = "";
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await cardContainer1.Load();
            TxtSearch.Text = "";
        }

        private async void CboOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardContainer1.OrderBy = (CboOrder.Text == "DES") 
                ? cardContainer1.OrderBy = OrderBy.DESCENDING 
                : OrderBy.ASCENDING;
            await cardContainer1.Load();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardContainer1.Theme = (CboTheme.Text == "Dark") 
                ? Card.CardTheme.Dark 
                : Card.CardTheme.Light;
            await cardContainer1.Load();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            cardContainer1.Primary = colorDialog1.Color;
            await cardContainer1.Load();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            cardContainer1.Secondary = colorDialog2.Color;
            await cardContainer1.Load();
        }
    }
    
}
