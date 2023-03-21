namespace Social_Media_clone.Model
{
    public class View
    {
        private int idOfCurentUser;
        private List<User> _allUsers;


        public View(int userId, List<User> AllUsers)
        {
            idOfCurentUser = userId;
            _allUsers = AllUsers;
        }

        public void ViewSelector()
        {
            Console.Clear();
            Console.WriteLine("Main menue");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("F - Folk du kanskje kjenner");
            Console.WriteLine("B - Blokerte");
            Console.WriteLine("I - Innlegg");
            Console.WriteLine("A - Alle innlegg");
            Console.WriteLine("V - Venner");
            Console.WriteLine("P - Lag en poast");
            Console.WriteLine("X - EXIT");
            Console.WriteLine("-------------------------------");
            string userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "F":
                    DisplayPeopleYouMayKnow();
                    break;

                case "B":
                    break;

                case "I":
                    break;

                case "A":
                    break;

                case "V":
                    break;

                case "P":
                    break;

                case "X":
                    // Faktisk breaker her
                    break;

                default:
                    ViewSelector();
                    break;
            }
        }

        public void DisplayPeopleYouMayKnow()
        {
            Console.WriteLine("Folk du kanskje kjenner");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < _allUsers.Count; i++)
            {
                if (!(i == idOfCurentUser)) Console.WriteLine($"{i} - {_allUsers[i].GetFullName()}");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press tallet for å velge bruker");
            Console.WriteLine("Press X for å gå ut");



            string userInput = Console.ReadLine();

            if (userInput == "")
            {
                Console.Clear();
                DisplayPeopleYouMayKnow();
            }
            else if (userInput.ToLower() == "x")
            {
                ViewSelector();
            }
            else
            {
                InspectPerson(userInput);
            }
        }



        private void InspectPerson(string IndexSelected)
        {
            if (Common.IsDigitsOnly(IndexSelected))
            {
                int personIndex = Int16.Parse(IndexSelected);

                if (personIndex < _allUsers.Count() && personIndex != idOfCurentUser)
                {
                    Console.Clear();
                    Console.WriteLine(_allUsers[personIndex].GetFullName());
                    Console.WriteLine("Add / Block");
                    string addOrBolck = Console.ReadLine();
                    if (addOrBolck.ToLower() == "add")
                    {
                        int id = _allUsers[personIndex].GetUserID();
                        _allUsers[idOfCurentUser].AddFriend(id);
                        DisplayPeopleYouMayKnow();
                    }
                    else if (addOrBolck.ToLower() == "block")
                    {
                        _allUsers[idOfCurentUser].AddUserToBlockedList(personIndex);
                        DisplayPeopleYouMayKnow();
                    }
                    else DisplayPeopleYouMayKnow();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Gi ett tall som er på listen");
                    DisplayPeopleYouMayKnow();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Tall, ikke bokstaver");
                DisplayPeopleYouMayKnow();
            }
        }
    }
}
