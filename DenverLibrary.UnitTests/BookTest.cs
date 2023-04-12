namespace DenverLibrary.UnitTests
{
    public class BookTest
    {
        [Fact]
        public void Createdwith_Correct_Property_Values()
        {
            Book book1 = new Book("Magnus Chase", "Rick Riordan");
            Assert.Equal("Magnus Chase", book1.Title);
            Assert.Equal("Rick Riordan", book1.Author);
        }

    }
}