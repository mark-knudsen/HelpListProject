using Eventmaker.Common;
using HelpListProject.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelpListProject.ViewModel
{
    class StudentCollection : INotifyPropertyChanged
    {

        //instance fields
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _mail;
        private ObservableCollection<Student> _sc;

        private Student _selectedStudent;
        private Student _newStudent;

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
        public string Mail
        {
            get { return _mail; }
            set
            {
                _mail = value;
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
        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }
        public Student NewStudent
        {
            get { return _newStudent; }
            set
            {
                _newStudent = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        //create a collection for Students.
        public ObservableCollection<Student> SC
        {
            get { return _sc; }
            set
            {
                _sc = value;
                OnPropertyChanged();
            }
        }
        //constructor
        public StudentCollection()
        {
            SC = new ObservableCollection<Student>
            {
                new Student("Mark","Knudsen", "markpass","mark@gmail.com"),
                new Student("Morten", "Eriksen", "mortenpass","morten@gmail.com"),
                new Student("Celine","Stenberg", "celinepass","celine@gmail.com"),
                new Student("Kevin", "Filtenborg", "kevinpass","kevin@gmail.com"),
                new Student("Celina", "Slots", "celinapass","celina@gmail.com")
            };

            _newStudent = new Student();

            AddCommand = new RelayCommand(AddStudentMethod);
            DeleteCommand = new RelayCommand(DeleteStudentMethod);

        }
        //methods
        public void AddStudentMethod()
        {
            SC.Add(new Student(_firstName, _lastName, _password, _mail));
        }
        public void DeleteStudentMethod()
        {
            if (SelectedStudent != null)
            {
                SC.Remove(SelectedStudent);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
