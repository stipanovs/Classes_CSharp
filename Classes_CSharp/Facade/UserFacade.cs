using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.PostsModel;
using Classes_CSharp.Repository;
using Classes_CSharp.Users;

namespace Classes_CSharp.Facade
{
    public class UserFacade
    {
        private static readonly Lazy<UserFacade> lazy = new Lazy<UserFacade>(() => new UserFacade(), true);
        public static UserFacade Instance { get { return lazy.Value; } }

        public User _user;
        public PostCargo _postCargo;
        public PostTransport _PostTransport;
        public Repository<Post> _repositoryPosts;
      
        private UserFacade()
        {
            _user = new User();
            _repositoryPosts = new Repository<Post>();
        }
        
        public bool IsUserEligibleToPost()
        {
            return !_user._bloked;
        }

        public void CreatePost(bool userCanPost, Post post)
        {
            if (IsUserEligibleToPost()) _user.UserAddPost(post);
        }

        public void RemovePost(Post post)
        {
            _user.UserDeletePost(post);
        }
        
        public IEnumerable<Post> FindAllTransportFrom(Country fromCountry, Country toCountry)
        {
            var allpost = _repositoryPosts.GetAll();
            return allpost
                .Where(p => p.LocationFrom.Country == fromCountry && p.LocationTo.Country == toCountry);
        }

        public IEnumerable<Post> FindAllCargoFrom(Country fromCountry, Country toCountry)
        {
            return FindAllTransportFrom(fromCountry, toCountry);
        }
    }
}
