using System.Collections.Generic;

namespace PropertyDemo
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _list;

        public VideoEncoder()
        {
            _list = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // video encoding logic
            foreach (var channel in _list)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterChannel(INotificationChannel channel)
        {
            _list.Add(channel);
        }
    }

    public class Video
    {

    }

    public class Message
    {

    }

    public class EmailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending email ...");
        }
    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending sms ...");
        }
    }
}
