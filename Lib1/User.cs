namespace Lib1
{
    public abstract class User
    {
        public string UserName { get; set; }
        protected string Email { get; set; }
        protected string Street { get; set; }
        protected string City { get; set; }
        protected string PostalCode { get; set; }
        public abstract string GetAddress();
    }

    
}