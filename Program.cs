namespace Week6Assignment6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            Console.WriteLine("Part 1");
            HouseList houses = new HouseList();

            houses.AddHouse(123, "123 Oak Avenue", HouseType.Ranch, 1);
            houses.AddHouse(456, "456 Oak Avenue", HouseType.Colonial, 2);
            houses.AddHouse(789, "789 Main Street", HouseType.Cottage, 1);

            Console.Write("Enter house number to search: ");
            int number = Convert.ToInt32(Console.ReadLine());
            houses.SearchHouse(number);

            Console.WriteLine("\nHouses in list: \n");
            houses.Display();

            houses.RemovePostion(1);
            Console.WriteLine("\nHouses after removal: \n");
            houses.Display();
            #endregion

            #region Part3
            Console.WriteLine("Part 3");
            int[] nums = { 0, 1, 0, 3, 12, 7, 0, 0, 8 };
            Console.WriteLine("\nSample Array: ");
            Console.WriteLine(string.Join(", ", nums));
            
            MoveZeroes(nums);
            
            Console.WriteLine("\nAfter moving zeros to end: ");
            Console.WriteLine(string.Join(", ", nums)); 
            #endregion
        }
        static void MoveZeroes(int[] nums)
        {
            int position = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[position] = nums[i];
                    position++;
                }
            }

            while (position < nums.Length)
            {
                nums[position] = 0;
                position++;
            }
        }
    }
}
