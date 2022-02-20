using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App3
{
    public class ToDoListViewmodel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public ToDoListViewmodel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("todo 1", false));
            TodoItems.Add(new TodoItem("todo 2", false));
            TodoItems.Add(new TodoItem("todo 3", false));
        }

        public ICommand AddToDoCommand => new Command(AddToDoItem);
        public string NewToDoInputValue { get; set; }

        void AddToDoItem()
        {
            TodoItems.Add(new TodoItem(NewToDoInputValue, false));
        }
    }
}
