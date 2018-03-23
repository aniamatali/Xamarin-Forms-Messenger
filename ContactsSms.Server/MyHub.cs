using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ContactsSms.Server.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ContactsSms.Server
{
    [HubName("MyHub")]
    public class MyHub : Hub
    {

        public IEnumerable<SmsContactState> GetContacts(string param)
        {
            var Contacts = new List<SmsContactState>
            {
                new SmsContactState {ContactName ="Mosh kjggg",ContactMobileNumber= 1277644890, ImageUrl = "http://lorempixel.com/100/100/people/6", LastMessageOn="Hi There" },
                new SmsContactState {ContactName ="Milly", ContactMobileNumber= 1294890690, ImageUrl = "http://lorempixel.com/100/100/people/7", LastMessageOn="Hi" },
                new SmsContactState {ContactName ="John", ContactMobileNumber= 1246777890, ImageUrl = "http://lorempixel.com/100/100/people/8", LastMessageOn="wats up!"  },
                new SmsContactState {ContactName ="Shon", ContactMobileNumber= 1203456590, ImageUrl = "http://lorempixel.com/100/100/people/9", LastMessageOn="u thr?"  }

            };

            
                return Contacts;
          

        }

        public IEnumerable<Sms> GetMessages(string param)
        {
            List<Sms> Messages = new List<Sms>()
            {
                new Sms{ FromUser ="Mosh", ToUser= "Dan", Message="This is my profile picture of just my eyeball because I'm too scared to show my whole face.", TimeStamp= DateTime.Now, Status="Received", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Sms{ FromUser ="Dan", ToUser= "Mosh", Message="I respect your decision to do that and it is most tactical, I prefer to take group photos to be more mysterious so you don't know whom you might be speaking with.", TimeStamp= DateTime.Now, Status="Sent", ImageUrl = "http://lorempixel.com/100/100/people/5"},
                new Sms{ FromUser ="Mosh", ToUser= "Dan", Message="Hi", TimeStamp= DateTime.Now, Status="Received", ImageUrl = "http://lorempixel.com/100/100/people/5"},
                new Sms{ FromUser ="Dan", ToUser= "Mosh", Message="Hi", TimeStamp= DateTime.Now, Status="Sent", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Sms{ FromUser ="Mosh", ToUser= "Dan", Message="Hi", TimeStamp= DateTime.Now, Status="Received", ImageUrl = "http://lorempixel.com/100/100/people/5"}
            };
            return Messages;
        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }
    }

}