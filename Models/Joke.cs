namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {
             
        }

        public Joke(string JokeQuestion,string JokeAnswer)
        {
            this.JokeQuestion = JokeQuestion;
            this.JokeAnswer = JokeAnswer;
        }

    }
}
