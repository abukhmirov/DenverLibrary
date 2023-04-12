using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenverLibrary.UnitTests
{
    public class BranchTest
    {
        [Fact]
        public void Createdwith_Correct_Property_Values()
        {
            Branch branch1 = new Branch("Koebel");
            Assert.Equal("Koebel", branch1.Name);
            Assert.Equal(new List<Book>(), branch1.Books);
        }
        [Fact]
        public void Books_GetAddedTo_ListOfBooks()
        {
            Branch branch1 = new Branch("location1");
            Book book1 = new Book("Book Title", "Book Author");
            branch1.AddBook(book1);
            Assert.Equal(book1, branch1.Books.First());
        }
        [Fact]
        public void AuthorsList_Has_CorrectAuthors()
        {
            Book book1 = new Book("Title1", "Author1");
            Book book2 = new Book("Title2", "Author2");
            Branch branch1 = new Branch("location1");
            branch1.AddBook(book1);
            branch1.AddBook(book2);
            Assert.Equal(new List<string> { book1.Author, book2.Author }, branch1.AllAuthors());
        }
    }
}
