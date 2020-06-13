using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Assignment01.Models
{
    public class Repository
    {
        public static List<VisitorResponse> responses = new List<VisitorResponse>();

        public static IEnumerable<VisitorResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(VisitorResponse response)
        {
            responses.Add(response);
        }
    }
}
