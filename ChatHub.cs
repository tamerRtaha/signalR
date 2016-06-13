using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public static List<users> lstusers = new List<users>(); 
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }

        public void sendv2(string username, string msg)
        {
            Clients.All.broadcastMessagev2(username, msg);
        }

        public void sendtogroup(string groupname, string username, string msg)
        {
          //  Clients.Group("chat").broadcastMessagev2(username, msg);
           // Clients.Group("group1").addMessage("Group Message from " + username +" : " + msg);

            Clients.Group(groupname).sendgroup(groupname,username, msg);
        }

        public List<users> joinGroup(string groupname)
        {
           
            Groups.Add(Context.ConnectionId, groupname);
            lstusers.Add(new users() { usercontextId = Context.ConnectionId });
             // users.Add(Context.ConnectionId);
            
            return lstusers;
        }

    }

    public class users
    {
       public string usercontextId { get; set; }
      // public int count { get; set; }
    }
}