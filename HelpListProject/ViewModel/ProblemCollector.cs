using Eventmaker.Common;
using HelpListProject.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelpListProject.ViewModel
{
    class ProblemCollector
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
        private DateTime _date;


        //Constructor
        public ProblemCollector()
        {
            MyHelpList = HelpListSingleton.Instance;


            AddCommand = new RelayCommand(MyHelpList.Add);
            RemoveCommand = new RelayCommand(MyHelpList.Remove);
            RemoveAllCommand = new RelayCommand(MyHelpList.RemoveAll);
            SaveProblem = new RelayCommand(MyHelpList.SaveProblemFolder);

        }


        //Property
        public HelpListSingleton MyHelpList { get; set; }

        public Problem SelectedProblem { get; set; } = null;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public RelayCommand RemoveAllCommand { get; set; }
        public RelayCommand SaveProblem { get; set; }

        //Methods
        //public void Add()
        //{
        //    _problems.Add(new Problem(Name, Topic, Location, Description));
        //    OnPropertyChanged();
        //}

        //public void Remove()
        //{
        //    if (SelectedProblem != null)
        //    {
        //        _problems.Remove(_selectedProblem);
        //        OnPropertyChanged();
        //    }
        //}
        //public void RemoveAll()
        //{
        //    _problems.Clear();
        //    OnPropertyChanged();
        //}

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
