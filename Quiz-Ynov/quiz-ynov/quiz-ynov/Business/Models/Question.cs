namespace quiz_ynov.Business.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Content { get; set; }

        // relation many to one avec Quiz (Une question appartient à un quiz  )
        public Quiz Quiz { get; set; }
        public IEnumerable<string> Choices { get; set; }
        public string CorrectAnswer { get; set; }

    }
}
