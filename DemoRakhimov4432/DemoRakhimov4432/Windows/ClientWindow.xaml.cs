using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoRakhimov4432.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using(var db = new Model())
            {
                var products = db.Product.ToList();
                foreach(var product in products)
                {
                    var mainPanel = new Grid();

                    mainPanel.ColumnDefinitions.Add(new ColumnDefinition());
                    mainPanel.ColumnDefinitions.Add(new ColumnDefinition());
                    mainPanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(100) });

                    var img = new Image() { Margin = new Thickness(10)};
                    try
                    {
                        img.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/Resorces/" + product.Image, UriKind.Absolute));
                    }
                    catch { }

                    TextBlock txtDesc = new TextBlock();
                    txtDesc.Text = product.Name + "\n" + product.Description + "\nПроизводитель: " + product.Manufacturer + "\nЦена: " + product.Price.ToString();

                    TextBlock txtDisxcount = new TextBlock() { FontFamily = new FontFamily("Candara")};
                    txtDisxcount.Text = product.Discount.ToString()+"%";
                    Grid.SetColumn(img,0);
                    Grid.SetColumn(txtDesc, 1);
                    Grid.SetColumn(txtDisxcount, 2);
                    mainPanel.Children.Add(img);
                    mainPanel.Children.Add(txtDesc);
                    mainPanel.Children.Add(txtDisxcount);
                    mainPanelMain.Children.Add(mainPanel);

                }
            }
        }
    }
}
