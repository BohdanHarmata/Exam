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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ActiveFilter(object sender, RoutedEventArgs e)
        {

            string searchString = nameFilter.Text;
            List<Article> newArticles = new List<Article>();
            newArticles = Store.article;
            newArticles = newArticles.FindAll(x => x.Name.Contains(nameFilter.Text));
            LoadArticle(newArticles);

        }
        private void LoadArticle(List<Article> article)
        {
            ArticleList.Items.Clear();

            for (int i = 0; i < article.Count; i++)
            {
                ArticleList.Items.Add(article[i]);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Store.article.Add(new Article(textBox1.Text, textBox2.Text, textBox3.Text));
            LoadArticle(Store.article);
        }

        
    }

}
