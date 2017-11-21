using System;

namespace CustomExceptions
{
    public class ModelOutOfSyncException : Exception
    {
        public ModelOutOfSyncException(string message) 
            : base("Your local values were out of sync with the database.")
        {

        }
    }
}