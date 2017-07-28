using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Events;
using System.Windows;

namespace Classes_CSharp.Users
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public bool _bloked = false;
        public readonly List<Post> _userPosts = new List<Post>();

        private readonly List<UserMessageBox> BoxMessages = new List<UserMessageBox>();

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public User()
        {
            
        }

        public void RegisterToEvent(Post post) // method to subscribe to event : post change price
        {
            post.PostPriceChanged += InboxMessage;
        }
        
        public void RegisterToEventWeakMethod(Post post) 
        {
            WeakEventManager<Post, PostPriceChangedEventArgs>.AddHandler(post, "PostPriceChanged", InboxMessage);
        }

        public void UnregisterToEvent(Post post)
        {
            post.PostPriceChanged -= InboxMessage;
        }

        public void UnregisterToEventWeakMethod(Post post)
        {
            WeakEventManager<Post, PostPriceChangedEventArgs>.RemoveHandler(post, "PostPriceChanged", InboxMessage);
        }

        public void UserAddPost(Post post)
        {
            _userPosts.Add(post);
        }

        public void UserDeletePost(Post post)
        {
            _userPosts.Remove(post);
        }
        
        public void InboxMessage(object sender, PostPriceChangedEventArgs p)
        {
            string content = string.Format("Post ID: {0} price has changed. The last Price was {1}. \n" +
                                           "   Now new Price is {2}. Good Offer!!!", p.ID, p.LastPrice, p.NewPrice) ;
            BoxMessages.Add(new UserMessageBox("System", "Post price changed!!!", content));
            Console.WriteLine("Add new message to " + ToString() + "\'s UserMessageBox: ");
            Console.WriteLine("   Content: " + content);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
