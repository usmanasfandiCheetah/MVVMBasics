using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo
{
    public class User : BaseNotifier
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        private int _age;

        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }

        public string FirstName { 
            get => _firstName;
            set
            {
                SetProperty(ref _firstName, value);
                FullName = _firstName + " " + _lastName;
            } 
        }
        public string LastName { 
            get => _lastName; set
            {
                SetProperty(ref _lastName, value);
                FullName = _firstName + " " + _lastName;
            }
        }

        public string FullName { get => _fullName; set => SetProperty(ref _fullName,value); }


        
    }
}
