using System.Collections.Generic;
using System.Net;

namespace Elsa.Activities.Http.Models
{
    public class HttpResponseModel
    {
        public HttpResponseModel()
        {
        }

        public HttpStatusCode StatusCode { get; set; }
        public Dictionary<string, string[]> Headers { get; set; } = new Dictionary<string, string[]>();
        public byte[] Content { get; set; }
        public object ParsedContent { get; set; }
    }
}