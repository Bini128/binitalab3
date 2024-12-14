using System;
namespace binitalab3
{
    
        public delegate void Notify(string message);

        internal class question1
        {
            static void EmailNotification(string message)
            {
                Console.WriteLine("Email Notification: " + message);
            }

            static void SMSNotification(string message)
            {
                Console.WriteLine("SMS Notification: " + message);
            }

            static void PushNotification(string message)
            {
                Console.WriteLine("Push Notification: " + message);
            }

            //static void Main(string[] args)
            //{
            //    Notify notifyDelegate = EmailNotification;
            //    notifyDelegate += SMSNotification;
            //    notifyDelegate += PushNotification;

            //    Console.WriteLine("Sending notifications:");
            //    notifyDelegate("You have a new message!");

            //    notifyDelegate -= SMSNotification;

            //    Console.WriteLine("\nSending notifications after removal of SMS notification:");
            //    notifyDelegate("You have another new message!");

            //    Console.ReadLine();
            //Console.ReadKey();
            //}
        }
    
}
