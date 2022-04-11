namespace Execute
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    public class HttpParams
    {
        private string uri;
        private HttpMethod method;
        private Hashtable headers;
        private CookieCollection cookies;
        private string content_type;
        private string body;
        private string file_path;
        private Dictionary<string, HttpMethod> methods = new Dictionary<string, HttpMethod>(){
            {"get",HttpMethod.Get},
            {"head",HttpMethod.Head},
            {"post",HttpMethod.Post},
            {"put",HttpMethod.Put},
            {"delete",HttpMethod.Delete},
            {"options",HttpMethod.Options},
            {"trace",HttpMethod.Trace}
        };
        public HttpParams()
        {
        }
        public string Uri
        {
            get => this.uri == null ? string.Empty : this.uri;
            set => this.uri = value;
        }
        public string Method
        {
            get => this.method == null ? "get" : this.method.ToString();
            set => this.method = methods[value.ToLower()];
        }
        public Hashtable Headers
        {
            get => this.headers == null ? null : this.headers;
            set => this.headers = value;
        }
        public CookieCollection Cookies
        {
            get => this.cookies == null ? null : this.cookies;
            set => this.cookies = value;
        }
        public string ContentType
        {
            get => this.content_type == null ? "application/x-www-form-urlencoded" : this.content_type;
            set => this.content_type = value;
        }
        public string Body
        {
            get => this.body == null ? String.Empty : this.body;
            set => this.body = value;
        }
        public string FilePath
        {
            get => this.file_path == null ? string.Empty : this.file_path;
            set => this.file_path = value;
        }
    }
    public class HttpRequest
    {
        private HttpParams http_params { get; set; }
        public HttpParams HttpParams
        {
            get => this.http_params;
            set => this.http_params = value;
        }
        public HttpRequest()
        {
        }
        public HttpRequest(string json_string)
        {
            this.http_params = JsonConvert.DeserializeObject<HttpParams>(json_string);
        }
    }
}