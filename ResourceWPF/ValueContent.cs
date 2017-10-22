using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ResourceWPF
{
    class ValueContent : INotifyPropertyChanged
    {
        public Visibility Vi { get; set; }
        

        private Brush _color;

        public Brush color
        {
            get { return _color; }
            set
            {
                _color = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("color"));

            }
        }




        public ValueContent()
        {
            Vi = Visibility.Collapsed;
            color = Brushes.Azure;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }

    
}
