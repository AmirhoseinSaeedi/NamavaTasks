namespace FirstTask
{
    public class Finder
    {
        public int[] FindIndices(int[] numbers, int target)
        {
            List<int> readen = new List<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                int goalNumber = target - numbers[i];
                if (readen.Contains(goalNumber))
                {
                    return new int[2] { readen.IndexOf(goalNumber), i };
                }
                readen.Add(numbers[i]);
            }
            return new int[0];
        }
    }
}
