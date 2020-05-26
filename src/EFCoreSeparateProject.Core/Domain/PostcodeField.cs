using System;

namespace EFCoreSeparateProject.Core.Domain
{
    public class PostcodeField
    {
        public string Postcode { get; private set; }
        public PostcodeField(string postcode)
        {
            if (postcode.Length < 1 || postcode.Length > 8)
                throw new ArgumentException("Postcode should be between 1 and 8 characters");
            Postcode = postcode;
        }
    }
}
