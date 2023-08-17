namespace Reservations
{
    public static class SD
    {
        public readonly static List<string> State;
        public const string Available = "available";
        public const string Busy = "busy";
        public const string Cleaning = "cleaning";
        public const string Renovation = "renovation";

        static SD()
        {
            State = new List<string>();
            State.Add(SD.Available);
            State.Add(SD.Busy);
            State.Add(SD.Cleaning);
            State.Add(SD.Renovation);
        }
    }
}
