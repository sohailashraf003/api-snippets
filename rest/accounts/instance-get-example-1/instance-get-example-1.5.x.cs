// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio.Rest.Api.V2010;
using Twilio;
class Example
{
  static void Main(string[] args)
  {
    // Find your Account Sid and Auth Token at twilio.com/console
    string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    string authToken = "your_auth_token";
    TwilioClient.Init(accountSid, authToken);

    var account = AccountResource.Fetch("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

    Console.WriteLine(account.DateCreated);
  }
}