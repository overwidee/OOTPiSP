using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace example3.Models
{
    public class GrainWorkModel
    {
        public Transport Transport { get; set; }
        public DateTime DateAndTime { get; set; }

        public double Tones { get; private set; }

        public void AddTones(double tones)
        {
            Tones += tones;
        }
    }

    public class ParkingTechnics : IEnumerable<Transport>
    {
        private readonly List<Transport> _transports = new List<Transport>();

        public ParkingTechnics(IEnumerable<Transport> transports)
        {
            _transports.AddRange(transports);
        }

        public void AddTransport(params Transport[] transports)
        {
            _transports.AddRange(transports);
        }

        public void GetTransportFor(Employee employee, string number = null)
        {
            var transport = _transports.FirstOrDefault(x => !x.IsBusy && (number == null || x.Number == number));
            if (transport == null) return;

            transport.BusyBy = employee;
        }

        public void FreeTransport(Transport transport)
        {
            var transportBusy = _transports.FirstOrDefault(x => x.Number == transport.Number);
            if (transport == null) return;

            transport.BusyBy = null;
        }

        public void FreeTransport(params string[] numberTransport)
        {
            foreach (var number in numberTransport)
            {
                var transport = GetTransportByNumber(number);
                if (transport == null) return;

                transport.BusyBy = null;
            }
        }

        public ParkingTechnics GetBusyTransport()
        {
            return new ParkingTechnics(_transports.Where(x => x.IsBusy));
        }

        public IEnumerator<Transport> GetEnumerator()
        {
            return _transports.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Transport GetTransportByNumber(string number)
        {
            return _transports.FirstOrDefault(x => x.Number == number);
        }

        public Transport GetTransportByEmployee(Employee emp)
        {
            return _transports.FirstOrDefault(x => x.BusyBy.GetUserNick() == emp.GetUserNick());
        }
    }

    public class GrainHarvesting : List<GrainWorkModel>
    {
        private ParkingTechnics _workTechnics;

        public GrainHarvesting(ParkingTechnics workTechnics)
        {
            _workTechnics = workTechnics;
        }

        public void AddTones(string numberMachine, double tons, DateTime dateTime)
        {
            var workTechnic = _workTechnics.GetTransportByNumber(numberMachine);

            var existGrainWork = this.FirstOrDefault(x => x.Transport.Number == workTechnic.Number);
            if (existGrainWork != null)
            {
                existGrainWork.AddTones(tons);
            }
            else
            {
                var newGrainWork = new GrainWorkModel()
                {
                    Transport = workTechnic,
                    DateAndTime = dateTime
                };
                newGrainWork.AddTones(tons);
                Add(newGrainWork);
            }
        }
        public void AddTones(Employee employee, double tons, DateTime dateTime)
        {
            var workTechnic = _workTechnics.GetTransportByEmployee(employee);

            var existGrainWork = this.FirstOrDefault(x => x.Transport.Number == workTechnic.Number);
            if (existGrainWork != null)
            {
                existGrainWork.AddTones(tons);
            }
            else
            {
                var newGrainWork = new GrainWorkModel()
                {
                    Transport = workTechnic,
                    DateAndTime = dateTime
                };
                newGrainWork.AddTones(tons);
                Add(newGrainWork);
            }
        }

        public double GetTotal() => this.Sum(x => x.Tones);

        public GrainWorkModel GetBest() =>
            this.OrderByDescending(x => x.Tones).FirstOrDefault();
    }
}