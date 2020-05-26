namespace EFCoreSeparateProject.Core.Domain
{
    public class Address
    {
        private Address()
        {
            // required by EF
        }
        public Address(string line1, string line2, string postcode)
        {
            Line1 = new AddressLine(line1);
            Line2 = new AddressLine(line2);
            Postcode = new PostcodeField(postcode);
        }

        public AddressLine Line1 { get; private set; }
        public AddressLine Line2 { get; private set; }
        public PostcodeField Postcode { get; private set; }
    }
}
