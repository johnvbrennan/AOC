namespace AOC.Day1
{
    public class Elf : IComparable<Elf>
    {
        private List<int> _calories;

        public Elf(int position, List<int> calories)
        {
            this.Position = position;
            this._calories = calories;
        }

        public void AddCalories(int calories)
        {
            _calories.Add(calories);
        }
        public int Position { get; set; }
        public int TotalCalories { get { return _calories.Sum(); }}


        public int CompareTo(Elf that)
        {
            if (this.TotalCalories < that.TotalCalories) return -1;
            if (this.TotalCalories == that.TotalCalories) return 0;
            return 1;
        }
    }

}
