using quiz_ynov.Business.Models;

namespace quiz_ynov.Business.Services
{
    public class QuizService: IQuizService

    {
        private List<Quiz> _quizList = new List<Quiz> {
    // Web Development
    new Quiz
    {
        Id = new Guid("ae9fcd19-9da1-4cbb-8e16-e9af9fd2f3aa"),
        Category = new Category { Id = new Guid("7ea81c2e-458f-4def-9c6e-eee6365677bd") },
        Description = "ASP .NET Core",
        Difficulty = 3,
        DateCreation = new DateTime(2023, 11, 26, 14, 30, 0),
        Name = "dev"
    },
    new Quiz
    {
        Id = new Guid("f72d3207-d748-4fd4-909d-36f50f848fc3"),
        Category = new Category { Id = new Guid("7ea81c2e-458f-4def-9c6e-eee6365677bd") },
        Description = "Advanced C# Concepts",
        Difficulty = 4,
        DateCreation = new DateTime(2023, 12, 10, 10, 15, 0),
        Name = "csharp-advanced"
    },
    new Quiz
    {
        Id = new Guid("c9b5b9b9-b91f-4bc9-9b9f-7a876ff55a5f"),
        Category = new Category { Id = new Guid("7ea81c2e-458f-4def-9c6e-eee6365677bd") },
        Description = "Introduction to Python",
        Difficulty = 2,
        DateCreation = new DateTime(2023, 11, 20, 11, 45, 0),
        Name = "intro-python"
    },
    
    // Programming Basics
    new Quiz
    {
        Id = new Guid("b2b345e3-f12c-4e68-8b78-a6d84e7074c9"),
        Category = new Category { Id = new Guid("a1d2e4f6-789a-4bcd-b9c1-f8d2355678de") },
        Description = "C# Basics",
        Difficulty = 2,
        DateCreation = new DateTime(2023, 11, 26, 15, 00, 0),
        Name = "intro"
    },
    new Quiz
    {
        Id = new Guid("92b8e6e4-48d5-4781-a7e1-29b84942f3e5"),
        Category = new Category { Id = new Guid("a1d2e4f6-789a-4bcd-b9c1-f8d2355678de") },
        Description = "Web Development with JavaScript",
        Difficulty = 3,
        DateCreation = new DateTime(2023, 12, 15, 16, 00, 0),
        Name = "js-web-dev"
    },

   // Artificial Intelligence
new Quiz
{
    Id = new Guid("e5f6b2d7-a4f7-4bb9-bd6c-63f9f5f73ac9"), // GUID spécifique
    Category = new Category { Id = new Guid("3f7b0f65-5e6d-4bb1-8a97-7c4c8f220e7f") }, // AI Category ID
    Description = "Introduction to Machine Learning",
    Difficulty = 3,
    DateCreation = DateTime.Now,
    Name = "ml-intro"
},
new Quiz
{
    Id = new Guid("c1f3b2d1-d8e2-4d1b-b7e5-6a3a7f6f2f3b"), // GUID spécifique
    Category = new Category { Id = new Guid("3f7b0f65-5e6d-4bb1-8a97-7c4c8f220e7f") }, // AI Category ID
    Description = "Neural Networks Basics",
    Difficulty = 4,
    DateCreation = DateTime.Now,
    Name = "nn-basics"
},

// Mobile Development
new Quiz
{
    Id = new Guid("e9d5a7c9-7a2f-4e7d-8f19-18f0e9c0f5a7"), // GUID spécifique
    Category = new Category { Id = new Guid("b2f3c4d5-67e8-4a9b-b0c2-d1e2345678ef") }, // Mobile Development Category ID
    Description = "Android Development Fundamentals",
    Difficulty = 2,
    DateCreation = DateTime.Now,
    Name = "android-fundamentals"
},
new Quiz
{
    Id = new Guid("f1d9b6e7-d1e3-44e4-9345-1b4f5e3a5b3d"), // GUID spécifique
    Category = new Category { Id = new Guid("b2f3c4d5-67e8-4a9b-b0c2-d1e2345678ef") }, // Mobile Development Category ID
    Description = "iOS App Development",
    Difficulty = 3,
    DateCreation = DateTime.Now,
    Name = "ios-development"
}

};


        public IEnumerable<Quiz> GetAll()
        {
            return _quizList;
        }

        public Quiz GetById(Guid id)
        {
            return _quizList.FirstOrDefault(quiz => quiz.Id == id) ; 
        }

   

        public int ScroreCalcul(Quiz quiz)
        {
            // Initialiser le résultat à 0
            int resultat = 0;

            // Parcourir toutes les questions du quiz
            foreach (var question in quiz.Questions)
            {
                // Parcourir toutes les réponses possibles de la question
                foreach (var choice in question.Choices)
                {
                    // Vérifier si la réponse est correcte
                    if (choice == question.CorrectAnswer)
                    {
                        resultat++;
                    }
                }
            }

            // Retourner le résultat final
            return resultat;
        }
    }
}
