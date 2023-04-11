using BLL.DTOs;
using BLL.Service;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
                var members = MemberService.GetMembers();
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, members));

            }
            catch (System.Exception)
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
                var member = MemberService.GetMember(id);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, member));
            }
            catch (System.Exception)
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
                var result = MemberService.DeleteMember(id);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, result));
            }
            catch (System.Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }
        [HttpPost]
        [Route("api/members")]
        public IHttpActionResult Post([FromBody]MemberDto memberDto)
        {
            try
            {
                var result = MemberService.CreateMember(memberDto);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, result));
            }
            catch (System.Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }
    }
}
