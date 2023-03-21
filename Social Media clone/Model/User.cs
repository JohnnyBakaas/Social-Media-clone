namespace Social_Media_clone.Model
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastNam;
        private static int _nextId;
        private List<int> _friendList = new List<int>();
        private List<int> _blockList = new List<int>();

        private bool _publiclyDisplayFriends;

        public User(string firstName, string lastName, bool publiclyDisplayFriends)
        {
            _id = _nextId;
            _firstName = firstName;
            _lastNam = lastName;
            _nextId++;
            _publiclyDisplayFriends = publiclyDisplayFriends;
        }

        public void Debug()
        {
            Console.WriteLine(_id + " <= ID | NAME => " + _firstName);
            _friendList.ForEach(x => Console.WriteLine(x));
        }

        public int GetUserID() { return _id; }

        public string GetFullName() { return $"{_firstName} {_lastNam}"; }

        public void AddFriend(int userId)
        {
            _friendList.Add(userId);
        }

        public void AddUserToBlockedList(int userId) { }
    }
}
