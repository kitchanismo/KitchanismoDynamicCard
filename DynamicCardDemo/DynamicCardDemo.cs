// Kitchanismo Dynamic Card
// Version 2.0.1
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
            cardContainer1.OnCount += HandlerCount;
        }
        
        private void HandlerCount(object sender, EventArgs e)
        {
            DisplayCart();
            LblTotalQty.Text = Card.TotalQuantity.ToString();
            LblTotal.Text    = Card.Total.ToString();
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
        
        private void Form2_Load(object sender, EventArgs e)
        {
            cardContainer1.AddRange(GetCards());
        }
      
        private static IEnumerable<CardArgs> GetCards()
        {
            var cards = new List<CardArgs>();

            var products = ProductRepository.GetAll();

            foreach (var product in products)
            {
                cards.Add(new CardArgs
                {
                    Key = product.Id.ToString(),
                    Title = product.Title,
                    Price = product.Price,
                    ImagePath = product.ImageSource
                });
            }
            return cards;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtTitle.Text == "" || TxtPrice.Text == "" || TxtImagePath.Text == "") return;
         
            if (cardContainer1.Add(GetCard()) != null)
            {
                MessageBox.Show("Added");
                EmptyField();
            }
        }

        private CardArgs GetCard()
        {
            return new CardArgs
            {
                Key = new Random().Next(100, 5000).ToString(),
                Title = TxtTitle.Text,
                Price = double.Parse((TxtPrice.Text == "") ? "0" : TxtPrice.Text),
                ImagePath = TxtImagePath.Text
            };
        }

        private void EmptyField()
        {
            TxtTitle.Text = "";
            TxtPrice.Text = "";
            TxtImagePath.Text = "";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            cardContainer1.Load(TxtSearch.Text); 
        }
        
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Clear();
            cardContainer1.Reset();
            cardContainer1.AddRange(GetCards());
        }

        private void Clear()
        {
            LvCart.Items.Clear();
            LblTotalQty.Text = "0";
            LblTotal.Text = "0";
            EmptyField();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            cardContainer1.Load();
            TxtSearch.Text = "";
        }

        private void CboOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardContainer1.OrderBy = (CboOrder.Text == "DES") ? cardContainer1.OrderBy = OrderBy.DESCENDING : OrderBy.ASCENDING;
            cardContainer1.Load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardContainer1.Theme = (CboTheme.Text == "Dark") ? Card.CardTheme.Dark : Card.CardTheme.Light;
            cardContainer1.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            cardContainer1.Primary = colorDialog1.Color;
            cardContainer1.Load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            cardContainer1.Secondary = colorDialog2.Color;
            cardContainer1.Load();
        }
    }
    
}
