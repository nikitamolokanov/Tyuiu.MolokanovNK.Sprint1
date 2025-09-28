using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolokanovNK.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '(', ')', '\t', '\n', '\r' };
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var symmetricalWords = words
                .Where(word => word.ToLower() == new string(word.ToLower().Reverse().ToArray()))
                .ToArray();

            return string.Join(" ", symmetricalWords);
        }
    }
}
