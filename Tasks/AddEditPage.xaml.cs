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
        TaskModel model;
        public AddEditPage(List<TaskModel> list)
        {
            InitializeComponent();
            tasks = list;
        }
        public AddEditPage(List<TaskModel> list,TaskModel model)
        {
            InitializeComponent();
            this.tasks = list;
            this.model=model;

            Title.Text = model.Title;
            Description.Text = model.Description;
            Importance.SelectedItem=model.Importance;

            Add.Clicked -= Add_Clicked;
            Add.Clicked += Edit_Clicked;

            Add.Text = "Edytuj";
        }
        private async void Edit_Clicked(object sender, EventArgs e) {
            model.Title = Title.Text;
            model.Description=Description.Text;
            model.Importance = Importance.SelectedItem.ToString();

            JSONHandling.JsonHandling.WriteToFile(tasks);
            await Navigation.PopToRootAsync();
        }
        private async void Add_Clicked(object sender, EventArgs e)
        {
            TaskModel taskModel = new TaskModel();
            taskModel.ID = Guid.NewGuid();
            taskModel.Title = Title.Text;
            taskModel.Description = Description.Text;
            taskModel.Importance = Importance.SelectedItem.ToString();
            tasks.Add(taskModel);
            JSONHandling.JsonHandling.WriteToFile(tasks);
            await Navigation.PopToRootAsync();
        }
    }
}