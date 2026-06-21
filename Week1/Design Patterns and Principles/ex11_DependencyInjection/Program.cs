using System;

class Program
{
    static void Main(string[] args)
    {
        CustomerRepository repository =
            new CustomerRepositoryImpl();

        CustomerService service =
            new CustomerService(repository);

        service.GetCustomer(101);
    }
}