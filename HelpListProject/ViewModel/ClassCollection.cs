using Eventmaker.Common;
using HelpListProject.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace HelpListProject.ViewModel
{
    class ClassCollection : INotifyPropertyChanged
    {
        //instance fields
        private string _className;
        private string _classRoom;
        private string _firstName;
        private string _lastName;
        private string _mail;
        private string _passWord;

        private ObservableCollection<ClassObject> _cc;
        private ObservableCollection<Student> _clStudents;
        private ObservableCollection<Teacher> _cLTeachers;

        private ClassObject _selectedClass;
        private ClassObject _newClass;


        //Properties
        public string ClassName
        {
            get { return _className; }
            set
            {
                _className = value;
                OnPropertyChanged();
            }
        }
        public string ClassRoom
        {
            get { return _classRoom; }
            set
            {
                _classRoom = value;
                OnPropertyChanged();
            }
        }

        public ClassObject SelectedClass
        {
            get { return _selectedClass; }
            set
            {
                _selectedClass = value;
                OnPropertyChanged();
            }
        }
        public ClassObject NewClass
        {
            get { return _newClass; }
            set
            {
                _newClass = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        //public  RelayCommand SaveCommand { get; set; }


        //create a collection for users.
        public ObservableCollection<ClassObject> CC
        {
            get { return _cc; }
            set
            {
                _cc = value;
                OnPropertyChanged();
            }
        }


        //constructor
        public ClassCollection()
        {
            CC = new ObservableCollection<ClassObject>
            {
                new ClassObject("1a", "D2.7"),
                new ClassObject("1b", "D2.12"),
                new ClassObject("1c", "D3.5")
            };

            _newClass = new ClassObject();

            _clStudents = new ObservableCollection<Student>();
            _cLTeachers = new ObservableCollection<Teacher>();


            AddCommand = new RelayCommand(AddClassMethod);
            DeleteCommand = new RelayCommand(DeleteClassMethod);

        }
        //methods
        public void AddClassMethod()
        {
            CC.Add(new ClassObject(_className, _classRoom));
        }
        public void DeleteClassMethod()
        {
            if (SelectedClass != null)
            {
                CC.Remove(SelectedClass);
            }

        }
        public void AddStudentToClass()
        {
            _clStudents.Add(new Student(_firstName, _lastName, _passWord, _mail));
        }
        public void SaveClassMethod()
        {

        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
