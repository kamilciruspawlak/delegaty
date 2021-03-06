﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorge
{
    public class CheckBoxTester : INotifyPropertyChanged

    {
        
        private bool _testChecked;

        public bool TestChecked
        {
            get { return _testChecked; }
            set
            {
                _testChecked = value;
                RaiseEventOnChange("TestChecked");
            }
        }

        public CheckBoxTester()
        {
            _testChecked = false;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaiseEventOnChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
