using System;
using TPAPI.Data;


namespace TPAPI.Logic
{
    public class JokeLogic
    {
        JokeApi jokeApi = new JokeApi();

        public string GetJoke()
        {
            try
            {
                return jokeApi.GetJoke();
            }
            catch(Exception ex)
            {
                throw ex;
            }      
        }
 
    }
}
