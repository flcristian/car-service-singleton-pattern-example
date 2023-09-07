using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_service_singleton_pattern
{
    public class CarService
    {
        private static readonly object _lock = new object();
        private static CarService? _carService = null;
        private List<String> _cars;

        private CarService()
        {
            _cars = new List<String>();
        }

        public static CarService GetCarService()
        {
            lock (_lock)
            {
                if(_carService == null)
                {
                    _carService = new CarService();
                }
                return _carService;
            }
        }

        public List<String> Cars
        {
            get { return _cars; }
            set
            {
                _cars = value;
            }
        }
    }
}
