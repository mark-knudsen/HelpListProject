using System;

namespace HelpListProject.Model
{
    class Problem
    {
        #region Instance Field
        private string _name;
        private string _topic;
        private string _location;
        private string _description;
        private DateTime _date;
        #endregion

        #region Constructor

        public Problem(string name, string topic, string location, string description)
        {
            _name = name;
            _topic = topic;
            _location = location;
            _description = description;
            _date = DateTime.Now;
        }

        public Problem(string name, string topic, string description)
        {
            _name = name;
            _topic = topic;
            _description = description;
            _date = DateTime.Now;
        }

        #endregion

        #region Property

        public string Name
        {
            get { return _name; }
        }

        public string Topic
        {
            get { return _topic; }
        }

        public string Location
        {
            get { return _location; }
        }

        public string Description
        {
            get { return _description; }
        }

        public DateTime Date
        {
            get { return _date; }
        }
        #endregion
    }
}
