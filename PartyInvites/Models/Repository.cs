using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    //in-memory collection of objects
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        //static class - can not be instantiated
        public static IEnumerable<GuestResponse> Responses => responses; 

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public static void DeleteResponse(GuestResponse response)
        {
            responses.Remove(response);
        }


    }
}
 