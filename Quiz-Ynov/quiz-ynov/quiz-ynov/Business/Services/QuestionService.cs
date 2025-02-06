using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using quiz_ynov.Business.Models;
using quiz_ynov.Controllers.Dtos;

namespace quiz_ynov.Business.Services
{
    public class QuestionService: IQuestionService
    {
        private List<Question> _questionList = new List<Question>
    {
        new Question
        {
            Id = new Guid("1f6dcd89-6e5b-4cfb-9c1a-f5e7b78a9dcd"),
            Content = "What is ASP.NET Core?",
            Quiz = new Quiz{Id= new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa")},
            Choices = new List<string> { "Framework", "Programming Language", "IDE" },
            CorrectAnswer = "Framework"
        },
        
            new Question
{
    Id = new Guid("2e4dcf93-1e5a-4acb-8c7a-3b7f9a3b8cdd"),
    Content = "What is the primary language used in ASP.NET Core?",
    Quiz = new Quiz { Id = new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa") },
    Choices = new List<string> { "C#", "Python", "JavaScript" },
    CorrectAnswer = "C#"
},
new Question
{
    Id = new Guid("3f9acd71-2d4b-4eef-9c7d-1a2b7f3b8cfe"),
    Content = "Which middleware is used for handling routing in ASP.NET Core?",
    Quiz = new Quiz { Id = new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa") },
    Choices = new List<string> { "Routing Middleware", "Authentication Middleware", "Session Middleware" },
    CorrectAnswer = "Routing Middleware"
},

    // Programming Basics
    new Question
        {
            Id = new Guid("2d5cfba9-9c2a-4b5e-8e7a-cd9b678e5fcd"),
            Content = "What is the syntax for declaring a variable in C#?",
            Quiz = new Quiz{Id= new Guid("b2b345e3-f12c-4e68-8b78-a6d84e7074c9")},
            Choices = new List<string> { "let x = 10;", "int x = 10;", "var x: int = 10;" },
            CorrectAnswer = "int x = 10;"
        },
 new Question
    {
        Id = new Guid("4f6d89ba-9e1f-4ab7-8d13-eab60fa2d1b9"),
        Content = "Which of the following is used to define a method in C#?",
        Quiz = new Quiz { Id = new Guid("92b8e6e4-48d5-4781-a7e1-29b84942f3e5") },
        Choices = new List<string> { "def", "function", "void" },
        CorrectAnswer = "void"
    },
    new Question
    {
        Id = new Guid("78baf5f2-e1b7-4f89-8bba-3f59f63d57fc"),
        Content = "Which type is used to store a true or false value in C#?",
        Quiz = new Quiz { Id = new Guid("92b8e6e4-48d5-4781-a7e1-29b84942f3e5") },
        Choices = new List<string> { "bool", "int", "string" },
        CorrectAnswer = "bool"
    },
     // Questions pour Artificial Intelligence
    new Question
    {
        Id = new Guid("5d7b8b7f-c4f3-42ad-8d8c-9f2858d5a345"),
        Content = "What is the primary technique used in Machine Learning?",
        Quiz = new Quiz { Id = new Guid("e5f6b2d7-a4f7-4bb9-bd6c-63f9f5f73ac9") },
        Choices = new List<string> { "Neural Networks", "Genetic Algorithms", "Linear Regression" },
        CorrectAnswer = "Neural Networks"
    },
    new Question
    {
        Id = new Guid("1b6a7641-b8cd-48b4-bc3b-e63dcdcd9ac1"),
        Content = "Which Python library is commonly used for Machine Learning?",
        Quiz = new Quiz { Id = new Guid("e5f6b2d7-a4f7-4bb9-bd6c-63f9f5f73ac9") },
        Choices = new List<string> { "Django", "TensorFlow", "Flask" },
        CorrectAnswer = "TensorFlow"
    },
    new Question
    {
        Id = new Guid("9c0baef0-4f56-4669-bf87-c3b99d08c1b3"),
        Content = "What is the concept of supervised learning?",
        Quiz = new Quiz { Id = new Guid("c1f3b2d1-d8e2-4d1b-b7e5-6a3a7f6f2f3b") },
        Choices = new List<string> { "Training data with labels", "Clustering data", "Reinforcement learning" },
        CorrectAnswer = "Training data with labels"
    },

    // Questions pour Mobile Development (Android & iOS)
    new Question
    {
        Id = new Guid("7b9d8a8f-93da-4b8f-9536-71bb9d69f8f2"),
        Content = "Which language is primarily used for Android development?",
        Quiz = new Quiz { Id = new Guid("e9d5a7c9-7a2f-4e7d-8f19-18f0e9c0f5a7") },
        Choices = new List<string> { "Kotlin", "Swift", "Objective-C" },
        CorrectAnswer = "Kotlin"
    },
    new Question
    {
        Id = new Guid("3bbddcdc-bf65-47f4-9c3e-02c9299c6e2a"),
        Content = "Which IDE is primarily used for Android app development?",
        Quiz = new Quiz { Id = new Guid("e9d5a7c9-7a2f-4e7d-8f19-18f0e9c0f5a7") },
        Choices = new List<string> { "Visual Studio", "Xcode", "Android Studio" },
        CorrectAnswer = "Android Studio"
    },
    new Question
    {
        Id = new Guid("2e1f9e65-9f5d-49ab-8b61-d20f58e6c32c"),
        Content = "What is used to design the user interface in iOS?",
        Quiz = new Quiz { Id = new Guid("f1d9b6e7-d1e3-44e4-9345-1b4f5e3a5b3d") },
        Choices = new List<string> { "Android Studio", "Xcode", "JetBrains" },
        CorrectAnswer = "Xcode"
    }

    };

        public IEnumerable<Question> GetAll()
        {
            return _questionList;
        }

        public Question GetById(Guid id)
        {
            return _questionList.FirstOrDefault(question => question.Id == id);
        }





        public int ScoreCalcul(List<ResponseDto> userResponses)
        {
            int score = 0;

            // Parcourir chaque réponse de l'utilisateur
            for (int i = 0; i < userResponses.Count; i++)
            {
                // Récupérer la réponse de l'utilisateur
                var userResponse = userResponses[i];

                // Parcourir la liste des questions
                for (int j = 0; j < _questionList.Count; j++)
                {
                    // Comparer l'ID de la question avec celui de la réponse
                    if (_questionList[j].Id.ToString() == userResponse.QuestionId)
                    {
                        // Si l'ID correspond, comparer les réponses
                        if (_questionList[j].CorrectAnswer == userResponse.Response)
                        {
                            score++; // Incrémenter le score si la réponse est correcte
                        }
                        break; // Sortir de la boucle interne une fois la question trouvée
                    }
                }
            }

            return score;
        }


    }
}
