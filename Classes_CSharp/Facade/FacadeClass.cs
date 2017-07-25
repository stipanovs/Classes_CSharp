using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Repository;
using Classes_CSharp.Users;

namespace Classes_CSharp.Facade
{
    public class FacadeClass
    {
        private static readonly Lazy<FacadeClass> lazy = new Lazy<FacadeClass>(() => new FacadeClass(), true);
        
        public static FacadeClass Instance { get { return lazy.Value; } }
        public User _user = null;
        public Repository<Posts> _repositoryPosts;
        

        private FacadeClass()
        {
            _user = new User();
            _repositoryPosts = new Repository<Posts>();

        }

       
        public bool IsUserEligibleToPost()
        {
            return !_user._bloked;
        }

        public void CreatePost(bool userCanPost, Posts post)
        {
            if (IsUserEligibleToPost()) _user.UserAddPost(post);
        }

        public void DeletePost(Posts post)
        {
            //_user._userPosts.Remove(post); // law od Demeter violation
            _user.UserDeletePost(post);
        }
        
        public IEnumerable<Posts> FindTransport(Location fromLocation, Location toLocation)
        {
            var allpost = _repositoryPosts.GetAll();
            return allpost
                .Where(p => p.LocationFrom == fromLocation && p.LocationTo == toLocation);
            
        }

        public IEnumerable<Posts> FindCargo(Location fromLocation, Location toLocation)
        {
            var allpost = _repositoryPosts.GetAll();
            return allpost
                .Where(p => p.LocationFrom == fromLocation && p.LocationTo == toLocation);
        }
    }
}
