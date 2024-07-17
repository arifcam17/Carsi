using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Shared.Response
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool Succeed { get; set; }

        public int StatusCode { get; set; }
        public string Error { get; set; }

        public static Response<T> Success(T data,int statusCode)
        {
             return new Response<T>{
                    Data=data,
                    StatusCode=statusCode,
                    Succeed=true
             };
        }



        public static Response<T> Success(int statusCode)
        {
            return new Response<T>{
                Data=default(T),
                StatusCode=statusCode,
                Succeed=true
            };
        }

        public static Response<T> Failure(string error,int statusCode)
        {
            return new Response<T>{
                 Error=error,
                 StatusCode=statusCode,
                 Succeed=false

            };
        }
    }
}