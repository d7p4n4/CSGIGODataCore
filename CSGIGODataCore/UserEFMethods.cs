using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGIGODataCore
{
    public class UserEFMethods
    {
        public List<User> GetListOfUsers()
        {
            using (var context = new Context())
            {
                return context.Userek.ToList();
            }
        }
    }
}
