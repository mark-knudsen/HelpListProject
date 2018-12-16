using System.Collections.ObjectModel;

namespace HelpListProject.Model
{
    class HelpListSingleton
    {

        #region Instance field
        private static HelpListSingleton _instance = null;
        public Problem _Problem1 = new Problem("Kevin", "Emne", "klassen", "hvorfor virker det ikke :(");
        #endregion

        #region Constructor
        private HelpListSingleton()
        {
            Problems = new ObservableCollection<Problem>();
            CreateLocalList();
        }
        #endregion

        #region Property

        public static HelpListSingleton Instance
        {
            get { return _instance ?? (_instance = new HelpListSingleton()); }
        }

        public ObservableCollection<Problem> Problems { get; set; }
        public Problem SelectedProblem { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        #endregion

        #region Methods

        public void Add()
        {
            Problems.Add(new Problem(Name, Topic, Location, Description));
        }

        public void Remove()
        {
            if (SelectedProblem != null)
            {
                Problems.Remove(SelectedProblem);
            }
        }

        public void RemoveAll()
        {
            Problems.Clear();
        }

        public void CreateLocalList()
        {
            //Problems.Add(new Problem(Name, Topic, Location, Description));
            Problems.Add(_Problem1);
        }

        public void LoadFromFile()
        {
            // udvikles senere, skal op i constructor
        }
        #endregion



    }
}
