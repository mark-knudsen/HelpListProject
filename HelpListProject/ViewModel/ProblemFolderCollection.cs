using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventmaker.Common;
using HelpListProject.Model;

namespace HelpListProject.ViewModel
{
    class ProblemFolderCollection : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private string _topic;
        private Problem _selectProblem;
        private ObservableCollection<Problem> _savedProblemCollector;

        public HelpListSingleton SavedProblems { get; set; }
        public RelayCommand SaveProblem { get; set; }

        public ProblemFolderCollection()
        {
            _savedProblemCollector = HelpListSingleton.Instance.SavedProblemCollection;
            {


            };
            SavedProblems = HelpListSingleton.Instance;

            SaveProblem = new RelayCommand(SavedProblems.AddProblemMethod);
        }




        //public void RemoveAllProblemsMethod()
        //{
        //    _savedProblemCollector.Clear();
        //}

        //public void AddProblemMethod()
        //{
        //    _savedProblemCollector.Add(new Problem(Name, Description, Topic));
        //}

        //public void RemoveProblemMethod()
        //{
        //    if (SelectProblem !=null)
        //    {
        //        _savedProblemCollector.Remove(SelectProblem);
        //    }
        //}

        public Problem SelectProblem
        {
            get => _selectProblem;
            set => _selectProblem = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string Topic
        {
            get => _topic;
            set => _topic = value;
        }

        public ObservableCollection<Problem> SavedProblemCollector
        {
            get { return _savedProblemCollector; }
            set
            {
                _savedProblemCollector = value;
            }
        }

        //public void AddProblemMethod()
        //{
        //    SavedProblemCollector.Add(new Problem(Name, Topic, Description));
        //}


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
