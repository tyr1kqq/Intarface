namespace Intarface.Task1
{
    interface IWhatsApp
    {
        void StringMasage(string masage);
    }
    interface Viber
    {
        void StringMasage(String masage);
    }
    public class NewMessage : IWhatsApp, Viber
    {
        void IWhatsApp.StringMasage(string masage)
        {
            Console.WriteLine("WhatsApp + {0}" , masage);
        }

        void Viber.StringMasage(string masage)
        {
            Console.WriteLine("Viber + {0}" , masage);
        }
    }
    public interface IWriter
    {
        void Write();
    }
    public class Writer : IWriter
    {
        void IWriter.Write() { Console.WriteLine();  }
    }
    public interface IWorker
    {
         void Build();
    }
    public class Worker : IWorker
    {
        public void Build() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Writer writer = new Writer();
            ((IWriter)writer).Write();
           NewMessage newMessage = new NewMessage();
            ((IWhatsApp)newMessage).StringMasage("Hello Wold ");
            ((Viber)newMessage).StringMasage("Heelau world!");
        }
    }
}