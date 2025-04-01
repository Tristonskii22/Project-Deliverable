using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Customer : Entity
    {
        public int ID { get; set; }
        public int ShoppingCartID {  get; set; }
        public string Address {  get; set; }
        public string Name { get; set; }
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Address { get; set; }
        //public int ShoppingCartId { get; set; }
        //public string Address
        //{ get; set; }
        //public int Id;
        //public string Name;
        //public string Address;



        //public int GetId()
        //{
        //    return Id;
        //}
        //public void SetId(int id)
        //{
        //    Id = id;
        //}
        //public string GetName()
        //{
        //    return Name;

        //}
        //public void SetName(string name)
        //{
        //    Name = name;
        //}
        //public string GetAddress()
        //{
        //    return Address;
        //}
        //public void SetAddress(string address)
        //{
        //    Address = address;
        //}


    }
}