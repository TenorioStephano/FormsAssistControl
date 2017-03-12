using FormsAssistControl.Model.Entities;
using FormsAssistControl.View;
using FormsAssistControl.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsAssistControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new StudentDirectoryVM();
            lvStudents.ItemSelected += LvStudents_ItemSelected;
        }

        void LvStudents_ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            if(selectedStudent == null)
                return;
            Navigation.PushAsync(new SelecteStudentDetailPage(selectedStudent));
            lvStudents.SelectedItem = null;
        }
    }
}
