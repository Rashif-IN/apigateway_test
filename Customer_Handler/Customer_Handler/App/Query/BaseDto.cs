using System;
namespace cqrs_Test.Application.Models.Query
{
    public class BaseDto
    {
        public bool Status { set; get; }
        public string Message { set; get; }
    }
    public class Auth
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class RequestData<T>
    {
        public Data<T> Dataa { get; set; }
    }
    public class Data<T>
    {
        public T Attributes { get; set; }
    }
}
