using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private string phone; // Changed to string to keep the leading zero

        //Public properties
        public int MemberId
        {
            get { return memberId; }
            private set //Private setter makes it read-only outside the class
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than zero.");
                }
            }
        }
        public string Name
        {
            get { return name; } //get method
            set
            {
                //Ensure that the name does not contain any digits
                if (!value.Any(char.IsDigit) && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Name cannot contain blank or contain numbers.");
                }
            }
        }

        public string Address
        {
            get { return address; } //get method
            set { address = value; } //set method
        }

        public string Phone
        {
            get { return phone; } //get method
            set { phone = value; } //set method
        }

        //Constructor for new members
        public  Member (int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId; //Assign the camelCase parameter to the PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine();
        }
    }
}
