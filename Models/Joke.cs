namespace JokesWebApp.Models
{
    public class Joke
    {
        /// <summary>
        /// The ID of a joke
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The question of the joke
        /// </summary>
        public string JokeQuestion { get; set; }

        /// <summary>
        /// The answer to a specific joke
        /// </summary>
        public string JokeAnswer { get; set; }

        public Joke()
        {

        }


    }
}
