namespace Social_Media_clone.Model
{
    public class GeneratePosts
    {
        private int[] ARR_authorId = new int[] { 0, 1, 2, 1, 2, 0, 3, 4, 1, 0 };
        private string[] ARR_text = new string[] {
            "God morgen FOLKENS!", "Noe politisk", "Kake", "GI MEG OPPMERKSOMHET", "BIL", "Kake er ett kjempe bra variabel navn", "Kake 2", "kakeTwo", "A", "F"
        };



        public GeneratePosts(List<Posts> posts)
        {
            for (int i = 0; i < ARR_authorId.Length; i++)
            {
                posts.Add(new Posts(ARR_authorId[i], ARR_text[i]));
            }
        }
    }
}
