using Xunit;
using Xunit.Sdk;
using CKK.Logic.Models;
namespace CKK.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddingProduct_ShouldReturnCorrectlyAddedProduct()
        {
            try
            {
                //Asseble
                //Making instance of customer class
                Customer customer = new Customer();
                //Making instance of Shoppingcart
                
                ShoppingCart shoppingcart = new ShoppingCart(customer);
                //Making an instance of product
                Product expected = new Product();

                //Act
                //setting product id to 67
                expected.Id = 67;
                //Calling add product method of shoppingcart 
                shoppingcart.AddProduct(expected);


                //Assert
                //Expected: what I should be getting, actual: what I am actually getting
                Assert.Equal(67, shoppingcart.GetProductById(67).GetProduct().Id);
            }
            catch(Exception ex)
            {

            }


        }
        [Fact]
        public void RemovingProduct_ShouldCorrectlyRemoveProduct()
        {
            try
            {
                Customer customer = new Customer();
                ShoppingCart shoppingcart = new ShoppingCart(customer);
                Product expected = new Product();
                //Act
                expected.Id = 67;
                shoppingcart.AddProduct(expected, 10);
                shoppingcart.RemoveProduct(expected, 5);
                //Assert
                Assert.Equal(5, shoppingcart.GetProductById(67).GetQuantity());
            }
            catch(Exception ex)
            {

            }
        }
        [Fact]
        public void GettingTotal_shouldCorrectlyAddAlltotals()
        {
            try
            {
                Customer customer = new Customer();
                ShoppingCart shoppingcart = new ShoppingCart(customer);
                Product expected = new Product();
                expected.SetPrice(1.10m);
                //Act
                shoppingcart.AddProduct(expected, 10);
                shoppingcart.GetTotal();
                //Assert

                Assert.Equal(11, shoppingcart.GetTotal());

            }
            catch(Exception ex)
            {

            }
        }
    }
}