namespace kovariant.Contr
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
    public interface IMessage<T>
    {
        T DeviceInfo();
    }
    public class Phone { }
    public class Computer { }
    public class Viber : IMessage<Phone>
    {
        public Phone DeviceInfo()
        {
            return null;
        }
    }
}