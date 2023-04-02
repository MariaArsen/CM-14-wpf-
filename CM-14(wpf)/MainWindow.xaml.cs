using Caliburn.Micro;
using Google.Api.Ads.AdWords.v201809;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CM_14_wpf_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                 ProductName="Молоко",
                 ProductCost=90,
                 ProductImage="Data/milk.jpg",
                 ProductType =ProductTypes.Foods
            });
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductCost = 65,
                ProductImage = "Data/bread.jpg",
                ProductType = ProductTypes.Foods
            });
            products.Add(new Product()
            {
                ProductName = "Творог",
                ProductCost = 120,
                ProductImage = "Data/curd.jpg",
                ProductType = ProductTypes.Foods
            });
            products.Add(new Product()
            {
                ProductName = "Кофемолка",
                ProductCost = 1500,
                ProductImage = "Data/coffe.jpg",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Соковыжималка",
                ProductCost = 2500,
                ProductImage = "Data/juice.jpg",
                ProductType = ProductTypes.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
