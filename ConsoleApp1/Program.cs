using System;
using System.Collections.Generic;
using System.Linq;
using Syn.WordNet;
using System.Text.RegularExpressions;
using Iveonik.Stemmers;
using System.IO;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;

namespace SentimentAnalysis
{
    class Program
    {
        public static double? DesvioPad(List<int> dados)
        {
            if (dados.Count == 0)
                return null;
            if (dados.Count == 1)
                return null;

            float mean = (float)dados.Average();
            float sumSquaresOfDifferences = (float)dados.Select(val => (val - mean) * (val - mean)).Sum();
            double sd = Math.Round(Math.Sqrt(sumSquaresOfDifferences / (dados.Count - 1)), 2);

            return sd;
        }//Calcular Desvio Padrão

        public static double Media(List<int> dados)
        {
            if (dados.Count == 0)
                return 0;

            double mean = Math.Round(dados.Average(), 2);
            return mean;
        }//Calcular a Média

        public static string Mirror(string pre_words)
        {
            return new string(pre_words.ToCharArray().Reverse().ToArray());
        }//Inverter a ordem dos caracteres das Palavras (na Stack)

        public static List<Dictionary<string, double>> TF_IDF(List<List<string>> doc_words) //Calculate TF-IDF foreach document (Returns a list of docs)----------------------------------------
        {            
            List<KeyValuePair<string, double>> list_TF_IDF = new List<KeyValuePair<string, double>>();
            List<Dictionary<string, double>> list_docs = new List<Dictionary<string, double>>();
            Dictionary<string, double> word_TFIDF = new Dictionary<string, double>();

            int i = 0;
            foreach (List<string> document in doc_words)
            {
                word_TFIDF = list_TF_IDF.GroupBy(x => x.Key, (x, ys) => ys.First())
                                    .ToDictionary(x => x.Key, x => x.Value);
                list_docs.Add(word_TFIDF);

                foreach (string word in document)
                {
                    if (word.Length > 0)
                    {
                        double wordFrequency = (double)document.Where(d => d.Equals(word)).Count();
                        double termFrequency = (double)wordFrequency / document.Count();
                        double docsWithWord = doc_words.Where(d => d.Contains(word)).Count();
                        double inverseDocFrequency = (double)Math.Log((doc_words.Count / docsWithWord), 10.0);                      
                        if (!word_TFIDF.ContainsKey(word))
                            word_TFIDF.Add(word, Math.Round(termFrequency * inverseDocFrequency, 3));
                        i++;
                    }
                }
            }
            return list_docs;
        }

        public static List<List<string>> Top10_wordsDoc (List<Dictionary<string, double>> list_docs) //Show top 10 words for each Document--------------
        {
            List<string> top10 = new List<string>();
            List<List<string>> docs_top10 = new List<List<string>>();

            foreach (Dictionary<string, double> doc in list_docs)
            {
                top10 = doc.OrderByDescending(x => x.Value)
                                           .Select(p => p.Key)
                                           .Take(10).ToList();
                docs_top10.Add(top10);
            }
            return docs_top10;
        }
 
        public static List<List<string>> EnglishStemming (List<List<string>> doc_words)
        {
            EnglishStemmer stemmer = new EnglishStemmer();
            List<string> stemmed_words = new List<string>();
            List<List<string>> stem_docs = new List<List<string>>();
            List<string> test = new List<string>();
            //string sorting;

            int i = 0;
            foreach (List<string> doc in doc_words)
            {
                stemmed_words = test.Select(x => x).Distinct().ToList();
                stem_docs.Add(stemmed_words);

                foreach (string word in doc)
                {
                    if (word.Length > 0)
                    {
                        var stem_word = stemmer.Stem(word);
                        if (!stemmed_words.Contains(word))
                            stemmed_words.Add(stem_word);
                        i++;
                    }
                       
                }
            }
            return stem_docs;            
        }//Stem text in English--------------------------------------

        public static List<List<string>> PortugueseStemming(List<List<string>> doc_words) //Stem text in Portuguese-----------------------------------
        {
            PortugalStemmer stemmer = new PortugalStemmer();
            List<string> stemmed_words = new List<string>();
            List<List<string>> stem_docs = new List<List<string>>();
            List<string> test = new List<string>();
            //string sorting;

            int i = 0;
            foreach (List<string> doc in doc_words)
            {
                stemmed_words = test.Select(x => x).Distinct().ToList();
                stem_docs.Add(stemmed_words);

                foreach (string word in doc)
                {
                    if (word.Length > 0)
                    {
                        var stem_word = stemmer.Stem(word);
                        if (!stemmed_words.Contains(word))
                            stemmed_words.Add(stem_word);
                        i++;
                    }

                }
            }
            return stem_docs;
        }

        public static List<string> GetWordsList (string raw_input)
        {         
            string input_text = Regex.Replace(raw_input, @"\s+", " ").ToLower();
            string text = new string(input_text.Where(c => char.IsWhiteSpace(c) || char.IsLetter(c))
                                                 .ToArray());

            Tokenizer tokenizer = new Tokenizer();
            List<string> words = new List<string>();
            words = tokenizer.Tokenize(text);

            return words;

            //List<string> words = new List<string>(); //Alternativa a Tokenizer...
            //char[] delimiters = " ,.:".ToCharArray();
            //List<List<string>> doc_words = new List<List<string>>();

            //for (int j = 0; j < documents.Count; j++)
            //{
            //    words = documents[j].Split(delimiters).ToList();
            //    doc_words.Add(words);
            //}
        }//Pre-process input text to get Words----------------------------------------

        public static List<string> GetWordsList_NoStop (string raw_input, List<string> stopwords)
        {
            string input_text = Regex.Replace(raw_input, @"\s+", " ").ToLower();
            string text = new string(input_text.Where(c => char.IsWhiteSpace(c) || char.IsLetter(c))
                                                 .ToArray());

            Tokenizer tokenizer = new Tokenizer();
            List<string> words = new List<string>();
            words = tokenizer.Tokenize(text);
            List<string> words_NoStops = new List<string>();
            words_NoStops = words.Except(stopwords).ToList();

            return words_NoStops;
        }//Get Wordlist without Stopwords-------------------------------

        public static List<List<string>> GetDocList (string raw_input)
        {            
            string input_preDocs = new string(raw_input.Where(c => char.IsWhiteSpace(c) || char.IsLetter(c))
                                                 .ToArray());
            string input_docs = Regex.Replace(input_preDocs, @"[^\S\r\n]+", " ").ToLower();
            List<string> documents = input_docs.Split('\n').ToList();

            Tokenizer tokenizer = new Tokenizer();
            List<string> words = new List<string>();
            List<List<string>> doc_words = new List<List<string>>();

            for (int j = 0; j < documents.Count; j++)
            {
                words = tokenizer.Tokenize(documents[j]);
                doc_words.Add(words);
            }
            return doc_words;
        }//Pre-process input text to get Words foreach Document----------------------------------------

        public static List<List<string>> GetDocs_NoStopwords (string raw_input, List<string> stopwords)
        {           
            string input_preDocs = new string(raw_input.Where(c => char.IsWhiteSpace(c) || char.IsLetter(c))
                                                 .ToArray());
            string input_docs = Regex.Replace(input_preDocs, @"[^\S\r\n]+", " ").ToLower();
            List<string> documents = input_docs.Split('\n').ToList();

            Tokenizer tokenizer = new Tokenizer();
            List<string> words = new List<string>();
            List<List<string>> stopwords_docs = new List<List<string>>();            

            for (int j = 0; j < documents.Count; j++)
            {
                words = tokenizer.Tokenize(documents[j]);
                var words_NoStopwords = words.Except(stopwords).ToList();
                stopwords_docs.Add(words_NoStopwords);
            }
            return stopwords_docs;
        }//Remove Stopwords from text in each Document----------------------------------------

        public static Dictionary<string, Emotion> Emolex_eng(string path)
        {
            Dictionary<string, Emotion> emolex_eng = new Dictionary<string, Emotion>();

            using (StreamReader data = new StreamReader(path))
            {
                data.ReadLine();
                string line; 
                while ((line = data.ReadLine()) != null)
                {
                    string[] colunas = line.Split(';');
                    if (!emolex_eng.ContainsKey(colunas[0]))
                    {
                        emolex_eng.Add(colunas[0], new Emotion(Convert.ToInt32(colunas[2]), Convert.ToInt32(colunas[3]), Convert.ToInt32(colunas[4]),
                            Convert.ToInt32(colunas[5]), Convert.ToInt32(colunas[6]), Convert.ToInt32(colunas[7]), Convert.ToInt32(colunas[8]),
                            Convert.ToInt32(colunas[9]), Convert.ToInt32(colunas[10]), Convert.ToInt32(colunas[11])));
                    }
                }                    
            }            
            return emolex_eng;
        }//Read .csv file to get Eng_Emoticon-Lexicon----------------------------------------

        public static Dictionary<string, Emotion> Emolex_pt(string path)
        {
            Dictionary<string, Emotion> emolex_pt = new Dictionary<string, Emotion>();

            using (StreamReader data = new StreamReader(path))
            {
                data.ReadLine();
                string line;
                while ((line = data.ReadLine()) != null)
                {
                    string[] colunas = line.Split(';');
                    if (!emolex_pt.ContainsKey(colunas[1]))
                    {
                        emolex_pt.Add(colunas[23], new Emotion(int.Parse(colunas[2]), int.Parse(colunas[3]), int.Parse(colunas[4]),
                            int.Parse(colunas[5]), int.Parse(colunas[6]), int.Parse(colunas[7]), int.Parse(colunas[8]),
                            int.Parse(colunas[9]), int.Parse(colunas[10]), int.Parse(colunas[11])));
                    }
                }
            }
            return emolex_pt;
        }//Read .csv file to get Pt_Emoticon-Lexicon----------------------------------------
  
        public static Emotion Emotions(Dictionary<string, Emotion> emolex_language, List<string> words)
        {
            //List<Emotion> results_percent = new List<Emotion>();
            int positive = 0;
            int negative = 0;
            int anger = 0;
            int anticipation = 0;
            int disgust = 0;
            int fear = 0;
            int joy = 0;
            int sadness = 0;
            int surprise = 0;
            int trust = 0;

            for (int i = 0; i < words.Count; i++)
            {
                if (emolex_language.ContainsKey(words[i]))
                {
                    positive += emolex_language[words[i]].getPositive();
                    negative += emolex_language[words[i]].getNegative();
                    anger += emolex_language[words[i]].getAnger();
                    anticipation += emolex_language[words[i]].getAnticipation();
                    disgust += emolex_language[words[i]].getDisgust();
                    joy += emolex_language[words[i]].getJoy();
                    fear += emolex_language[words[i]].getFear();
                    sadness += emolex_language[words[i]].getSadness();
                    surprise += emolex_language[words[i]].getSurprise();
                    trust += emolex_language[words[i]].getTrust();
                }
            }
            int total_emot = anger + anticipation + disgust + joy + fear + sadness + surprise + trust;
            int polarity = negative + positive;
            if (polarity == 0)
            {
                polarity = 1;
            }
            if (total_emot == 0)
            {
                total_emot = 1;
            }
            var results_percent = new Emotion((positive * 100 / polarity), (negative * 100 / polarity),
                    (anger * 100 / total_emot), (anticipation * 100 / total_emot), (disgust * 100 / total_emot),
                    (fear * 100 / total_emot), (joy * 100 / total_emot), (sadness * 100 / total_emot),
                    (surprise * 100 / total_emot), (trust * 100 / total_emot));

            return results_percent;
        }//Extract Emotions (total) for input text (1 doc)--------------------------

        //public static List<List<Emotion>> Emotions_Docs(Dictionary<string, Emotion> emolex_language, List<List<string>> doc_words)
        //{            
        //    int positive = 0;
        //    int negative = 0;
        //    int anger = 0;
        //    int anticipation = 0;
        //    int disgust = 0;
        //    int fear = 0;
        //    int joy = 0;
        //    int sadness = 0;
        //    int surprise = 0;
        //    int trust = 0;
        //    int total_emot = 0;
        //    int polarity = 0;

        //    List<List<Emotion>> emotions_docs = new List<List<Emotion>>();
        //    List<Emotion> results_percent = new List<Emotion>();
        //    List<Emotion> sort = new List<Emotion>();

        //    int i = 0;
        //    foreach (List<string> document in doc_words)
        //    {
        //        total_emot = anger + anticipation + disgust + joy + fear + sadness + surprise + trust;
        //        polarity = negative + positive;
        //        if (polarity == 0)
        //        {
        //            polarity = 1;
        //        }
        //        if (total_emot == 0)
        //        {
        //            total_emot = 1;
        //        }

        //        results_percent.Add(new Emotion((positive * 100 / polarity), (negative * 100 / polarity),
        //        (anger * 100 / total_emot), (anticipation * 100 / total_emot), (disgust * 100 / total_emot),
        //        (fear * 100 / total_emot), (joy * 100 / total_emot), (sadness * 100 / total_emot),
        //        (surprise * 100 / total_emot), (trust * 100 / total_emot)));
        //        results_percent = sort.Select(x => x).ToList();
        //        emotions_docs.Add(results_percent);

        //        foreach (string word in document)
        //        {
        //            if (emolex_language.ContainsKey(word))
        //            {
        //                positive += emolex_language[word].getPositive();
        //                negative += emolex_language[word].getNegative();
        //                anger += emolex_language[word].getAnger();
        //                anticipation += emolex_language[word].getAnticipation();
        //                disgust += emolex_language[word].getDisgust();
        //                joy += emolex_language[word].getJoy();
        //                fear += emolex_language[word].getFear();
        //                sadness += emolex_language[word].getSadness();
        //                surprise += emolex_language[word].getSurprise();
        //                trust += emolex_language[word].getTrust();
        //                i++;
        //            }
        //        }
        //    }
        //    return emotions_docs;
        //}

        static Form MyForm;
        public static List<WordEvents> words = new List<WordEvents>();

        //----------------------------------------------Text Pre-Processing----------------------------------------------------------

        static void Main(string[] args)
        {
            List<KeystrokeEvent> listaEventos = new List<KeystrokeEvent>();
            try
            {
                using (StreamReader texto = new StreamReader("log.txt"))
                {
                    string line;
                    int i = 0;
                    while ((line = texto.ReadLine()) != null)
                    {
                        string[] colunas = line.Split(':');
                        if (colunas[2] == "OemMinus")       //Para não aumentar o tamanho da word! (+ tarde)
                        {
                            listaEventos.Add(new KeystrokeEvent(int.Parse(colunas[0]), "-"));
                            i++;
                        }
                        else
                        {
                            listaEventos.Add(new KeystrokeEvent(int.Parse(colunas[0]), colunas[2]));
                            i++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not open sample file!");
                Console.WriteLine(e.Message);
            }
// -----------------------------------1. Grouping keys based on Keyboard Layout------------------------------------------------------------------------

            List<string> Leftkeys = new List<string>(new string[] { "Q", "W", "E", "R", "T", "A", "S", "D", "F", "G", "Z", "X", "C", "V" });
            List<string> space = new List<string>(new string[] { "Space" });
            List<PairEvents> listaPares = new List<PairEvents>();
            char groupkey1;
            char groupkey2;

            for (int i = 0; i < listaEventos.Count - 2; i++)
            {
                if (Leftkeys.Contains(listaEventos[i].getCharacter()))
                    groupkey1 = 'L';
                else if (space.Contains(listaEventos[i].getCharacter()))
                    groupkey1 = 'S';
                else groupkey1 = 'R';

                if (Leftkeys.Contains(listaEventos[i + 1].getCharacter()))
                    groupkey2 = 'L';
                else if (space.Contains(listaEventos[i + 1].getCharacter()))
                    groupkey2 = 'S';
                else groupkey2 = 'R';

                int timePair = listaEventos[i + 1].getTimestamp() - listaEventos[i].getTimestamp();

                listaPares.Add(new PairEvents(timePair, listaEventos[i].getCharacter(), listaEventos[i + 1].getCharacter(), groupkey1 + "-" + groupkey2));

            }
 //-------------------------------2. Estatísticas a: Top 10 das teclas usadas e uso do Backspace----------------------------------------------------------------

            List<string> listaChars = new List<string>();
            List<int> listaTimes = new List<int>();

            for (int i = 0; i < listaEventos.Count; i++)
            {
                listaChars.Add(listaEventos[i].getCharacter());
                listaTimes.Add(listaEventos[i].getTimestamp());
            }

            string backspace = "Anterior";
            int contagem = listaChars.Where(x => x.Equals(backspace)).Count();
            int totalEvents = listaChars.Count;
            float percent = contagem * 100 / totalEvents;

            Console.WriteLine("----------------KeyStroke Analysis initiating!-----------------------");

            var topten = listaChars.GroupBy(s => s)
                    .OrderByDescending(o => o.Count())
                    .Select(g => new { keyPressed = g.Key, timesPressed = g.Count() })
                    .Take(10);

            Console.WriteLine("\n" + "----------Top 10 teclas e percentagem-----------");
            Console.WriteLine("\n");

            foreach (var item in topten)
                Console.WriteLine("\t" + item.keyPressed + "---> " + (item.timesPressed) * 100 / totalEvents + "%");

            Console.WriteLine("\n" + "----" + "A tecla Backspace foi usada---> " + percent + "%");

//----------------------------3. Estatísticas b: Médias e Desvios Padrões dos Tempos de escrita--------------------------------------------------

            List<int> listaTimePairs = new List<int>();

            for (int i = 0; i < listaPares.Count; i++)
            {
                listaTimePairs.Add(listaPares[i].getTimedif());
            }

            List<int> listRR = new List<int>();
            List<int> listRL = new List<int>();
            List<int> listRS = new List<int>();
            List<int> listLL = new List<int>();
            List<int> listLR = new List<int>();
            List<int> listLS = new List<int>();
            List<int> listSS = new List<int>();
            List<int> listSL = new List<int>();
            List<int> listSR = new List<int>();

            for (int i = 0; i < listaPares.Count; i++)
            {
                switch (listaPares[i].getKeygroup_pair())
                {
                    case "R-R":
                        listRR.Add(listaPares[i].getTimedif());
                        break;
                    case "R-L":
                        listRL.Add(listaPares[i].getTimedif());
                        break;
                    case "R-S":
                        listRS.Add(listaPares[i].getTimedif());
                        break;
                    case "L-L":
                        listLL.Add(listaPares[i].getTimedif());
                        break;
                    case "L-R":
                        listLR.Add(listaPares[i].getTimedif());
                        break;
                    case "L-S":
                        listLS.Add(listaPares[i].getTimedif());
                        break;
                    case "S-S":
                        listSS.Add(listaPares[i].getTimedif());
                        break;
                    case "S-L":
                        listSL.Add(listaPares[i].getTimedif());
                        break;
                    case "S-R":
                        listSR.Add(listaPares[i].getTimedif());
                        break;
                }
            }

            Console.WriteLine("\n" + "\t" + "-------------Média" + "\t" + "DesvioPadrão---------------");

            Console.WriteLine("\n" + "--" + "1.Group--->R-R: " + Media(listRR) + "\t" + DesvioPad(listRR));
            Console.WriteLine("--" + "2.Group--->R-L: " + Media(listRL) + "\t" + DesvioPad(listRL));
            Console.WriteLine("--" + "3.Group--->R-S: " + Media(listRS) + "\t" + DesvioPad(listRS));
            Console.WriteLine("--" + "4.Group--->L-L: " + Media(listLL) + "\t" + DesvioPad(listLL));
            Console.WriteLine("--" + "6.Group--->L-S: " + Media(listLS) + "\t" + DesvioPad(listLS));
            Console.WriteLine("--" + "7.Group--->S-S: " + Media(listSS) + "\t" + "\t" + DesvioPad(listSS));
            Console.WriteLine("--" + "8.Group--->S-L: " + Media(listSL) + "\t" + DesvioPad(listSL));
            Console.WriteLine("--" + "9.Group--->S-R: " + Media(listSR) + "\t" + DesvioPad(listSR));
            Console.WriteLine("\n" + "--" + "10.Total-->All: " + Media(listaTimes) + "\t" + DesvioPad(listaTimes));

            //---------------------------------4. Separação de palavras, adicionar à nova classe de WordEvents------------------------------------------

            List<string> delimiters = new List<string>(new string[] { "Space", "OemPeriod", "Oemcomma", "Enter" });
            int start = 0;
            int end = 0;
            string pre_words = "";
            int delFound = 0;
            //List<WordEvents> words = new List<WordEvents>();
            Stack<KeystrokeEvent> stack = new Stack<KeystrokeEvent>();

            for (int i = 0; i < listaEventos.Count - 1; i++)
            {
                if (!delimiters.Contains(listaEventos[i].getCharacter()) && listaEventos[i].getCharacter() != backspace)
                {
                    stack.Push(listaEventos[i]);

                }
                else if (listaEventos[i].getCharacter() == backspace)
                {
                    if (stack.Count() > 0)
                    {
                        stack.Pop();
                        delFound++;
                    }
                }
                else if (delimiters.Contains(listaEventos[i].getCharacter()) && delimiters.Contains(listaEventos[i + 1].getCharacter()))
                {
                    end = stack.Peek().getTimestamp();
                }
                else if (delimiters.Contains(listaEventos[i].getCharacter()) && listaEventos[i + 1].getCharacter() != backspace)
                {
                    if (stack.Count() > 0)
                    {
                        end = stack.Peek().getTimestamp();
                    }
                    while (stack.Count() > 0)
                    {
                        pre_words = pre_words + stack.Peek().getCharacter();
                        stack.Pop();
                        if (stack.Count() == 1)
                        {
                            start = stack.Peek().getTimestamp();
                        }
                    }
                    words.Add(new WordEvents((end - start), Mirror(pre_words), delFound, pre_words.Length));
                    delFound = 0;
                    pre_words = string.Empty;
                }
            }

            // --------------------------------------5.Estatísticas c: Top 10 words e percentagem------------------------------------------------

            List<KeyValuePair<int, string>> wordBackspace = new List<KeyValuePair<int, string>>();
            List<string> listaWords = new List<string>();

            for (int i = 0; i < words.Count(); i++)
            {
                listaWords.Add(words[i].getword());
                var kvp = new KeyValuePair<int, string>(words[i].getbackspace_found(), words[i].getword());
                wordBackspace.Add(kvp);
            }

            var toptenWords = listaWords.GroupBy(s => s)
                    .OrderByDescending(o => o.Count())
                    .Select(g => new { word = g.Key, counter = g.Count() })
                    .Take(10);

            Console.WriteLine("\n" + "----------Top 10 palavras e percentagem-----------");
            Console.WriteLine("\n");

            foreach (var item in toptenWords)
                Console.WriteLine("\t" + item.word + "---> " + Math.Round((double)(item.counter) * 100 / listaWords.Count, 2) + "%");

            //-------------------------------------6. Estatísticas d: Percentagem de Erros nas Palavras----------------------------------------------------

            int wrongWords = wordBackspace.Where(kvp => kvp.Key > 0).Count();
            int totalWords = listaWords.Count;
            float percent2 = wrongWords * 100 / totalWords;

            Console.WriteLine("\n" + "----" + "Percentagem de erros TOTAL ---> " + percent2 + "%");

            var errosByChar = (from kvp in wordBackspace
                               orderby kvp.Value.Length
                               where kvp.Key > 0
                               group kvp by kvp.Value.Length into grp
                               select new { nChars = grp.Key, errosCount = grp.Count() });

            Console.WriteLine("\n" + "---------Percentagem de Erros conforme o Tamanhdo das Palavras---------------" + "\n");

            foreach (var item in errosByChar)
                if (item.nChars > 1)
                {
                    Console.WriteLine("No.chars: " + item.nChars + "---->" + Math.Round((double)(item.errosCount) * 100 / listaWords.Count, 2) + "%");
                }

            //-------------------------------------7. Estatísticas e:  Médias e Desvios do Tempo de Escrita----------------------------------------------------          

            List<int> listDeltaTimes = new List<int>();
            List<KeyValuePair<int, int>> timeWordSize = new List<KeyValuePair<int, int>>();
            Dictionary<int, List<int>> timesChars = new Dictionary<int, List<int>>();

            for (int i = 0; i < words.Count(); i++)
            {
                listDeltaTimes.Add(words[i].getdeltatime());

                if (timesChars.ContainsKey(words[i].getword_size()))
                {
                    timesChars[words[i].getword_size()].Add(words[i].getdeltatime());
                }
                else
                {
                    timesChars[words[i].getword_size()] = new List<int> { words[i].getdeltatime() };
                }
            }

            Console.WriteLine("\n" + "-------Palavras: Média-----" + "\t" + "-----DesvioPadrão---------------\n");

            foreach (KeyValuePair<int, List<int>> kvp in timesChars.OrderBy(i => i.Key).Where(x => x.Key > 1))
            {
                Console.WriteLine("No.Chars: {0} \t {1} \t {2}", kvp.Key, Media(kvp.Value), DesvioPad(kvp.Value));
            }

            Console.WriteLine("\n" + "--------------------KeyStroke Analysis completed!--------------------");


                     //  ███████╗███████╗███╗   ██╗████████╗██╗███╗   ███╗███████╗███╗   ██╗████████╗
                     //  ██╔════╝██╔════╝████╗  ██║╚══██╔══╝██║████╗ ████║██╔════╝████╗  ██║╚══██╔══╝
                     //  ███████╗█████╗  ██╔██╗ ██║   ██║   ██║██╔████╔██║█████╗  ██╔██╗ ██║   ██║   
                     //  ╚════██║██╔══╝  ██║╚██╗██║   ██║   ██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║   
                     //  ███████║███████╗██║ ╚████║   ██║   ██║██║ ╚═╝ ██║███████╗██║ ╚████║   ██║   
                     //  ╚══════╝╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚═╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝   

            //string raw_input = "This this text feature must\nhave the the @possibility\n of 25 the (analyzing)[}=$%# :both and both \nregular! text both and stemmed text";
            //var Form1 = new Form(); 
            //string raw_input = Form1.InputTextBox.Text;  // Não funciona! 

 //----------------------------------------------Text Input and Pre-Processing----------------------------------------------------------

            Console.WriteLine("----------------------Sentiment Analysis Starting----------------------------\n");
            //string raw_input = File.ReadAllText("sample.txt");
            MyForm = new Form();
            string raw_input = MyForm.InputTextBox.Text;
            string input_NGrams = Regex.Replace(raw_input, @"\s+", " ").ToLower();
            string text = new string(input_NGrams.Where(c => char.IsWhiteSpace(c) || char.IsLetter(c))
                                                 .ToArray());

            Tokenizer tokenizer = new Tokenizer();
            List<string> tokens = new List<string>();
            tokens = tokenizer.Tokenize(text);

//---------------------------------------------------Create N-Grams-------------------------------------------------

            Console.WriteLine("--------------List of Bigrams-----------------\n");
            List<string> pairs = new List<string>();
            for (int i = 0; i < tokens.Count - 1; i++)
            {
                pairs.Add(tokens[i] + " " + tokens[i + 1]);
                Console.WriteLine(pairs[i]);
            }
            Console.WriteLine("--------------List of Trigrams----------------\n");
            List<string> trios = new List<string>();
            for (int i = 0; i < tokens.Count - 2; i++)
            {
                trios.Add(tokens[i] + " " + tokens[i + 1] + " " + tokens[i + 2]);
                Console.WriteLine(trios[i]);
            }

   //------------------------------Calculate TF-IDF for each Document using Method (Regular Text)----------------------------------------------------
   
            Console.WriteLine("------------TF-IDF for each word in Document------------------\n");

            var doc_words = GetDocList(raw_input);
            var list_docs = TF_IDF(doc_words);
            int doc_count = 1;
            foreach (Dictionary<string, double> doc in list_docs)
            {
                Console.WriteLine("\nDocument " + doc_count++);

                foreach (KeyValuePair<string, double> kvp in doc)
                {
                    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            }
//--------------------------------Get Keywords (10) for each Document using method (regular text)-------------------------------------------

            Console.WriteLine("---------Top 10 words for each Document-------------\n");

            var docs_top10 = Top10_wordsDoc(list_docs);

            int counter_doc = 1;
            foreach (List<string> doc in docs_top10)
            {
                Console.WriteLine("\nDocument " + counter_doc++);

                foreach (string word in doc)
                {
                    Console.WriteLine(word);
                }
            }
 //----------------------------------Calculate TF-IDF foreach doc (Stemmed Text)-----------------------------------------------------

            Console.WriteLine("----------TF-IDF for each word in Document (Stemmed Text)------------\n");
            var stemmed_docs = EnglishStemming(doc_words);
            var list_docsStem = TF_IDF(stemmed_docs);
            int count_doc = 1;
            foreach (Dictionary<string, double> doc in list_docsStem)
            {
                Console.WriteLine("\nDocument " + count_doc++);

                foreach (KeyValuePair<string, double> kvp in doc)
                {
                    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            }
//-----------------------------------Get Keywords (10) for each Doc (Stemmed text)--------------------------------------------

            Console.WriteLine("--------------------------------Top 10 words for each Document (Stemmed Text)----------------------------------------\n");
            var stemDocs_top10 = Top10_wordsDoc(list_docsStem);

            int count = 1;
            foreach (List<string> doc in stemDocs_top10)
            {
                Console.WriteLine("\nDocument " + count++);

                foreach (string word in doc)
                {
                    Console.WriteLine(word);
                }
            }
//-----------------------------Removing Stopwords: TF-IDF foreach doc (Regular Text)------------------------------------------------------------

            Console.WriteLine("--------------------------------TF-IDF for each word in Document (No Stopwords)----------------------------------------\n");

            List<string> stopwords = new List<string>();//How to link this to Form?

            var stopwords_docs = GetDocs_NoStopwords(raw_input, stopwords);
            var stoplist_docs = TF_IDF(stopwords_docs);
            //int counting = 1;
            foreach (Dictionary<string, double> doc in stoplist_docs)
            {
                //Console.WriteLine("\nDocument " + counting++);

                foreach (KeyValuePair<string, double> kvp in doc)
                {
                    //Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            }
 //-----------------------------------Get Keywords (10) for each Doc NO Stopwords (Regular text)--------------------------------------------

            Console.WriteLine("-------------Top 10 words for each Document (No Stopwords)------------\n");
            var stopdocs_top10 = Top10_wordsDoc(stoplist_docs);

            //int p = 1;
            foreach (List<string> doc in stopdocs_top10)
            {
                //Console.WriteLine("\nDocument " + p++);

                foreach (string word in doc)
                {
                    //Console.WriteLine(word);
                }
            }
//-----------------------------Removing Stopwords: TF-IDF foreach doc (Stemmed Text)------------------------------------------------------------

            Console.WriteLine("-----------TF-IDF for each word in Document (Stemmed Text_No Stopwords)------\n");
            var stopStem_docs = EnglishStemming(stopwords_docs);
            var stoplist_docStem = TF_IDF(stopStem_docs);
            //int k = 1;
            foreach (Dictionary<string, double> doc in stoplist_docStem)
            {
                //Console.WriteLine("\nDocument " + k++);

                foreach (KeyValuePair<string, double> kvp in doc)
                {
                    //Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            }
//-----------------------------------Get Keywords (10) for each Doc NO Stopwords (Stemmed text)--------------------------------------------

            Console.WriteLine("-----------Top 10 words for each Document (Stemmed Text_No Stopwords)-----------\n");
            var stopStemDocs_top10 = Top10_wordsDoc(stoplist_docStem);

            //int m = 1;
            foreach (List<string> doc in stopStemDocs_top10)
            {
                //Console.WriteLine("\nDocument " + m++);

                foreach (string word in doc)
                {
                    //Console.WriteLine(word);
                }
            }
 //----------------------------------------------Get Polarity & Emotions (percentage) for total Text-----------------------------------------

            var word_list = GetWordsList(raw_input);            
            var emolex_eng = Emolex_eng("lexico.csv");
            var emotionsEng = Emotions(emolex_eng, word_list);            
            var docs = GetDocList(raw_input);
            var list_stem = EnglishStemming(docs);
            var list_stem2 = list_stem.SelectMany(x => x).ToList();
            var emotionsEng2 = Emotions(emolex_eng, list_stem2);
            //var emotions = Emotions_Docs(emolex_eng, docs);
            //var emotions2 = Emotions_Docs(emolex_eng, list_stem);

            //var emolex_pt = Emolex_pt("lexico.csv");
            //var emotionsPT = Emotions(emolex_pt, word_list);

            Console.WriteLine("Positive: {0} %, Negative: {1} %, Anger: {2} %, Anticipation: {3} %, Disgust: {4} %, Fear: {5}" +
               "Joy: {6} %, Sadness: {7} %, Surprise: {8} %, Trust: {9} %", emotionsEng.getPositive(), emotionsEng.getNegative(),
               emotionsEng.getAnger(), emotionsEng.getAnticipation(), emotionsEng.getDisgust(), emotionsEng.getFear(),
               emotionsEng.getJoy(), emotionsEng.getSadness(), emotionsEng.getSurprise(), emotionsEng.getTrust());

            Console.WriteLine("---------------------Stemmed Text------------");

            Console.WriteLine("Positive: {0} %, Negative: {1} %, Anger: {2} %, Anticipation: {3} %, Disgust: {4} %, Fear: {5}" +
               "Joy: {6} %, Sadness: {7} %, Surprise: {8} %, Trust: {9} %", emotionsEng2.getPositive(), emotionsEng2.getNegative(),
               emotionsEng2.getAnger(), emotionsEng2.getAnticipation(), emotionsEng2.getDisgust(), emotionsEng2.getFear(),
               emotionsEng2.getJoy(), emotionsEng2.getSadness(), emotionsEng2.getSurprise(), emotionsEng2.getTrust());

            //int m = 1;
            ////for (int i = 0; i < emotions.Count; i++)
            ////{
            //foreach (List<Emotion> doc in emotions)
            //    {
            //        Console.WriteLine("\nDocument " + m++);

            //        foreach (Emotion emotion in doc)
            //        {
            //            Console.WriteLine("Positive: {0} %, Negative: {1} %, Anger: {2} %, Anticipation: {3} %, Disgust: {4} %, Fear: {5}" +
            //      "Joy: {6} %, Sadness: {7} %, Surprise: {8} %, Trust: {9} %", emotion.getPositive(), emotion.getNegative(),
            //      emotion.getAnger(), emotion.getAnticipation(), emotion.getDisgust(), emotion.getFear(),
            //      emotion.getJoy(), emotion.getSadness(), emotion.getSurprise(), emotion.getTrust());
            //        }
            //    }

            //Console.WriteLine("Positivo: {0} %, Negativo: {1} %, Raiva: {2} %, Antecipação: {3} %, Nojo: {4} %, Medo: {5}" +
            //   "Alegria: {6} %, Tristeza: {7} %, Surpresa: {8} %, Confiança: {9} %", emotionsPT.getPositive(), emotionsPT.getNegative(),
            //   emotionsPT.getAnger(), emotionsPT.getAnticipation(), emotionsPT.getDisgust(), emotionsPT.getFear(),
            //   emotionsPT.getJoy(), emotionsPT.getSadness(), emotionsPT.getSurprise(), emotionsPT.getTrust());

            Console.WriteLine("\n--------------------------Sentiment Analysis Finished------------------------------------");

           
        
            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(MyForm);

            Console.ReadLine();
        }

    }
}

    

