using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TwilioClient.Init(
                Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID"),
                Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN")
            );

            var message = MessageResource.Create(
                from: new PhoneNumber("whatsapp:TWILIO_WHATSAPP_NUMBER"),
                to: new PhoneNumber("whatsapp:YOUR_MOBILE_NUMBER"),
                body: "Ahoy from Twilio!"
            );

            Console.WriteLine("Message SID: " + message.Sid);
        }
    }
}
