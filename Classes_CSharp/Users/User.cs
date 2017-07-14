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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private readonly List<UserMessageBox> BoxMessages = new List<UserMessageBox>();

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void RegisterToEvent(Posts post) // method to subscribe to event : post change price
        {
            post.PostPriceChanged += InboxMessage;

        }
        
        public void RegisterToEventWeakMethod(Posts post) 
        {
            WeakEventManager<Posts, PostPriceChangedEventArgs>.AddHandler(post, "PostPriceChanged", InboxMessage);
        }

        public void UnregisterToEvent(Posts post)
        {
            post.PostPriceChanged -= InboxMessage;
        }

        public void UnregisterToEventWeakMethod(Posts post)
        {
            
            WeakEventManager<Posts, PostPriceChangedEventArgs>.RemoveHandler(post, "PostPriceChanged", InboxMessage);
        }


        public void InboxMessage(object sender, PostPriceChangedEventArgs p)
        {
            string content = string.Format("Post ID: {0} price has changed. The last Price was {1}. \n" +
                                           "Now new Price is {2}. Good Discount!!!", p.ID, p.LastPrice, p.NewPrice) ;
            BoxMessages.Add(new UserMessageBox("System", "Post price changed!!!", content));
            Console.WriteLine("Add new message to UserMessageBox " + "user: " + ToString());
            Console.WriteLine("Content: " + content);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
