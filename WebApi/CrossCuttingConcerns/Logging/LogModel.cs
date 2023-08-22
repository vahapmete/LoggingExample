
using Google.Cloud.Firestore;

namespace WebApi.CrossCuttingConcerns.Logging
{
    [FirestoreData]
    public class LogModel
    {
        [FirestoreProperty]
        public string LogId { get; set; }           /*Guid.NewGuid().ToString()*/
        [FirestoreProperty] public string Node { get; set; }            /*project name*/
        [FirestoreProperty] public string ClientIp { get; set; }
        public string TraceId { get; set; }         /*HttpContext TraceIdentifier*/


        [FirestoreProperty] public DateTime? RequestDateTimeUtc { get; set; }
        [FirestoreProperty] public DateTime? RequestDateTimeUtcActionLevel { get; set; }
        [FirestoreProperty] public string RequestPath { get; set; }
        [FirestoreProperty] public string RequestQuery { get; set; }
        [FirestoreProperty] public List<KeyValuePair<string, string>> RequestQueries { get; set; }
        [FirestoreProperty] public string RequestMethod { get; set; }
        [FirestoreProperty] public string RequestScheme { get; set; }
        [FirestoreProperty] public string RequestHost { get; set; }
        [FirestoreProperty] public Dictionary<string, string> RequestHeaders { get; set; }
        [FirestoreProperty] public string RequestBody { get; set; }
        [FirestoreProperty] public string RequestContentType { get; set; }


        [FirestoreProperty] public DateTime? ResponseDateTimeUtc { get; set; }
        [FirestoreProperty] public DateTime? ResponseDateTimeUtcActionLevel { get; set; }
        [FirestoreProperty] public string ResponseStatus { get; set; }
        [FirestoreProperty] public Dictionary<string, string> ResponseHeaders { get; set; }
        [FirestoreProperty] public string ResponseBody { get; set; }
        [FirestoreProperty] public string ResponseContentType { get; set; }


        [FirestoreProperty] public bool? IsExceptionActionLevel { get; set; }
        [FirestoreProperty] public string ExceptionMessage { get; set; }
        [FirestoreProperty] public string ExceptionStackTrace { get; set; }

        public LogModel()
        {
            LogId = Guid.NewGuid().ToString();
        }
    }
}
