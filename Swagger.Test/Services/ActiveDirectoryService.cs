using System;
using System.Collections.Generic;
using System.ComponentModel;
using Swagger.Test.Models;

namespace Swagger.Test.Services
{
    public class ActiveDirectoryService
    {
        private readonly List<ActiveDirectoryUser> _users;
        private readonly List<ActiveDirectoryComputer> _computers;

        public ActiveDirectoryService()
        {
            _users = FillUsers();
            _computers = FillComputers();
        }

        private List<ActiveDirectoryUser> FillUsers()
        {
            ActiveDirectoryUser oleg = new ActiveDirectoryUser(Guid.NewGuid(), "CN=Абрамов Олег, OU=Users, DC=local", true);
            ActiveDirectoryUser bulat = new ActiveDirectoryUser(Guid.NewGuid(), "CN=Шарипов Булат, OU=Users, DC=local", true);
            ActiveDirectoryUser dogger = new ActiveDirectoryUser(Guid.NewGuid(), "CN=Доггер Тесто Пеструн, OU=Users, DC=local");

            return new List<ActiveDirectoryUser>()
            {
                oleg, bulat, dogger
            };
        }

        private List<ActiveDirectoryComputer> FillComputers()
        {
            ActiveDirectoryComputer olegComputer = new ActiveDirectoryComputer(Guid.NewGuid(), "CN=OLEG-PC, OU=Local Machines, DC=local", "178.205.111.69");
            ActiveDirectoryComputer bulatComputer = new ActiveDirectoryComputer(Guid.NewGuid(), "CN=CoolBulat2009-PC, OU=Local Machines, DC=local", "178.205.228.128");
            ActiveDirectoryComputer doggerComputer = new ActiveDirectoryComputer(Guid.NewGuid(), "CN=Pestrun-PC, OU=Local Machines, DC=local", "192.168.228.69");

            return new List<ActiveDirectoryComputer>()
            {
                olegComputer, bulatComputer, doggerComputer
            };
        }

        public List<ActiveDirectoryUser> GetUsers() => _users;
        public List<ActiveDirectoryComputer> GetComputers() => _computers;
    }
}