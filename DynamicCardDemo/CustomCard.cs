using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicCard;

// set Style to Custom in properties of CardContainer to unlock the custom card

namespace DynamicCardDemo
{
    public partial class CustomCard : Card // base class 
    {
        public CustomCard() // dont remove
        {
        }

        public CustomCard(CardArgs args)
        {
            InitializeComponent();
            InitializeArgs(args);
        }

        private async void InitializeArgs(CardArgs args)
        {
            CardArgs = args;

            InitializeControls(args);

            // base on the size of picture box
            // the lower the Resolution the faster to load
            // resize manually, e.g, ResizeImageAsync(new Size(100,100))
            await ResizeImageAsync(CardImage.Size);

        }

        private void InitializeControls(CardArgs args)
        {
            LblTitle.Text = args.Title;
            LblSubtitle.Text = args.Subtitle;

            if (args.Details == null)
                return;

            foreach (var value in args.Details.Values)
                TxtArea.Text = value.ToString();

        }

        // by overriding the Theme method, you can custom the theme
        // comment/remove this method, if you want to use the default setup
        public override void Theme(Themes theme, Color primary, Color secondary)
        {
            switch (theme)
            {
              case Themes.Dark:
                    BackColor = Color.Goldenrod;
                    break;
              case Themes.Light:
                    BackColor = Color.Gold;
                    break;
              default:
                   // ...
                    break;
            }

            button1.BackColor = primary;
            LblSubtitle.ForeColor = secondary;
        }


    }
}
