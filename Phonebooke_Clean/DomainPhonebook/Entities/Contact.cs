namespace DomainPhonebook.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; private set; }

        public string Lastname { get; private set; }

        public string Phonenumber { get; private set; }

        public string Company { get; private set; }

        public string Descriptaion { get; private set; }

        public DateTime CreateAt { get; private set; }

        public Contact()
        {

        }

        public Contact(string Name, string Lastname, string Phonenumber, string Company)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.Phonenumber = Phonenumber;
            this.Company = Company;
            this.CreateAt = DateTime.Now;
        }

        public void Update(string Name, string Lastname, string Phonenumber, string Company)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.Phonenumber = Phonenumber;
            this.Company = Company;
        }
    }
}
