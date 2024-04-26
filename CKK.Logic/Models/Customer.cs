namespace CKK.Logic.Models
{
    public class Customer
    {
        public int Id;
        public string Name;
        public string Address;

        public int GetID()
        {
            return Id;
        }
        public void SetID(int id)
        {
            Id = id;
        }
        public string GetName()
        {
            return Name;

        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }


    }
}