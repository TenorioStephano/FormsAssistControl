using FormsAssistControl.Model.Entities;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsAssistControl.View
{
    public partial class SelecteStudentDetailPage : ContentPage
    {
        public SelecteStudentDetailPage(Student selectedStudent)
        {
            InitializeComponent();
            this.BindingContext = selectedStudent;
        }
    }
}
