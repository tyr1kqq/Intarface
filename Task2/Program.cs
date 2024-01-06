namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public interface ICreatable
        {
            void Create();
        }

        public interface IDeletable
        {
            void Delete();
        }

        public interface IUpdatable
        {
            void Update();
        }
        class Entity : ICreatable, IDeletable, IUpdatable
        {
            public void Create()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }
        public interface IBook
        {
            void Read();
        }

        public interface IDevice
        {
            void TurnOn();
            void TurnOff();
        }

        class ElectroniBook : IBook, IDevice
        {
            void IBook.Read() { }
            void IDevice.TurnOff() { }
            void IDevice.TurnOn() { }
        }
    }
}