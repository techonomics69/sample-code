// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;
class Example
{
 static void Main(string[] args)
 {
    // Find your Account Sid and Auth Token at twilio.com/user/account
    string AccountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    string AuthToken = "your_auth_token";
    var twilio = new TwilioRestClient(AccountSid, AuthToken);

    var message = twilio.SendMessage(
        "+15017122661", "+15558675310",
        "McAvoy or Stewart? These timelines can get so confusing.",
        "http://requestb.in/1234abcd"
    );
    Console.WriteLine(message.Sid);
 }
}
