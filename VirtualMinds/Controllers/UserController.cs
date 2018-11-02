using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VirtualMinds.Services;
using VirtualMinds.Models;

namespace VirtualMinds.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult GetUser()
        {
            try
            {
                var service = new UserServices();
                return Ok(service.GetUser());
            }
            catch (Exception)
            {

                return InternalServerError();
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteUser(Usuario user)
        {
            try
            {
                var service = new UserServices();
                service.DeleteUser(user);
                return Ok();
            }
            catch (Exception)
            {

                return InternalServerError();
            }
        }

        [HttpPost]
        public IHttpActionResult Save(Usuario user)
        {
            try
            {
                var service = new UserServices();
                service.Save(user);
                return Ok();
            }
            catch (Exception)
            {

                return InternalServerError() ;
            }
        }
    }
}
