using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWPF_Test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionNumbers = Enumerable.Range(1, 10).ToList();
        int qNumber, score, i;
        public MainWindow()
        {
            InitializeComponent();

            StartQuiz();
            NextQuestion();
        }

        private void NextQuestion()
        {
            if (qNumber < questionNumbers.Count)
            {
                i = questionNumbers[qNumber];
            }
            else
            {
                RestartGame();
            }
            foreach (var item in myCanvas.Children.OfType<Button>())
            {
                item.Tag = "0";
            }
            switch (i)
            {
                case 1: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 2: 
                    QuestionsText.Text = "В каком году Гагарин полетел в космос?";
                    btnAnswer1.Content = "1957";
                    btnAnswer2.Content = "1961";
                    btnAnswer3.Content = "1963";
                    btnAnswer4.Content = "1812";

                    btnAnswer2.Tag = "1";
                    break;
                case 3: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 4: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 5: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 6: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 7: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 8: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 9: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                case 10: 
                    QuestionsText.Text = "Самое глубокое озеро мира(название) ?";
                    btnAnswer1.Content = "Байкал";
                    btnAnswer2.Content = "Индийское море";
                    btnAnswer3.Content = "Гидигич";
                    btnAnswer4.Content = "Вадул-луй-Водэ";

                    btnAnswer1.Tag = "1";
                    break;
                default:
                    break;
            }
        }

        private void RestartGame()
        {
            score = 0;
            qNumber--;
            i = 0;
            StartQuiz();
        }

        private void StartQuiz()
        {
            var randomList = questionNumbers.OrderBy(x => Guid.NewGuid()).ToList(); // guid.newGuid мешает рандомно вопросы
            questionNumbers = randomList;
            lQuestions.Content = null;
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                lQuestions.Content += " " + questionNumbers[i].ToString();
            }
        }
        private void CheckAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNumber < 0)
            {
                qNumber = 0;
            }
            else
            {
                qNumber++;
            }
            lPoints.Content = "Answerly correctly!" + score + "/" + questionNumbers.Count;
            NextQuestion();
        }
    }
}
