namespace quiz_ynov.Business.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // relation many to one avec Category (Un quiz appartient à une catégorie )
        public Category Category { get; set; }
        public Byte Difficulty { get; set; }
        public DateTime DateCreation { get; set; }

        // relation one to many avec Questions (Un quiz contient plusieurs questions) 
        public IEnumerable<Question> Questions { get; set; } 

}
}
