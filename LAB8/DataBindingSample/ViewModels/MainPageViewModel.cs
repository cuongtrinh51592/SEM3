using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingSample.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            for (int i = 0; i < 100; i++)
            {
                var item = new Model.TodoItem()
                {
                    Title = string.Format("Task title {0}", i)
                };
                this.Items.Add(item);
            }
        }
        public ObservableCollection<Model.TodoItem> Items { get; private set; }
        = new ObservableCollection<Model.TodoItem>();
    }
}

