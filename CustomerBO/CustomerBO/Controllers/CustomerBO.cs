// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerBO.Controllers
{
    public class CustomerBO
    {
        private List<CustomerModel> customers = new List<CustomerModel>
        {
            new CustomerModel{Id=1, CName="Anil", City="Ahmedabad"},
            new CustomerModel{Id=2, CName="Bharath", City="Bengaluru"},
            new CustomerModel{Id=3, CName="Charan", City="Chennai"},
            new CustomerModel{Id=4, CName="Dhanush", City="Delhi"}
        };
        public List<CustomerModel> GetAll()
        {
            return customers;
        }

        public CustomerModel Get(int id)
        {
            return customers.Single(x => x.Id == id);
        }
    }
}
