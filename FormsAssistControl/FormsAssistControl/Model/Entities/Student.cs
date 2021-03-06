﻿
using System;
using FormsAssistControl.Storage;

namespace FormsAssistControl.Model.Entities
{
    public class Student:ObservableBaseObject,IKeyObject
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(); }
        }

        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; OnPropertyChanged(); }
        }

        private string studentNumber;

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; OnPropertyChanged(); }
        }

        private double average;

        public double Average
        {
            get { return average; }
            set { average = value; OnPropertyChanged(); }
        }

        public string Key
        {
            get; set;
        }
    }
}
