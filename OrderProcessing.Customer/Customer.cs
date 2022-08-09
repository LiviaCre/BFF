namespace OrderProcessing.Customer
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;   
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
    }
}
