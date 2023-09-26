namespace InterFace
{
    internal interface IUser
    {
        string Email { get; set; }
        string Login { get; }

        string Name { get; set; }
        string Password { get; set; }
        IAddress Address { get; set; }

        IEnumerable<string> OrderIds { get; set; }
    }
}