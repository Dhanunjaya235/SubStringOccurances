namespace SubStringOccurances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Main String :\t");
            string mainString = Console.ReadLine();

            Console.Write("Enter the Sub String : ");
            string subString = Console.ReadLine();

            Program program = new Program();

            var result = mainString != string.Empty && subString != string.Empty ? program.AllOccurancesOfSubString(mainString, subString)
                : "You must enter both main string and sub string";  //checking whether both the strings have values or not


            Console.Write(result);

        }


        /// <summary>
        /// The method finds whether the second string is sub string of first string or not if yes it displays the number of times the
        /// second the string is repeated in the first along with their indexes
        /// </summary>
        /// <param name="mainString"></param>
        /// <param name="subString"></param>
        /// <returns></returns>
        public string AllOccurancesOfSubString(string mainString, string subString)
        {
            int count = 0;
            string indexes = "";
            for (int i = 0; i < mainString.Length - subString.Length; i++)
            {
                if (mainString.Substring(i, subString.Length) == subString)
                {
                    count++;
                    indexes = indexes + " " + i;
                }
            }

            if (count == 0)  //checks whether the second string is sub string or not
            {
                return "The second string is not a sub string of the first string";
            }
            else
            {
                return $"The number of times the substring occured in the main string is : {count} \n The indexes at which it occured are {indexes}";
            }
        }


        public void Display()
        {
            Console.WriteLine("A new method added after creating a repository");
        }
    }
}