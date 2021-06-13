using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordAnalysis
{
    class Program
    {
        private static readonly string[] Separators = { ".", ",", "-", "?", "!", ";", ":", "\"", "(", ")", "—" , "”", "“", "‘"};
        
        static void Main(string[] args)
        {
            var pathForRecord = @"C:\Users\Мария\Desktop\WordAnalysis\writer.txt";
            var pathForRead = @"C:\Users\Мария\Desktop\WordAnalysis\reader.txt";
            var input = "";
            var dict = new Dictionary<string, double>();

            #region Чтение входных данных

            try
            {
                using var sr = new StreamReader(pathForRead);
                input = sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            #endregion

            #region Обработка входных данных

            var allText = input;
            foreach (var separator in Separators)
            {
                allText = allText.Replace(separator, "");
            }

            var splittedWords = allText
                .ToLower()
                .Split()
                .Where(str => str != String.Empty)
                .ToArray();

            #endregion

            var countWords = splittedWords.Count(word => word != string.Empty);

            #region Добавление слов с их количеством повторений в словарь

            foreach (var word in splittedWords)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                    continue;
                }
                dict[word]++;
            }

            dict = dict
                .OrderBy(pair => pair.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            #endregion

            #region Запись всех пар в файл "writer.txt"
            
            try
            {
                using var sw = new StreamWriter(pathForRecord, false, Encoding.Default);
                foreach (var (word, replays) in dict)
                {
                    dict[word] = replays / countWords;
                    sw.WriteLine($"{word} -- {dict[word]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            #endregion

            #region Вывод частых пар на консоль (50 штук, отсортированных по частоте, где длина >= 4)

            var sortedDictByFrequency = dict
                .Where(pair => pair.Key.Length >= 4)
                .OrderByDescending(pair => pair.Value)
                .Take(50);
            
            Console.WriteLine("Наиболее частые слова:");
            Console.WriteLine("--------------------------------");
            foreach (var (word, frequency) in sortedDictByFrequency)
                Console.WriteLine($"{word} -- {frequency}");
            Console.WriteLine("--------------------------------");

            #endregion
        }
    }
}