
using System.Text;
namespace TypingTrainer
{
    /// <summary>
    /// Генерирует связный текст на основе текста из файлов ./SourceTexts. Использует алгоритм Цепей Маркова.
    /// </summary>
    public static class TextGenerator
    {
        private static readonly Random _random = new Random();

        /// <summary> Считывает содержимое текстового файла из папки SourceTexts </summary>
        private static string LoadTextFile(string fileName) => 
            File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SourceTexts", fileName)).Trim();

        /// <summary> Генерирует связный текст заданной длины. </summary>
        public static string Generate(int levelIndex, int wordCount = 15) =>
            GenerateTextFromChain(BuildChain(GetSourceText(levelIndex)), wordCount);

        /// <summary> Возвращает текст, используя LoadTextFile </summary>
        private static string GetSourceText(int levelIndex) => levelIndex switch
        {
            0 => LoadTextFile("russian.txt"),
            1 => LoadTextFile("russian_punctuation.txt"),
            2 => LoadTextFile("english.txt"),
            _ => LoadTextFile("russian.txt")
        };

        /// <summary> Строит цепь Маркова (словарь переходов) </summary>
        private static Dictionary<string, List<string>> BuildChain(string text)
        {
            var chain = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
            // Разбивает текст на слова, сохраняя знаки препинания
            string[] words = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (!chain.TryGetValue(words[i], out var list))
                    chain[words[i]] = list = new List<string>();
                list.Add(words[i + 1]);
            }
            return chain;
        }

        /// <summary> Генерирует связный текст на основе словаря переходов </summary>
        private static string GenerateTextFromChain(Dictionary<string, List<string>> chain, int length)
        {
            if (chain.Count == 0) return "Ошибка генерации текста.";

            var keys = chain.Keys.ToList();
            string word = keys[_random.Next(keys.Count)];
            var result = new StringBuilder(word);

            for (int i = 1; i < length; i++)
            {
                word = chain.TryGetValue(word, out var next) && next.Count > 0
                    ? next[_random.Next(next.Count)]
                    : keys[_random.Next(keys.Count)];
                result.Append(' ').Append(word);
            }
            return result.ToString();
        }
    }
}
