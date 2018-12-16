using Eventmaker.Common;
using HelpListProject.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelpListProject.ViewModel
{


    class TeacherCollection : INotifyPropertyChanged
    {

        //instance fields
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _mail;
        private ObservableCollection<Teacher> _tc;

        private Teacher _selectedTeacher;
        private Teacher _newTeacher;

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string Mail
        {
            get { return _mail; }
            set
            {
                _mail = value;
                OnPropertyChanged();
            }
        }
        public Teacher SelectedTeacher
        {
            get { return _selectedTeacher; }
            set
            {
                _selectedTeacher = value;
                OnPropertyChanged();
            }
        }
        public Teacher NewTeacher
        {
            get { return _newTeacher; }
            set
            {
                _newTeacher = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }


        //create a collection for Teachers.
        public ObservableCollection<Teacher> TC
        {
            get { return _tc; }
            set
            {
                _tc = value;
                OnPropertyChanged();
            }
        }

        //constructor
        public TeacherCollection()
        {
            TC = new ObservableCollection<Teacher>
            {
                new Teacher("Henrik", "Høltzer", "henrikpass","hanrik@gmail.com"),
                new Teacher("Jamshid", "Eftekhari", "jamshidpass","jamshid@gmail.com"),
            };

            TC.Add(new Teacher("Torben", "Heidemann", "torbenpass", "torben@gmail.com"));
            _newTeacher = new Teacher();

            AddCommand = new RelayCommand(AddTeacherMethod);
            DeleteCommand = new RelayCommand(DeleteTeacherMethod);

        }

        //methods
        public void AddTeacherMethod()
        {
            TC.Add(new Teacher(_firstName, _lastName, _password, _mail));
        }
        public void DeleteTeacherMethod()
        {
            if (SelectedTeacher != null)
            {
                TC.Remove(SelectedTeacher);
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
