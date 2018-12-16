namespace HelpListProject.Model
{
    class User
    {

        //Instance fields
        private string _firstName;
        private string _lastName;
        private string _passWord;
        private string _mail;
        private int _count;
        private int _nr;

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }

        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }

        }

        public string PassWord { get; set; }
        public int Nr { get; set; }

        //Constructor
        public User(string firstName, string lastName, string password, string mail)
        {
            _firstName = firstName;
            _lastName = lastName;
            _nr = _count++;
            _passWord = password;
            _mail = mail;
        }

        public User()
        {

        }

    }
}
