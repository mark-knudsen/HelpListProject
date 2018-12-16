using Eventmaker.Common;
using HelpListProject.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelpListProject.ViewModel
{
    class ProblemCollector : INotifyPropertyChanged
    {
        #region PropertyChangeSupport
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        //Instance Field
        private ObservableCollection<Problem> _problems;
        private string _name;
        private string _topic;
        private string _location;
        private string _description;
        private DateTime _date;
        private Problem _selectedProblem;


        //Constructor
        public ProblemCollector()
        {
            _problems = new ObservableCollection<Problem>();
            _selectedProblem = null;

            _problems.Add(new Problem("Kevin", "Emne", "Klassen", "hvorfor virker det ikke :("));

            AddCommand = new RelayCommand(Add);
            RemoveCommand = new RelayCommand(Remove);
            RemoveAllCommand = new RelayCommand(RemoveAll);
        }


        //Property
        public ObservableCollection<Problem> Problems
        {
            get { return _problems; }
            set { _problems = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Problem SelectedProblem
        {
            get { return _selectedProblem; }
            set
            {
                _selectedProblem = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public RelayCommand RemoveAllCommand { get; set; }


        //Methods
        public void Add()
        {
            _problems.Add(new Problem(Name, Topic, Location, Description));
            OnPropertyChanged();
        }

        public void Remove()
        {
            if (SelectedProblem != null)
            {
                _problems.Remove(_selectedProblem);
                OnPropertyChanged();
            }
        }
        public void RemoveAll()
        {
            _problems.Clear();
            OnPropertyChanged();
        }

        //public void RemoveJustOne()
        //{
        //    if (SelectedProblem != null)
        //    {
        //        if (Name==Name)
        //        {
        //            _problems.Remove(_selectedProblem);
        //        OnPropertyChanged();
        //        }

        //    }
        //}


    }


}
