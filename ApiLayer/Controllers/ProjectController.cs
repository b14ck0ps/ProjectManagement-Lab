using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Service;

namespace ApiLayer.Controllers
{
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/projects")]
        public IHttpActionResult Get()
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, ProjectService.GetProjects()));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpGet]
        [Route("api/projects/{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, ProjectService.GetProject(id)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpDelete]
        [Route("api/projects/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, ProjectService.DeleteProject(id)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpPost]
        [Route("api/projects")]
        public IHttpActionResult Post([FromBody] ProjectDto projectDto)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK,
                    ProjectService.CreateProject(projectDto)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpPut]
        [Route("api/projects")]
        public IHttpActionResult Put([FromBody] ProjectDto projectDto)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK,
                    ProjectService.UpdateProject(projectDto)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpGet]
        [Route("api/projects/status/{status}")]
        public IHttpActionResult GetProjectsByStatus(string status)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK,
                    ProjectService.GetProjectsByStatus(status)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }

        [HttpGet]
        [Route("api/projects/status/{status}/date/{date}")]
        public IHttpActionResult GetProjectsByStatusAndDate(string status, DateTime date)
        {
            try
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK,
                    ProjectService.GetProjectsByStatusAndDate(status, date)));
            }
            catch (Exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }
    }
}