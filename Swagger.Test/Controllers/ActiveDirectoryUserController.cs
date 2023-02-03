using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swagger.Test.Services;

namespace Swagger.Test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActiveDirectoryUserController : Controller
    {
        private readonly ActiveDirectoryService _service;

        public ActiveDirectoryUserController(ActiveDirectoryService service)
        {
            _service = service;
        }

        /// <summary>
        /// Возвращает все доступные на домене учетные записи пользователей
        /// </summary>
        /// <returns><see cref="List{T}"/></returns>
        [Route("users")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Json(_service.GetUsers());
        }

        /// <summary>
        /// Возвращает все доступные на домене учетные записи для компьютеров
        /// </summary>
        /// <returns><see cref="List{T}"/></returns>
        [Route("computers")]
        [HttpGet]
        public IActionResult GetComputers()
        {
            return Json(_service.GetComputers());
        }

        /// <summary>
        /// Возвращает учетную запись пользователя с указанным DN
        /// </summary>
        /// <param name="dn"></param>
        /// <returns></returns>
        [Route("users/{dn}")]
        [HttpGet]
        public IActionResult GetUserWithDN(string dn)
        {
            return Json(_service.GetUsers().FirstOrDefault(user => string.Equals(user.DistinguishedName, dn)));
        }

        /// <summary>
        /// Возвращает компьютер с указанным именем хоста
        /// </summary>
        /// <param name="host">Имя хоста</param>
        [Route("computers/{host}")]
        [HttpGet]
        public IActionResult GetComputerWithNeededHost(string host)
        {
            return Json(_service.GetComputers().FirstOrDefault(computer => string.Equals(computer.HostAddress, host)));
        }
    }
}