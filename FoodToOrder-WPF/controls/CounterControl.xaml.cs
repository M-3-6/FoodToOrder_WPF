using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodToOrder_WPF.controls
{
    /// <summary>
    /// Interaction logic for CounterControl.xaml
    /// </summary>
    public partial class CounterControl : UserControl, INotifyPropertyChanged
    {
        private int counter = 0;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Counter
        {
            get { return counter; }
            set { 
                counter = value;
                OnPropertyChanged("Counter");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CounterControl()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void DecrementDishBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Counter > 0) Counter--;

        }

        private void IncrementDishBtn_Click(object sender, RoutedEventArgs e)
        {
            Counter++;
        }

    }
}