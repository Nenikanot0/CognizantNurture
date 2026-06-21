using System;

class Program
{
    static void Main(string[] args)
    {
        Notifier notifier =
            new SlackNotifierDecorator(
                new SMSNotifierDecorator(
                    new EmailNotifier()));

        notifier.Send("System Update Available");
    }
}