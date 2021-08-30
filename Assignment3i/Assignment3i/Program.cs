using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3i
{
    class IQTest
    {
        List<string> aptitude = new List<string>() {"The shape of the earth is `CIRCLE` ? ", "Diameter is twice the raduis of a `CIRCLE` ? ", "CHINA is the highest populated country in the world ? "};
        List<string> aptitudeAnswers = new List<string>(){"false", "true", "true"};

        List<string> english = new List<string>() { "`HE` is a pronoun ? ", "`WASHING` is an adverb ? ", "`MANGO` is a noun ?" };
        List<string> englishAnswers = new List<string>() { "true", "false", "true" };

        List<string> maths = new List<string>() { "`QUOTIENT` is the answer you get after division ? ", "`SUM` is the answer you get after multiplication` ? ", "`Modulus` is the answer you get after Subtraction? " };
        List<string> mathsAnswers = new List<string>() { "true", "false", "false" };

        List<string> gk = new List<string>() { "Does RED mean stop in trafic light ? ", "Humans are Carnivorios ? ", "Human's sense of `TASTE` is greater than that of dogs ? " };
        List<string> gkAnswers = new List<string>() { "true", "false", "true" };

        public List<Dictionary<string, string>> scores = new List<Dictionary<string, string>> (); 

        public void getQuestion(string name, int index)
        {
            switch (name.ToLower())
            {
                case "aptitude":
                    {
                        Console.Clear();
                        Console.WriteLine("{0}", aptitude[index]);
                        break;
                    }

                case "maths":
                    {
                        Console.Clear();
                        Console.WriteLine("{0}", maths[index]);
                        break;
                    }

                case "english":
                    {
                        Console.Clear();
                        Console.WriteLine("{0}", english[index]);
                        break;
                    }

                case "gk":
                    {
                        Console.Clear();
                        Console.WriteLine("{0}", gk[index]);
                        break;
                    }
                default:
                    break;
            }
        }

        public bool checkAnswer (string question, int index, string answer)
        {
            bool isCorrect = false;

            switch (question.ToLower())
            {
                case "aptitude":
                    {
                        if (aptitudeAnswers[index] == answer.ToLower())
                        {
                            isCorrect = true;
                        }
                        break;
                    }

                case "english":
                    {
                        if (englishAnswers[index] == answer.ToLower())
                        {
                            isCorrect = true;
                        }
                        break;
                    }

                case "maths":
                    {
                        if (mathsAnswers[index] == answer.ToLower())
                        {
                            isCorrect = true;
                        }
                        break;
                    }

                case "gk":
                    {
                        if (gkAnswers[index] == answer.ToLower())
                        {
                            isCorrect = true;
                        }
                        break;
                    }

                default:
                    break;
            }

            return isCorrect;
        }

        public bool checkIfExists(string name)
        {
            bool exists = false;

            foreach (var item in scores)
            {
                if(item["name"] == name)
                {
                    exists = true;
                }
            }

            return exists;
        }
        public void setScore(Dictionary<string, string> score)
        {
            scores.Add(score);
        }

        public List<Dictionary<string, string>> getScore()
        {
            return scores;
        }

        public double addBonus(double totalScore)
        {
            if (Math.Ceiling(totalScore) == 30)
            {
                totalScore += 10;
            }

            else if (Math.Ceiling(totalScore) == 20)
            {
                totalScore += 5;
            }
            
            else if (Math.Ceiling(totalScore) == 10)
            {
                totalScore += 2;
            }

            else
            {
                totalScore += 0;
            }

            return totalScore;
        }

        public string checkIQ (double totalScore)
        {
            string result;
            int computedScore = (int) Math.Ceiling(addBonus(totalScore));

            if(computedScore >= 40)
            {
                result = "You are a Genius";
            }
            else if(computedScore >= 30)
            {
                result = "You are Intelligent";
            }
            else if (computedScore >= 20)
            {
                result = "Your IQ is Average";
            }
            else if (computedScore >= 10)
            {
                result = "Your IQ is below Average";
            }
            else
            {
                result = "You need to re-appear the test";
            }

            return result;
        }
        
    }

    class Questions
    {
        static void Main(string[] args)
        {
            var IqTest = new IQTest();

            int choice;
            Console.WriteLine("Welcome To Salisbury University IQ TEST \n \n");

            Console.Write("No of attempts: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice > 1)
            {
                Console.Clear();
                Console.WriteLine("You have exceeded the number of attempts \n \n");
            }
            else
            {
                string usersChoice;
                int counter = 1;

                while(counter != 0)
                {
                    Console.Clear();
                    Console.WriteLine("Select a subject:: \n \n 1 => Aptitude \n 2 => English \n 3 => Mathematics \n 4 => General Knowledge \n 5 => Exit \n ");
                    Console.Write(" --> ");

                    usersChoice = Console.ReadLine();

                    switch (usersChoice)
                    {
                        case "1":
                            {
                                string question = "aptitude";

                                if (!IqTest.checkIfExists(question))
                                {
                                    double score = 0;
                                    int index = 0;
                                    int x = 1;

                                    while (x != 0)
                                    {
                                        if (index <= 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Question {0} \n ", index + 1);
                                            IqTest.getQuestion(question, index);

                                            Console.WriteLine(" \n 1 => True \n 2 => False");
                                            Console.Write("\n --> ");
                                            string selection = Console.ReadLine();
                                            string answer = "";

                                            switch (selection)
                                            {
                                                case "1":
                                                    answer = "True";
                                                    break;
                                                default:
                                                    answer = "False";
                                                    break;
                                            }

                                            if (IqTest.checkAnswer(question, index, answer))
                                            {
                                                score += 3.333;
                                            }
                                        }
                                        else
                                        {
                                            var scoreDic = new Dictionary<string, string> {
                                            { "name", question}, {"score", score.ToString() }
                                        };

                                            IqTest.setScore(scoreDic);

                                            Console.Clear();
                                            Console.WriteLine("{0} Test is Completed, Attempt other Subjects", question.ToUpper());
                                            Console.ReadLine();
                                            x = 0;
                                        }

                                        index++;

                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You've already answered this Subject");
                                    Console.ReadLine();
                                }
                                break;
                            }

                        case "2":
                            {
                                string question = "english";

                                if (!IqTest.checkIfExists(question))
                                {
                                    double score = 0;
                                    int index = 0;
                                    int x = 1;

                                    while (x != 0)
                                    {
                                        if (index <= 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Question {0} \n ", index + 1);
                                            IqTest.getQuestion(question, index);

                                            Console.WriteLine(" \n 1 => True \n 2 => False");
                                            Console.Write("\n --> ");
                                            string selection = Console.ReadLine();
                                            string answer = "";

                                            switch (selection)
                                            {
                                                case "1":
                                                    answer = "True";
                                                    break;
                                                default:
                                                    answer = "False";
                                                    break;
                                            }

                                            if (IqTest.checkAnswer(question, index, answer))
                                            {
                                                score += 3.333;
                                            }
                                        }
                                        else
                                        {
                                            var scoreDic = new Dictionary<string, string> {
                                            { "name", question}, {"score", score.ToString() }
                                        };

                                            IqTest.setScore(scoreDic);

                                            Console.Clear();
                                            Console.WriteLine("{0} Test is Completed, Attempt other Subjects", question.ToUpper());
                                            Console.ReadLine();
                                            x = 0;
                                        }

                                        index++;

                                    }

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You've already answered this Subject");
                                    Console.ReadLine();
                                }
                                break;
                            }

                        case "3":
                            {
                                string question = "maths";

                                if (!IqTest.checkIfExists(question))
                                {
                                    double score = 0;
                                    int index = 0;
                                    int x = 1;

                                    while (x != 0)
                                    {
                                        if (index <= 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Question {0} \n ", index + 1);
                                            IqTest.getQuestion(question, index);

                                            Console.WriteLine(" \n 1 => True \n 2 => False");
                                            Console.Write("\n --> ");
                                            string selection = Console.ReadLine();
                                            string answer = "";

                                            switch (selection)
                                            {
                                                case "1":
                                                    answer = "True";
                                                    break;
                                                default:
                                                    answer = "False";
                                                    break;
                                            }

                                            if (IqTest.checkAnswer(question, index, answer))
                                            {
                                                score += 3.333;
                                            }
                                        }
                                        else
                                        {
                                            var scoreDic = new Dictionary<string, string> {
                                            { "name", question}, {"score", score.ToString() }
                                        };

                                            IqTest.setScore(scoreDic);

                                            Console.Clear();
                                            Console.WriteLine("{0} Test is Completed, Attempt other Subjects", question.ToUpper());
                                            Console.ReadLine();
                                            x = 0;
                                        }

                                        index++;

                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You've already answered this Subject");
                                    Console.ReadLine();
                                }
                                break;
                            }

                        case "4":
                            {
                                string question = "gk";

                                if (!IqTest.checkIfExists(question))
                                {
                                    double score = 0;

                                    int index = 0;
                                    int x = 1;

                                    while (x != 0)
                                    {
                                        if (index <= 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Question {0} \n ", index + 1);
                                            IqTest.getQuestion(question, index);

                                            Console.WriteLine(" \n 1 => True \n 2 => False");
                                            Console.Write("\n --> ");
                                            string selection = Console.ReadLine();
                                            string answer = "";

                                            switch (selection)
                                            {
                                                case "1":
                                                    answer = "True";
                                                    break;
                                                default:
                                                    answer = "False";
                                                    break;
                                            }

                                            if (IqTest.checkAnswer(question, index, answer))
                                            {
                                                score += 3.333;
                                            }
                                        }
                                        else
                                        {
                                            var scoreDic = new Dictionary<string, string> {
                                            { "name", question}, {"score", score.ToString() }
                                        };

                                            IqTest.setScore(scoreDic);

                                            Console.Clear();
                                            Console.WriteLine("{0} Test is Completed, Attempt other Subjects", question.ToUpper());
                                            Console.ReadLine();
                                            x = 0;
                                        }

                                        index++;

                                    }

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You've already answered this Subject");
                                    Console.ReadLine();
                                }
                                break;
                            }

                        case "5":
                            {
                                string option;
                                Console.Clear();
                                Console.Write("Are you sure you want to leave the Test? \n \n  1 => yes \t 2 => no \n \n ==> ");

                                option = Console.ReadLine();

                                switch (option)
                                {
                                    case "1":
                                        {
                                            string iqResult;
                                            double totalScore = 0;
                                            var scoreArray = IqTest.getScore();

                                            foreach (var item in scoreArray)
                                            {
                                                totalScore += Convert.ToDouble(item["score"]);
                                            }

                                            iqResult = IqTest.checkIQ(totalScore);
                                            Console.Clear();
                                            Console.WriteLine("{0}", iqResult);
                                            Console.ReadLine();
                                            counter = 0;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                break;
                            }

                        default:
                            break;
                    }
                }
            }


        }
    }
}
