using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CategoriesProducts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            dgCategory.ItemsSource = GetCategories();
            dgCategory.Columns[2].Visibility = Visibility.Collapsed;
        }

        private IEnumerable GetCategories()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Categories.ToList();
            }
        }

        private void dgCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Categories cat = dgCategory.SelectedItem as Categories;
            if (cat != null) dgProducts.ItemsSource = GetProducts(cat);
        }

        private List<Products> GetProducts(Categories cat)
        {
            if (cat == null) return null;
            using(var context = new EF_DBEntities())
            {
                return context.Products.ToList().FindAll(x => x.CategoryId == cat.Id);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var product = dgProducts.SelectedItem as Products;
            if (product != null)
            {
                using(var context = new EF_DBEntities())
                {
                    context.Products.Attach(product);
                    context.Products.Remove(product);
                    context.SaveChanges();
                }

                var category = dgCategory.SelectedItem as Categories;
                RefreshGUI();
                dgProducts.ItemsSource = GetProducts(category);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var category = dgCategory.SelectedItem as Categories;
            if (category != null)
            {
                var product = new Products
                {
                    Categories = category,
                    Name = txtName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = double.Parse(txtPrice.Text)
                };

                using(var context = new EF_DBEntities())
                {
                    context.Categories.Attach(category);
                    context.Products.Add(product);
                    context.SaveChanges();
                }

                RefreshGUI();
                dgProducts.ItemsSource = GetProducts(category);
            }
        }
    }
}
