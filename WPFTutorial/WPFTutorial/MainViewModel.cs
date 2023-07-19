﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Windows.Threading;

namespace WPFTutorial
{
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        private decimal _value1;
        [ObservableProperty]
        private decimal _value2;
        [ObservableProperty]
        private string _operator;

        public MainViewModel()
        {
            _value1 = 0;
            _value2 = 0;
            _operator = "+";

            var timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += (s, e) =>
            {
                Value11 += 1;
                Value2 += 2;
            };
            timer.Start();
        }

        public decimal Value11
        {
            get => _value1;
            set => SetProperty(ref _value1, value);
        }

        public decimal Value2
        {
            get => _value2;
            set => SetProperty(ref _value2, value);
        }

        public string Operator
        {
            get => _operator;
            set => SetProperty(ref _operator, value);
        }
    }
}