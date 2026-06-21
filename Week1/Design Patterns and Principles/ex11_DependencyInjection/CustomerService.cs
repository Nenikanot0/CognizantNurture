public class CustomerService
{
    private CustomerRepository repository;

    public CustomerService(CustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        string customer = repository.FindCustomerById(id);
        System.Console.WriteLine(customer);
    }
}