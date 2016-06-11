using super.web.market.bll;
using super.web.market.dal;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace super.web.market.api.Controllers
{
    public abstract class BaseController<T, M> : ApiController where T : BaseHandler<M>, new() where M : Model, new()
    {
        private T _handler = new T();

        //Get List
        [Authorize]
        public async Task<IHttpActionResult> Get()
        {
            
            HttpResponseMessage response = null;
            try
            {
                var list = await _handler.Retrieve();
                ReturnData retData = new ReturnData(CodeStatus.Ok, "Data Successful");
                retData.Data = list;
                response = Request.CreateResponse((HttpStatusCode)200, retData);
            }
            catch (BaseException e)
            {
                response = Request.CreateResponse((HttpStatusCode)510, new ReturnData((CodeStatus)e.Code, e.Message));
            }
            return new ResponseMessageResult(response);
        }

        [Authorize]
        //Get By Id
        public string Get(int id)
        {
            return "value";
        }

        [Authorize]
        //Insert
        public async Task<IHttpActionResult> Post(M baseObject)
        {
            HttpResponseMessage response = null;
            try
            {
                var auxObject = await _handler.Create(baseObject);
                ReturnData retData = new ReturnData(CodeStatus.Ok, "Data Created Successfully");
                retData.Data = auxObject;
                response = Request.CreateResponse((HttpStatusCode)200, retData);
            }
            catch (BaseException e)
            {
                response = Request.CreateResponse((HttpStatusCode)510, new ReturnData((CodeStatus)e.Code, e.Message));
            }
            return new ResponseMessageResult(response);
        }

        [Authorize]
        //Update
        public async Task<IHttpActionResult> Put(int id, M baseObject)
        {
            HttpResponseMessage response = null;
            try
            {
                await _handler.Update(id, baseObject);
                ReturnData retData = new ReturnData(CodeStatus.Ok, "Data Updated Successfully");
                retData.Data = baseObject;
                response = Request.CreateResponse((HttpStatusCode)200, retData);
            }
            catch (BaseException e)
            {
                response = Request.CreateResponse((HttpStatusCode)510, new ReturnData((CodeStatus)e.Code, e.Message));
            }
            return new ResponseMessageResult(response);
        }

        [Authorize]
        // Delete
        public async Task<IHttpActionResult> Delete(int id)
        {
            HttpResponseMessage response = null;
            try
            {
                await _handler.Delete(id);
                ReturnData retData = new ReturnData(CodeStatus.Ok, "Data Deleted Successfully");
                retData.Data = id;
                response = Request.CreateResponse((HttpStatusCode)200, retData);
            }
            catch (BaseException e)
            {
                response = Request.CreateResponse((HttpStatusCode)510, new ReturnData((CodeStatus)e.Code, e.Message));
            }
            return new ResponseMessageResult(response);
        }
    }
}