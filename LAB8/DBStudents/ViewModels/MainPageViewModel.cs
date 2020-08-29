using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStudents.ViewModels
{
    class MainPageViewModel
    {
        public MainPageViewModel()
        {
            for(int i = 0; i < 100; i++)
            {
                var listStudents = new Models.TodoStudent()
                {
                    ID = i,
                    Name = string.Format("Name :  Cuong"),
                    GPA = new Random().NextDouble(),
                };
                this.Items.Add(listStudents);
            }
        }
        public ObservableCollection<Models.TodoStudent> Items { get; private set; }
        = new ObservableCollection<Models.TodoStudent>();
    }
}
