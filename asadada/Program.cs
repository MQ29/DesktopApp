namespace asadada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //no nie tak to ja nie bede pisal
            var book1 = new Book("Bracia Karamazov","Bardzo dobra lektura");
            book1.Introduce();
        }
    }

    public class Book 
    { 
        public string Title { get; set; }   
        public string Description { get; set; }

        public Book(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void Introduce()
        {
            Console.WriteLine(Title,Description);
        }
    }
}
