using System.Security.Cryptography.X509Certificates;

namespace Lesson_07_HW
{
    internal class Program
    {

        public class phoneBook
        {
            public string PhoneNumber { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        static void Main(string[] args)
        {

            List<phoneBook> phoneNums = new List<phoneBook>();
            {
                new phoneBook() { PhoneNumber = "+38(099)1234567", FirstName = "Jonny", LastName = "Silverhand" };
                new phoneBook() { PhoneNumber = "+38(099)3515468", FirstName = "Nickolas", LastName = "Wangovsky" };
                new phoneBook() { PhoneNumber = "+38(099)2356488", FirstName = "Jacky", LastName = "Jackson" };
                new phoneBook() { PhoneNumber = "+38(099)9456784", FirstName = "Ben", LastName = "Benowich" };
            }

            List<phoneBook> result = SearchPhoneBook("Jonny", phoneNums);

            foreach (phoneBook contact in result)
            {
                Console.WriteLine("{0} {1}: {2}", contact.FirstName, contact.LastName, contact.PhoneNumber);
            }
        }

        public static List<phoneBook> SearchPhoneBook(string searchTerm, List<phoneBook> phoneBook)
        {
            List<phoneBook> results = new List<phoneBook>();

            foreach (phoneBook contact in phoneBook)
            {
                if (contact.FirstName.ToLower().Contains(searchTerm.ToLower()) || 
                    contact.LastName.ToLower().Contains(searchTerm.ToLower()) ||
                    contact.PhoneNumber.ToLower().Contains(searchTerm.ToLower()))
                {
                    results.Add(contact);
                }
            }

            return results;
        }
    }
}