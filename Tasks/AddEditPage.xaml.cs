using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditPage : ContentPage
    {
        List<TaskModel> tasks;
        public AddEditPage(List<TaskModel> list)
        {
            InitializeComponent();
            tasks = list;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            TaskModel taskModel = new TaskModel();
            taskModel.ID = Guid.NewGuid();
            taskModel.Title = Title.Text;
            taskModel.Description = Description.Text;
            taskModel.Importance = Importance.SelectedItem.ToString();
            tasks.Add(taskModel);
            Navigation.PopToRootAsync();
        }
    }
}