namespace BankCustomerFollow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name =" enes yaprak";
            customer.Id = 001;
            customer.AccountBalance = 10000;
            
            Customer customer1 = new Customer();
            customer1.Name = "Engin Demiroğ";
            customer1.Id = 002;
            customer1.AccountBalance = 5000000;
        

        CustomerManager customermanager = new CustomerManager();

            customermanager.Add(customer);
            customermanager.Remove(customer);

            customermanager.Add(customer1);
            customermanager.Remove(customer1);




        }
    }
}
