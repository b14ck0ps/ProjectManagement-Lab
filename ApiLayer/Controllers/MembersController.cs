using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Service;

namespace ApiLayer.Controllers
{
    public class MembersController : ApiController
    {
        [HttpGet]
        [Route("api/members")]
        public IHttpActionResult Get()
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, MemberService.GetMembers()));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpGet]
        [Route("api/members/{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, MemberService.GetMember(id)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpDelete]
        [Route("api/members/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, MemberService.DeleteMember(id)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpPost]
        [Route("api/members")]
        public IHttpActionResult Post([FromBody] MemberDto memberDto)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK,
                    MemberService.CreateMember(memberDto)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }
    }
}