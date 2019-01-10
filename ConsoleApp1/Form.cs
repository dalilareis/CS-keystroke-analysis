using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SentimentAnalysis
{
    public partial class Form : System.Windows.Forms.Form
    {
        DataTable corrs;
        DataTable stats;

        public Form()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Stopwords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void List_StopwordsButton_Click(object sender, EventArgs e)
        {
            Bigrams.Clear();
            Trigrams.Clear();
            Stopwords.Items.Clear();

            string raw_input = this.InputTextBox.Text;
            var tokens = Program.GetWordsList(raw_input);

            for (int i = 0; i < tokens.Count - 1; i++)
            {
                Bigrams.Items.Add(tokens[i] + " " + tokens[i + 1]);
            }

            for (int i = 0; i < tokens.Count - 2; i++)
            {
                Trigrams.Items.Add(tokens[i] + " " + tokens[i + 1] + " " + tokens[i + 2]);
            }
            List<string> stopwords = new List<string>();
            stopwords = tokens.Distinct().OrderBy(n => n).ToList();

            for (int i = 0; i < stopwords.Count; i++)
            {
                Stopwords.Items.Add(stopwords[i]);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void DataEmotions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Trigrams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Bigrams.Clear();
            Trigrams.Clear();
            Stopwords.Items.Clear();
            Top_10NoStops.Clear();
            top_10_Stem.Clear();
            Top_10Words.Clear();
            Stem_NoStops.Clear();            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Top_10_NoStopsButton_Click_1(object sender, EventArgs e)
        {
            Top_10NoStops.Clear();

            string raw_input = this.InputTextBox.Text;
            List<string> stopwords = new List<string>();

            if (Stopwords.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Stopwords selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < Stopwords.Items.Count; i++)
                {
                    if (Stopwords.GetItemChecked(i))
                    {
                        stopwords.Add((string)Stopwords.Items[i]);
                    }
                }
                var stopwords_docs = Program.GetDocs_NoStopwords(raw_input, stopwords);
                var stoplist_docs = Program.TF_IDF(stopwords_docs);

                var top10_noStops = stoplist_docs.SelectMany(x => x).OrderBy(x => x.Value).Select(x => x.Key).Distinct().Take(10).ToList();

                for (int i = 0; i < top10_noStops.Count; i++)
                {
                    Top_10NoStops.Items.Add(top10_noStops[i]);
                }
            }
        }

        private void Top10_wordsButton_Click(object sender, EventArgs e)
        {
            Top_10Words.Clear();
            string raw_input = this.InputTextBox.Text;
            var doc_words = Program.GetDocList(raw_input);
            var list_docs = Program.TF_IDF(doc_words);

            var top10_words = list_docs.SelectMany(x => x).OrderBy(x => x.Value).Select(x => x.Key).Distinct().Take(10).ToList();

            for (int i = 0; i < top10_words.Count; i++)
            {
                Top_10Words.Items.Add(top10_words[i]);
            }
        }

        private void comboTop10_SelectedIndexChanged(object sender, EventArgs e)
        {
            top_10_Stem.Clear();

#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (comboTop10.SelectedItem == "Stemmed Text_Eng")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                string raw_input = this.InputTextBox.Text;
                var doc_words = Program.GetDocList(raw_input);
                var stemmed_docs = Program.EnglishStemming(doc_words);
                var list_docsStem = Program.TF_IDF(stemmed_docs);

                var top10_StemEng = list_docsStem.SelectMany(x => x).OrderBy(x => x.Value).Select(x => x.Key).Distinct().Take(10).ToList();

                for (int i = 0; i < top10_StemEng.Count; i++)
                {
                    top_10_Stem.Items.Add(top10_StemEng[i]);
                }
            }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            else if (comboTop10.SelectedItem == "Stemmed Text_Pt")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                string raw_input = this.InputTextBox.Text;
                var doc_words = Program.GetDocList(raw_input);
                var stemmed_docs = Program.PortugueseStemming(doc_words);
                var list_docStem = Program.TF_IDF(stemmed_docs);

                var top10_StemPt = list_docStem.SelectMany(x => x).OrderBy(x => x.Value).Select(x => x.Key).Distinct().Take(10).ToList();

                for (int i = 0; i < top10_StemPt.Count; i++)
                {
                    top_10_Stem.Items.Add(top10_StemPt[i]);
                }
            }
        }

        private void comboNoStops_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stem_NoStops.Clear();

#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (comboNoStops.SelectedItem == "Stemmed Text_Eng")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                string raw_input = this.InputTextBox.Text;
                List<string> stopwords = new List<string>();

                if (Stopwords.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No Stopwords selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < Stopwords.Items.Count; i++)
                    {
                        if (Stopwords.GetItemChecked(i))
                        {
                            stopwords.Add((string)Stopwords.Items[i]);
                        }
                    }
                    var stopwords_docs = Program.GetDocs_NoStopwords(raw_input, stopwords);
                    var stopStem_docs = Program.EnglishStemming(stopwords_docs);
                    var stoplist_docStem = Program.TF_IDF(stopStem_docs);

                    var top10_StemEngNoStops = stoplist_docStem.SelectMany(x => x).OrderBy(x => x.Value).Select(x => x.Key).Distinct().Take(10).ToList();

                    for (int i = 0; i < top10_StemEngNoStops.Count; i++)
                    {
                        Stem_NoStops.Items.Add(top10_StemEngNoStops[i]);
                    }
                }
            }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            else if (comboNoStops.SelectedItem == "Stemmed Text_Pt")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                string raw_input = this.InputTextBox.Text;
                List<string> stopwords = new List<string>();

                if (Stopwords.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No Stopwords selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < Stopwords.Items.Count; i++)
                    {
                        if (Stopwords.GetItemChecked(i))
                        {
                            stopwords.Add((string)Stopwords.Items[i]);
                        }
                    }
                    var stopwords_docs = Program.GetDocs_NoStopwords(raw_input, stopwords);
                    var stopStem_docs = Program.PortugueseStemming(stopwords_docs);
                    var stoplist_docStem = Program.TF_IDF(stopStem_docs);

                    var top10_StemPtNoStops = stoplist_docStem.SelectMany(x => x).OrderBy(x => x.Value).Select(x => x.Key).Distinct().Take(10).ToList();

                    for (int i = 0; i < top10_StemPtNoStops.Count; i++)
                    {
                        Stem_NoStops.Items.Add(top10_StemPtNoStops[i]);
                    }
                }
            }
        }

        private void EmotionEngButton_Click(object sender, EventArgs e)
        {
            string raw_input = this.InputTextBox.Text;
            List<string> stopwords = new List<string>
            {
                this.Stopwords.SelectedItems.ToString()
            };
            var words_noStops = Program.GetWordsList_NoStop(raw_input, stopwords);
            var docs_noStops = Program.GetDocs_NoStopwords(raw_input, stopwords);
            var stemmed_Docs = Program.EnglishStemming(docs_noStops);
            var stemmed_words = stemmed_Docs.SelectMany(x => x).ToList();
            var emolex_eng = Program.Emolex_eng("lexico.csv");
            var emotion = Program.Emotions(emolex_eng, words_noStops);
            var emotion2 = Program.Emotions(emolex_eng, stemmed_words);

            DataTable table = new DataTable();
            table.Columns.Add("Text Type", typeof(string));
            table.Columns.Add("Positive_%", typeof(int));
            table.Columns.Add("Negative_%", typeof(int));
            table.Columns.Add("Anger_%", typeof(int));
            table.Columns.Add("Anticipation_%", typeof(int));
            table.Columns.Add("Disgust_%", typeof(int));
            table.Columns.Add("Fear_%", typeof(int));
            table.Columns.Add("Joy_%", typeof(int));
            table.Columns.Add("Sadness_%", typeof(int));
            table.Columns.Add("Surprise_%", typeof(int));
            table.Columns.Add("Trust_%", typeof(int));

            table.Rows.Add("Normal Text", emotion.getPositive(), emotion.getNegative(), emotion.getAnger(), emotion.getAnticipation(),
               emotion.getDisgust(), emotion.getFear(), emotion.getJoy(), emotion.getSadness(), emotion.getSurprise(), emotion.getTrust());

            table.Rows.Add("Stemmed Text", emotion2.getPositive(), emotion2.getNegative(), emotion2.getAnger(), emotion2.getAnticipation(),
              emotion2.getDisgust(), emotion2.getFear(), emotion2.getJoy(), emotion2.getSadness(), emotion2.getSurprise(), emotion2.getTrust());

            DataEmotions.DataSource = table;
        }

        private void comboEmotion_SelectedIndexChanged(object sender, EventArgs e)
        {
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (comboEmotion.SelectedItem == "Analysis_Pt")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                string raw_input = this.InputTextBox.Text;
                List<string> stopwords = new List<string>
            {
                this.Stopwords.SelectedItems.ToString()
            };
                var words_noStops = Program.GetWordsList_NoStop(raw_input, stopwords);
                var emolex_eng = Program.Emolex_eng("lexico.csv");
                var emotion = Program.Emotions(emolex_eng, words_noStops); ;

                DataTable table = new DataTable();
                table.Columns.Add("Positivo_%", typeof(int));
                table.Columns.Add("Negativo_%", typeof(int));
                table.Columns.Add("Raiva_%", typeof(int));
                table.Columns.Add("Antecipação_%", typeof(int));
                table.Columns.Add("Nojo_%", typeof(int));
                table.Columns.Add("Medo_%", typeof(int));
                table.Columns.Add("Alegria_%", typeof(int));
                table.Columns.Add("Tristeza_%", typeof(int));
                table.Columns.Add("Surpresa_%", typeof(int));
                table.Columns.Add("Confiança_%", typeof(int));

                table.Rows.Add(emotion.getPositive(), emotion.getNegative(), emotion.getAnger(), emotion.getAnticipation(),
                    emotion.getDisgust(), emotion.getFear(), emotion.getJoy(), emotion.getSadness(), emotion.getSurprise(), emotion.getTrust());

                DataEmotions.DataSource = table;
            }
        }

        private void Button_Stats_Click(object sender, EventArgs e)
        {
            string raw_input = this.InputTextBox.Text;
            List<string> stopwords = new List<string>
            {
                this.Stopwords.SelectedItems.ToString()
            };
            List<string> words = new List<string>();
            List<double> errosTexto = new List<double>();
            List<double> tempoEscrita = new List<double>();
            List<double> wordSize = new List<double>();
            List<Emotion> list_Emotions = new List<Emotion>();
            List<double> tfidf = new List<double>();

            var stopwords_docs = Program.GetDocs_NoStopwords(raw_input, stopwords);
            var stoplist_docs = Program.TF_IDF(stopwords_docs);
            var tfidf_Words = stoplist_docs.SelectMany(x => x).OrderBy(x => x.Value).Distinct();
            var word_list = Program.GetWordsList(raw_input);
            var emolex_eng = Program.Emolex_eng("lexico.csv");

            for (int i = 0; i < word_list.Count; i++)
            {
                if (emolex_eng.ContainsKey(word_list[i]))
                {
                    tfidf.Add(tfidf_Words.Where(x => x.Key == word_list[i]).Select(x => x.Value).FirstOrDefault());
                    words.Add(Program.words[i].getword());
                    errosTexto.Add((double)Program.words[i].getbackspace_found());
                    tempoEscrita.Add((double)Program.words[i].getdeltatime());
                    wordSize.Add((double)Program.words[i].getword_size());
                    list_Emotions.Add(new Emotion(emolex_eng[word_list[i]].getPositive(), emolex_eng[word_list[i]].getNegative(), emolex_eng[word_list[i]].getAnger(),
                        emolex_eng[word_list[i]].getAnticipation(), emolex_eng[word_list[i]].getDisgust(), emolex_eng[word_list[i]].getFear(),
                        emolex_eng[word_list[i]].getJoy(), emolex_eng[word_list[i]].getSadness(), emolex_eng[word_list[i]].getSurprise(), emolex_eng[word_list[i]].getTrust()));
                }
            }

            stats = new DataTable();
            stats.Columns.Add("Words", typeof(string));
            stats.Columns.Add("Delta Time", typeof(double));
            stats.Columns.Add("Word Size", typeof(double));
            stats.Columns.Add("Backspace Used", typeof(double));
            stats.Columns.Add("TF-IDF", typeof(double));
            stats.Columns.Add("Positive", typeof(double));
            stats.Columns.Add("Negative", typeof(double));
            stats.Columns.Add("Anger", typeof(double));
            stats.Columns.Add("Anticipation", typeof(double));
            stats.Columns.Add("Disgust", typeof(double));
            stats.Columns.Add("Fear", typeof(double));
            stats.Columns.Add("Joy", typeof(double));
            stats.Columns.Add("Sadness", typeof(double));
            stats.Columns.Add("Surprise", typeof(double));
            stats.Columns.Add("Trust", typeof(double));


            for (int i = 0; i < wordSize.Count; i++)
            {
                stats.Rows.Add(words[i], tempoEscrita[i], wordSize[i], errosTexto[i], tfidf[i], (double)list_Emotions[i].getPositive(),
                   (double)list_Emotions[i].getNegative(), (double)list_Emotions[i].getAnger(), (double)list_Emotions[i].getAnticipation(),
                   (double)list_Emotions[i].getDisgust(), (double)list_Emotions[i].getFear(), (double)list_Emotions[i].getJoy(),
                   (double)list_Emotions[i].getSadness(), (double)list_Emotions[i].getSurprise(), (double)list_Emotions[i].getTrust());
            }

            data_All_Words.DataSource = stats;

            corrs = new DataTable();
            corrs.Columns.Add("Correlations", typeof(string));
            corrs.Columns.Add("Delta Time", typeof(double));
            corrs.Columns.Add("Word Size", typeof(double));
            corrs.Columns.Add("Backspace Used", typeof(double));
            corrs.Columns.Add("TF-IDF", typeof(double));
            corrs.Columns.Add("Positive", typeof(double));
            corrs.Columns.Add("Negative", typeof(double));
            corrs.Columns.Add("Anger", typeof(double));
            corrs.Columns.Add("Anticipation", typeof(double));
            corrs.Columns.Add("Disgust", typeof(double));
            corrs.Columns.Add("Fear", typeof(double));
            corrs.Columns.Add("Joy", typeof(double));
            corrs.Columns.Add("Sadness", typeof(double));
            corrs.Columns.Add("Surprise", typeof(double));
            corrs.Columns.Add("Trust", typeof(double));

            List<string> rowHeaders = corrs.Columns.Cast<DataColumn>().Select(x => x.ColumnName).Where(x => x != "Correlations").ToList();
            List<double> tempoCor = new List<double>();
            List<double> wordSizeCor = new List<double>();
            List<double> backspaceCor = new List<double>();
            List<double> tfidfCor = new List<double>();
            List<double> positiveCor = new List<double>();
            List<double> negativeCor = new List<double>();
            List<double> angerCor = new List<double>();
            List<double> anticipationCor = new List<double>();
            List<double> disgustCor = new List<double>();
            List<double> fearCor = new List<double>();
            List<double> joyCor = new List<double>();
            List<double> sadnessCor = new List<double>();
            List<double> surpriseCor = new List<double>();
            List<double> trustCor = new List<double>();

            for (int i = 1; i < stats.Columns.Count; i++)
            {
                tempoCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[1]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                wordSizeCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[2]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                backspaceCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[3]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                tfidfCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[4]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                positiveCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[5]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                negativeCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[6]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                angerCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[7]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                anticipationCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[8]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                disgustCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[9]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                fearCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[10]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                joyCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[11]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                sadnessCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[12]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                surpriseCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[13]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                trustCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[14]).ToList(),
                    (from DataRow row in stats.Rows select (double)row[i]).ToList()));
            }

            for (int i = 0; i < corrs.Columns.Count - 1; i++)
            {
                corrs.Rows.Add(rowHeaders[i], tempoCor[i], wordSizeCor[i], backspaceCor[i], tfidfCor[i], positiveCor[i], negativeCor[i], angerCor[i],
                anticipationCor[i], disgustCor[i], fearCor[i], joyCor[i], sadnessCor[i], surpriseCor[i], trustCor[i]);

            }
            dataCorrelations.DataSource = corrs;
        }

        private void SaveXML_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(stats);
            stats.WriteXml(@"C:\stats.xml");
            DataSet ds2 = new DataSet();
            ds2.Tables.Add(corrs);
            corrs.WriteXml(@"C:\correlations.xml");
        }

        private void data_All_Words_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataCorrelations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_StrongCorr_Click(object sender, EventArgs e)
        {
            DataView strongest = new DataView(corrs);

            //corrs.DefaultView.RowFilter = "[Word Size] <> 1 and [Backspace Used] <> 1 and [TF-IDF] <> 1 and [Positive] <> 1 and [Negative] <> 1 and [Anger] <> 1";          

            //strongest.AddNew(corrs.Rows.where)
            //corrs.DefaultView
            //"ID = '23' or ID = '46'";
            //DataGridViewCellStyle positive_corr = new DataGridViewCellStyle();
            //positive_corr.ForeColor = Color.AntiqueWhite;
            //positive_corr.BackColor = Color.ForestGreen;
            //positive_corr.Font = new Font(dataCorrelations.Font, FontStyle.Bold);
        }

        private void dataStrongCorrelations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboStats_SelectedIndexChanged(object sender, EventArgs e)
        {
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (comboStats.SelectedItem == "List Statistics_Pt")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                List<string> words = new List<string>();
                List<double> errosTexto = new List<double>();
                List<double> tempoEscrita = new List<double>();
                List<double> wordSize = new List<double>();
                List<Emotion> list_Emotions = new List<Emotion>();

                string raw_input = this.InputTextBox.Text;
                var word_list = Program.GetWordsList(raw_input);
                var emolex_pt = Program.Emolex_pt("lexico.csv");

                for (int i = 0; i < word_list.Count; i++)
                {
                    if (emolex_pt.ContainsKey(word_list[i]))
                    {
                        words.Add(Program.words[i].getword());
                        errosTexto.Add((double)Program.words[i].getbackspace_found());
                        tempoEscrita.Add((double)Program.words[i].getdeltatime());
                        wordSize.Add((double)Program.words[i].getword_size());
                        list_Emotions.Add(new Emotion(emolex_pt[word_list[i]].getPositive(), emolex_pt[word_list[i]].getNegative(), emolex_pt[word_list[i]].getAnger(),
                            emolex_pt[word_list[i]].getAnticipation(), emolex_pt[word_list[i]].getDisgust(), emolex_pt[word_list[i]].getFear(),
                            emolex_pt[word_list[i]].getJoy(), emolex_pt[word_list[i]].getSadness(), emolex_pt[word_list[i]].getSurprise(), emolex_pt[word_list[i]].getTrust()));
                    }
                }

                stats = new DataTable();
                stats.Columns.Add("Palavras", typeof(string));
                stats.Columns.Add("Tempo de Escrita", typeof(double));
                stats.Columns.Add("Tamanho Palavra", typeof(double));
                stats.Columns.Add("Uso do Delete", typeof(double));
                stats.Columns.Add("Positivo", typeof(double));
                stats.Columns.Add("Negativo", typeof(double));
                stats.Columns.Add("Raiva", typeof(double));
                stats.Columns.Add("Antecipação", typeof(double));
                stats.Columns.Add("Nojo", typeof(double));
                stats.Columns.Add("Medo", typeof(double));
                stats.Columns.Add("Alegria", typeof(double));
                stats.Columns.Add("Tristeza", typeof(double));
                stats.Columns.Add("Surpresa", typeof(double));
                stats.Columns.Add("Confiança", typeof(double));


                for (int i = 0; i < wordSize.Count; i++)
                {
                    stats.Rows.Add(words[i], tempoEscrita[i], wordSize[i], errosTexto[i], (double)list_Emotions[i].getPositive(),
                       (double)list_Emotions[i].getNegative(), (double)list_Emotions[i].getAnger(), (double)list_Emotions[i].getAnticipation(),
                       (double)list_Emotions[i].getDisgust(), (double)list_Emotions[i].getFear(), (double)list_Emotions[i].getJoy(),
                       (double)list_Emotions[i].getSadness(), (double)list_Emotions[i].getSurprise(), (double)list_Emotions[i].getTrust());
                }

                data_All_Words.DataSource = stats;

                corrs = new DataTable();
                corrs.Columns.Add("Correlações", typeof(string));
                corrs.Columns.Add("Tempo de Escrita", typeof(double));
                corrs.Columns.Add("Tamanho Palavra", typeof(double));
                corrs.Columns.Add("Uso de Delete", typeof(double));
                corrs.Columns.Add("Positivo", typeof(double));
                corrs.Columns.Add("Negativo", typeof(double));
                corrs.Columns.Add("Raiva", typeof(double));
                corrs.Columns.Add("Antecipação", typeof(double));
                corrs.Columns.Add("Nojo", typeof(double));
                corrs.Columns.Add("Medo", typeof(double));
                corrs.Columns.Add("Alegria", typeof(double));
                corrs.Columns.Add("Tristeza", typeof(double));
                corrs.Columns.Add("Surpresa", typeof(double));
                corrs.Columns.Add("Confiança", typeof(double));

                List<string> rowHeaders = corrs.Columns.Cast<DataColumn>().Select(x => x.ColumnName).Where(x => x != "Correlations").ToList();
                List<double> tempoCor = new List<double>();
                List<double> wordSizeCor = new List<double>();
                List<double> backspaceCor = new List<double>();
                List<double> positiveCor = new List<double>();
                List<double> negativeCor = new List<double>();
                List<double> angerCor = new List<double>();
                List<double> anticipationCor = new List<double>();
                List<double> disgustCor = new List<double>();
                List<double> fearCor = new List<double>();
                List<double> joyCor = new List<double>();
                List<double> sadnessCor = new List<double>();
                List<double> surpriseCor = new List<double>();
                List<double> trustCor = new List<double>();

                for (int i = 1; i < stats.Columns.Count; i++)
                {
                    tempoCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[1]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    wordSizeCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[2]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    backspaceCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[3]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    positiveCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[4]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    negativeCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[5]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    angerCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[6]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    anticipationCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[7]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    disgustCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[8]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    fearCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[9]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    joyCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[10]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    sadnessCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[11]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    surpriseCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[12]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                    trustCor.Add(Correlation.Pearson((from DataRow row in stats.Rows select (double)row[13]).ToList(),
                        (from DataRow row in stats.Rows select (double)row[i]).ToList()));
                }

                for (int i = 0; i < corrs.Columns.Count - 1; i++)
                {
                    corrs.Rows.Add(rowHeaders[i], tempoCor[i], wordSizeCor[i], backspaceCor[i], positiveCor[i], negativeCor[i], angerCor[i],
                    anticipationCor[i], disgustCor[i], fearCor[i], joyCor[i], sadnessCor[i], surpriseCor[i], trustCor[i]);

                }
                dataCorrelations.DataSource = corrs;
            }
        }

        private void comboClearStops_SelectedIndexChanged(object sender, EventArgs e)
        {
                Stopwords.ClearSelected();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwords.ClearSelected();
           
        }

    }
}
        



