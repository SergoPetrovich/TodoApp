using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TodoApp.Models
{
    internal class TodoModel: INotifyPropertyChanged
         
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _isDone;
        private string _text;

     

        public bool IsDone
        { 
            get { return _isDone; }
            set { _isDone = value; } 
        }

        
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
