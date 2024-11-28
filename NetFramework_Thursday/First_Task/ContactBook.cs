namespace NetFramework_Thursday.First_Task
{
    internal class ContactBook
    {
        private Dictionary<string, string> Contacts;

        public ContactBook()
        {
            Contacts = new Dictionary<string, string>();
        }

        public void AddContact(string name, string phoneNumber)
        {
            if (!Contacts.ContainsKey(name))
            {
                Contacts[name] = phoneNumber;
            }
            else
            {
                Console.WriteLine("This number already exists");
            }
        }

        public void RemoveContact(string name)
        {
            if (!Contacts.ContainsKey(name))
            {
                Console.WriteLine("The number does not exist");
            }
            else
            {
                Contacts.Remove(name);
                Console.WriteLine("The number was deleted successfully");
            }
        }

        public string GetPhoneNumber(string name)
        {
            if (!Contacts.ContainsKey(name))
            {
                return "The number does not exist";

            }
            else
            {
                return Contacts[name];
            }
        }
    }
}
