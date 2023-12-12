using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Model;
using Xamarin.Forms;

namespace Tasks {
    public partial class MainPage : ContentPage {
        List<TaskModel> tasks = new List<TaskModel>();
        public MainPage() {
            InitializeComponent();
            tasks = new List<TaskModel>() {
                new TaskModel() {
                    ID=new Guid(),
                    Title="title",
                    Description="description",
                    Importance="Ważne",
                }
            };
            TasksList.ItemsSource = JSONHandling.JsonHandling.GetFromFile();
        }

        private void Add_Clicked(object sender, EventArgs e) {

        }

        private void Edit_Clicked(object sender, EventArgs e) {

        }

        private void Delete_Clicked(object sender, EventArgs e) {

        }
    }
}
