namespace Exercise2
{
    public class Sorter
    {
        public string SortCharacters(int number, string text)
        {
            string result = text;

            if (number >= 1)
            {
                text = text.Replace(" ", "");
                result = "";
                int counter = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    result += text.ElementAt(i);
                    counter++;
                    if (counter == number)
                    {
                        result += "\n";
                        counter = 0;
                    }
                }
            }

            return result;
        }
    }
}
