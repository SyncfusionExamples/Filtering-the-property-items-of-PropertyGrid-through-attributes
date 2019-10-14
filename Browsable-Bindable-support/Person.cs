using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media.Imaging;
using System.Reflection;

namespace Browsable_Bindable_support
{
    public class Person
    {
        public Person()
        {
            FirstName = "Carl";
            LastName = "Johnson";
            Email = "carljohnson@gta.com";
            ID = "0005A";
            DOB = new DateTime(1987, 10, 16);
            Age = 30;
            Designation = "Team Lead";
        }

        [Bindable(false)]
        public string MaritalStatus
        {
            get;

            set;
        }


        [Bindable(false)]
        [Display(AutoGenerateField = true)]
        public double NetSalary
        {
            get;

            set;
        }

        [Browsable(false)]
        public string Email
        {
            get;

            set;
        }

        public string FirstName
        {
            get;

            set;
        }

        [Browsable(false)]
        [Display(AutoGenerateField = true)]
        public string Designation
        {
            get;

            set;
        }


        [Display(AutoGenerateField = false)]
        public int Age
        {
            get;

            set;
        }

        public string LastName
        {
            get;

            set;
        }

        public string ID
        {
            get;

            set;
        }

        public DateTime DOB
        {
            get;

            set;
        }
    }
}
