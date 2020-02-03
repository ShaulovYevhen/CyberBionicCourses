namespace BookApp.Model
{
    public class Book
    {
        private readonly Title _title;
        private readonly Author _author;
        private readonly Content _content;
        public Book(Title title, Author author, Content content)
        {
            _title = title;
            _author = author;
            _content = content;
        }

        public override string ToString()
        {
            return $"{nameof(_title)}: {_title}, {nameof(_author)}: {_author}, {nameof(_content)}: {_content}";
        }
    }
}