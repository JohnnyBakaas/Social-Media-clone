namespace Social_Media_clone.Model
{
    public class Posts
    {
        private int _authorId;
        private string _text;
        private List<int> _likes = new List<int>();
        private List<int> _disLikes = new List<int>();

        public Posts(int authorId, string postText)
        {
            _authorId = authorId;
            _text = postText;
        }

        public void Debug()
        {
            Console.WriteLine(_authorId + " <= ID | TEXT => " + _text);
        }
    }
}
