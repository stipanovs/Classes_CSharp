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
        public Repository<Post> _repositoryPosts;
        public PostFactory _postFactory;
      
        private UserFacade()
        {
            _user = new User();
            _repositoryPosts = new Repository<Post>();
            _postFactory = new PostFactory();
        }
        
        public bool IsUserEligibleToPost()
        {
            return !_user._bloked;
        }

        public void CreatePost(Post post)
        {
            if (IsUserEligibleToPost()) _user.UserAddPost(post);
        }

        public void CreatePost( DateTime dataFrom, DateTime dateTo,
            Location locationFrom, Location locationTo, double price, long id, PostType type)
        {
            if (IsUserEligibleToPost())
                _repositoryPosts.Create(_postFactory.CreateNewPost(dataFrom, dateTo, locationFrom, locationTo, price, id, type));
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
