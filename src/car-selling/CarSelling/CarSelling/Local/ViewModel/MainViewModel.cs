using CarSelling.Local.Data;
using CarSelling.Local.Foundation;
using CarSelling.Local.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Windows.Input;

namespace CarSelling.Local.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private readonly List<Car> SellingCars;
        public ICommand PrevCommand { get; }
        public ICommand NextCommand { get; }

        private Car _currentCar;
        public Car CurrentCar
        {
            get => _currentCar;
            set { _currentCar = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            PrevCommand = new RelayCommand<object>(Prev, (obj) => CurrentCar.Sort > 0);
            NextCommand = new RelayCommand<object>(Next, (obj) => CurrentCar.Sort < SellingCars.Count -1);

            SellingCars = SellingCarListBuilder.Build().ToList();

            CurrentCar = SellingCars.First();
        }

        private void Prev(object obj)
        {
            CurrentCar = SellingCars[CurrentCar.Sort - 1];
        }

        private void Next(object obj)
        {
            CurrentCar = SellingCars[CurrentCar.Sort + 1];
        }
    }
}
