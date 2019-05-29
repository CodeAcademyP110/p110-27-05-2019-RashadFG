using System;

namespace indexer_extention_boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();

            phonebook["rashad"] = "051-373-92-77";
            phonebook["samir"] = "055-555-55-55";
            phonebook["aqil"] = "050-320-00-55";
            phonebook["wamil"] = "077-479-12-21";
            phonebook["wamil2"] = "077-479-12-21";
            phonebook["wamil3"] = "077-479-12-21";
            phonebook["wamil4"] = "077-479-12-21";


            Console.WriteLine(phonebook["rashad"]);
            Console.WriteLine(phonebook["samir"]);
            Console.WriteLine(phonebook["aqil"]);
            Console.WriteLine(phonebook["wamil"]);
            Console.WriteLine(phonebook["wamil2"]);
            Console.WriteLine(phonebook["wamil3"]);
            Console.WriteLine(phonebook["wamil4"]);


        }
    }

    public class PhoneBook
    {
        public int index = 0;
        public int Count = 0;
        public Members[] MemmbersArray;

        public PhoneBook()
        {
            MemmbersArray = new Members[10];
     
        }
        public string this[string name]
        {
            get
            {
                foreach (var item in MemmbersArray)
                {
                    if (item != null && name == item.Name)
                    {
                        return item.Number;
                    }
                }
                return null;
            }

            set
            {
                MemmbersArray[Count++] = new Members { Name = name, Number = value };
            }
        }
    }

    public class Members
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}

