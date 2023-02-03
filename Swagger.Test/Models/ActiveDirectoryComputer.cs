using System;

namespace Swagger.Test.Models
{
    public class ActiveDirectoryComputer
    {
        public Guid Guid { get; set; }
        public string DistinguishedName { get; set; }
        public string HostAddress { get; set; }

        public ActiveDirectoryComputer(Guid guid, string dn, string hostAddress)
        {
            Guid = guid;
            DistinguishedName = dn;
            HostAddress = hostAddress;
        }
    }
}