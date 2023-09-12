namespace BabyAge
{
    public class Baby
    {
        private DateTime _birthDay;
        public TimeSpan Age
        {
            get
            {
                if (_birthDay > DateTime.UtcNow)
                {
                    throw new ArgumentOutOfRangeException(nameof(_birthDay));
                }
                return DateTime.UtcNow - _birthDay;
            }
        }

        public Baby(int day, int month, int year)
        {
            _birthDay = new DateTime(year, month, day);
        }

        public Baby(string birtdDate)
        {
            _birthDay = DateTime.Parse(birtdDate);
        }

        public void PrintAge()
        {
            Console.WriteLine($"Baby is {(int)(Age.TotalDays / 365)} year, {(int)((Age.TotalDays % 365) / 30)} month, {(int)(Age.TotalDays % 365 % 30)} day");
        }
    }
}