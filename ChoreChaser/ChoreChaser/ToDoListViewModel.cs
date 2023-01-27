using System;
using System.Collections.ObjectModel; //Must be added to use observablecollection list
using System.Windows.Input; //for ICommand. ModelViewModel uses commands instead of event handler
using Xamarin.Forms; //gives access to the Commannd

namespace ChoreChaser
{
	public class ToDoListViewModel
	{
		public ObservableCollection<ToDoItem> ToDoItems { get; set; }


		public ToDoListViewModel()
		{
			ToDoItems = new ObservableCollection<ToDoItem>();  //initializing as empty collection

            ToDoItems.Add(new ToDoItem("ToDO 1", true));		//adding these just for testing
            ToDoItems.Add(new ToDoItem("ToDO 2", false));
            ToDoItems.Add(new ToDoItem("ToDO 3", false));
        }

        //Create property on this class that can store whatever text added to entry field
        public ICommand AddToDoCommand => new Command(AddToDoItem);  //when entered, AddToDoItem()   --works like the enter event handler
		public string NewToDoInputValue { get; set; }
        void AddToDoItem()
        {
            ToDoItems.Add(new ToDoItem(NewToDoInputValue, false));
        }


        public ICommand RemoveToDoCommand => new Command(RemoveToDoItem);  
        void RemoveToDoItem(object o)
        {
            ToDoItem toDoItemBeingRemoved = o as ToDoItem;
            ToDoItems.Remove(toDoItemBeingRemoved);
        }


    }
}

