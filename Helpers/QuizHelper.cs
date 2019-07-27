using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Quiz_App.DataModels;

namespace Quiz_App.Helpers
{
    public class QuizHelper
    {

        List<Question> History;
        List<Question> Geography;
        List<Question> Space;
        List<Question> Programming;
        List<Question> Engineering;
        List<Question> Business;

       public string GetTopicDescription(string topic)
        {
            string topicDescription = "";
            if(topic == "History")
            {
                topicDescription = "History is the study of the past as it is described in written documents. Events occurring before written record are considered prehistory. It is an umbrella term that relates to past events as well as the memory, discovery, collection, organization, presentation, and interpretation of information about these events.";
            }
            else if(topic == "Space")
            {
                topicDescription = "The concept of space is considered to be of fundamental importance to an understanding of the physical universe. However, disagreement continues between philosophers over whether it is itself an entity, a relationship between entities, or part of a conceptual framework.";
            }
            else if(topic == "Geography")
            {
                topicDescription = "Geography is the study of places and the relationships between people and their environments. Geographers explore both the physical properties of Earth's surface and the human societies spread across it.";
            }

            return topicDescription;
        }

        public List<Question> GetQuizQuestions( string topic)
        {
            List<Question> quizList = new List<Question>();

            if(topic == "History")
            {
                InitializeHistory();
                quizList = History;
            }
            else if(topic == "Space")
            {
                InitializeSpace();
                quizList = Space;
            }
            else if (topic == "Geography")
            {
                InitializeGeography();
                quizList = Geography;
            }


            return quizList;
        }

        void InitializeHistory()
        {
            History = new List<Question>();
            History.Add(new Question { QuizQuestion = "During which decade was slavery abolished in the United States?", Answer = "1860s", OptionA = "1860s", OptionB = "1840s", OptionC = "1850s", OptionD = "1870" });
            History.Add(new Question { QuizQuestion = "During which year did Christopher Columbus first arrive in the Americas?", Answer = "1495", OptionA = "1495", OptionB = "1492", OptionC = "1498", OptionD = "1501" });
            History.Add(new Question { QuizQuestion = "Which year was the first edition of FIFA World Cup played", Answer = "1930", OptionA = "1985", OptionB = "1920", OptionC = "1930", OptionD = "2002" });
            History.Add(new Question { QuizQuestion = "World War II also known as the Second World War, was a global war that lasted from 1939 to ?", Answer = "1945", OptionA = "1986", OptionB = "1922", OptionC = "1945", OptionD = "1939" });
            History.Add(new Question { QuizQuestion = "The assassination of Julius Caesar was the result of a conspiracy by many Roman senators, he was stabbed by?", Answer = "Junius Brutus", OptionA = "Uchenna Nnodim", OptionB = "Cassius Longinus", OptionC = "Junius Brutus", OptionD = "Orsa Kemi" });
        }

        void InitializeGeography()
        {
            Geography = new List<Question>();
            Geography.Add(new Question { QuizQuestion = "What is the largest country in the world (by Area)?", Answer = "Russia", OptionA = "Russia", OptionB = "Canada", OptionC = "United Sates", OptionD = "China" });
            Geography.Add(new Question { QuizQuestion = "Which of the following countries does NOT have a population exceeding 200 million?", Answer = "Nigeria", OptionA = "Brazil", OptionB = "Indonesia", OptionC = "Pakistan", OptionD = "Nigeria" });
            Geography.Add(new Question { QuizQuestion = "Muscat is the capital of which country?", Answer = "Oman", OptionA = "Oman", OptionB = "Jordan", OptionC = "Yemen", OptionD = "Bahrain" });
            Geography.Add(new Question { QuizQuestion = "Which is the world's smallest continent (by area)?", Answer = "Oceania", OptionA = "Oceania", OptionB = "Antractica", OptionC = "South America", OptionD = "Europe" });
            Geography.Add(new Question { QuizQuestion = "Which of the following countries is NOT a member state of the European Union?", Answer = "Norway", OptionA = "Finland", OptionB = "Sweden", OptionC = "Norway", OptionD = "Denmark" });

        }

        void InitializeSpace()
        {
            Space = new List<Question>();
            Space.Add(new Question { QuizQuestion = "Who was the first man to ever walk on the Moon?", Answer = "Niel Armstrong", OptionA = "Uchenna Nnodim", OptionB = "Niel Armstrong", OptionC = "Benjamin Franklin", OptionD = "Pele Pele" });
            Space.Add(new Question { QuizQuestion = "The coldest and farthest Planet from the Sun is ?", Answer = "Pluto", OptionA = "Earth", OptionB = "Pluto", OptionC = "Neptune", OptionD = "Saturn" });
            Space.Add(new Question { QuizQuestion = "The galaxy that contains Solar System which Earth belongs to is called what?", Answer = "Milky Way", OptionA = "Chocolate Path", OptionB = "Phantom Zone", OptionC = "Milky Way", OptionD = "Solar Container" });
            Space.Add(new Question { QuizQuestion = "How many days does it take the Earth to complete her orbit", Answer = "365 Days", OptionA = "365 Days", OptionB = "30 Days", OptionC = "272 Days", OptionD = "None of the Above" });
            Space.Add(new Question { QuizQuestion = "An explosion which leads to gigantic explosion throwing star's outer layers are thrown out is called", Answer = "Supernova", OptionA = "Black hole", OptionB = "Double ring", OptionC = "Massive Explosion", OptionD = "Supernova" });

        }
    }
}