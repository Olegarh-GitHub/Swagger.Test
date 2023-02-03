using System;

namespace Swagger.Test.Models
{
    public class ActiveDirectoryUser
    {
        public Guid Guid { get; set; }
        public string DistinguishedName { get; set; }
        public bool IsDomainAdministrator { get; set; }

        public ActiveDirectoryUser(Guid guid, string dn, bool isAdmin = false)
        {
            Guid = guid;
            DistinguishedName = dn;
            IsDomainAdministrator = isAdmin;
        }
    }
}