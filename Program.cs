using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        Book book1 = new Book("C# Methods and classes", "Microsoft", "55667778");

        book.DisplayInfo();
        book1.DisplayInfo();

        //Create new instance of the Member class
        //These new members are created using Member contructor in the Members class
        Member member = new Member (1, "John Smith", "1 High Street", "0790090090");
        Member member1 = new Member (2, "Mary Jones", "102 Garden Road", "0790345666");

        // Testing the validation logic with invalid data
        Member invalidMember = new Member(-5, "Rob0t C0p", "50 Main Street", "07811223344");

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }   
}