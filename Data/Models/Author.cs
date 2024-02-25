namespace BookApi.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigations Properties
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
