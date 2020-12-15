using System;
using System.Collections;
using System.Collections.Generic;

namespace example8.Models
{
    public interface IPrintingDevice
    {
        void Print();
        void RefillCartridge();
    }

    public class Printer : BasePrinter, IPrintingDevice
    {
        public void Print()
        {
            Console.WriteLine("Печатает обычный принтер");
        }

        public void RefillCartridge()
        {
            Console.WriteLine("Заправляем обычный принтер");
        }

        public Printer(int countList) : base(countList)
        {
        }
    }

    public class LaserPrinter : BasePrinter, IPrintingDevice
    {
        public void Print()
        {
            Console.WriteLine("Печатает лазерный принтер");
        }

        public void RefillCartridge()
        {
            Console.WriteLine("Заправляем лазерный принтер");
        }

        public LaserPrinter(int countList) : base(countList)
        {
        }
    }

    public abstract class BasePrinter
    {
        protected int _countList;

        protected BasePrinter(int countList)
        {
            _countList = countList;
        }

        public int GetCountLists() => _countList;
    }
    
    public class Technics : IEnumerable<IPrintingDevice>
    {
        private List<IPrintingDevice> _devices = new List<IPrintingDevice>();

        public Technics(IEnumerable<IPrintingDevice> devices)
        {
            _devices.AddRange(devices);
        }

        public void Add(params IPrintingDevice[] devices)
        {
            foreach (var device in devices)
            {
                _devices.Add(device);
            }
        }
        
        public IEnumerator<IPrintingDevice> GetEnumerator()
        {
            return _devices.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}