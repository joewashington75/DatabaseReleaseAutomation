using System;

namespace EFCoreSeparateProject.Core.Domain
{
    public class AddressLine
    {
        public AddressLine(string line)
        {
            if (line.Length < 0)
                throw new ArgumentException();
            Line = line;
        }

        public string Line { get; private set; }
    }
}
