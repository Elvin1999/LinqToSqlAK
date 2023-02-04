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

namespace LinqToSqlAK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LibraryDataClassesDataContext dtx = new LibraryDataClassesDataContext();

            //var result = from b in dtx.Books
            //             where b.Pages > 500
            //             select b;

            //var result1 = dtx.Books
            //    .Where(b => b.Pages > 500);

            //myDataGrid.ItemsSource = result;



            //var result = from b in dtx.Books
            //             where b.Pages >= (dtx.Books.Max(i => i.Pages))
            //             select new { Name=b.Name,Page=b.Pages };

            //var result = from b in dtx.Books
            //             where b.Pages >= (dtx.Books.Max(i => i.Pages))
            //             select new BookDto { Name = b.Name, Page = b.Pages };

            //var result = from a in dtx.Authors
            //             where a.Id == 1
            //             select new {Name=a.FirstName,Surname=a.LastName};

            //var result = from sc in dtx.S_Cards
            //             group sc by sc.Id_Book into mygroup
            //             select new { mygroup.Key, mygroup.First().Book.Name, mygroup.First().Student.FirstName };

            //var result = from sc in dtx.S_Cards
            //             group sc by sc.Id_Book into mygroup
            //             select new { BookId=mygroup.Key, Total=mygroup.Count() };

            //var result = from b in dtx.Books
            //             join a in dtx.Authors on b.Id_Author equals a.Id
            //             join sc in dtx.S_Cards on b.Id equals sc.Id_Book
            //             select new { BookName = b.Name, AuthorFullname = a.FirstName + "-" + a.LastName,StudentName=sc.Student.FirstName };

            //myDataGrid.ItemsSource = result;


            //dtx.Books.InsertOnSubmit(new Book
            //{
            //    Id=4555,
            //    Name="My Sugar Book",
            //    Pages=11111,
            //    YearPress=2022,
            //    Id_Author=1,
            //    Id_Category=1,
            //    Id_Press=1,
            //    Id_Themes=1
            //});

            //dtx.SubmitChanges();

            //var book = dtx.Books.FirstOrDefault(b => b.Id == 4555);
            //book.Name = "I update name of this book";
            //dtx.SubmitChanges();


            //var book = dtx.Books.FirstOrDefault(b => b.Id == 4555);
            //dtx.Books.DeleteOnSubmit(book);

            //dtx.SubmitChanges();

            //var deletedBooks = from b in dtx.Books
            //                   where b.Pages > 800
            //                   select b;

            //dtx.Books.DeleteAllOnSubmit(deletedBooks);

            //dtx.SubmitChanges();

            //var result = from b in dtx.Books
            //             orderby b.Pages
            //             select b;

            //myDataGrid.ItemsSource = result;
        }
    }
}
