namespace quiz_ynov.Business.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // relation one to many avec Quiz (Une catégorie peut contenir plusieurs quiz ) 
        public IEnumerable<Quiz> Quizs { get; set; }


    }
}
