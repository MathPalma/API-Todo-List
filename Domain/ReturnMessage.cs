namespace Domain
{
    public class ReturnMessage<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public T Object { get; set; }

        public ReturnMessage(int statusCode, string message, T @object)
        {
            StatusCode = statusCode;
            Message = message;
            Object = @object;
        }

        public ReturnMessage(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ReturnMessage() { }
    }
}

