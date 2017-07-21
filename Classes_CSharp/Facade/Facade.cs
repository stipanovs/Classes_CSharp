using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Users;

namespace Classes_CSharp.Facade
{
    class Facade
    {
        public User _user;
        public Posts _post;

        public Facade()
        {
            _user = new User();
            _post = new Posts();
            
        }

        public bool IsUserEligibleToPost()
        {
            return !_user._bloked;
        }

        public Posts CreatePost(bool userCanPost)
        {
            return userCanPost ? _post.CreatePost() : null;
        }

    }
}
