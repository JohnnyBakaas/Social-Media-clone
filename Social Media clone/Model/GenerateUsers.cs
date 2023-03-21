namespace Social_Media_clone.Model
{
    internal class GenerateUsers
    {
        private string[] firstName = new string[] { "Per", "Pål", "Paril", "Kari", "Knut", "Lise" };
        private string[] lastName = new string[] { "Pålson", "Påldatter", "Baker", "Baker", "Baker", "Sme" };
        private bool[] wantsToShowOfHowManyFrindsTheyGot = new bool[] { true, false, true, true, true, false };

        public GenerateUsers(List<User> users)
        {
            for (int i = 0; i < firstName.Length; i++)
            {
                users.Add(new User(firstName[i], lastName[i], wantsToShowOfHowManyFrindsTheyGot[i]));
            }
        }
    }
}
