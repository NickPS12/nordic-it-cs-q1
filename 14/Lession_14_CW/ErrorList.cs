using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lession_14_CW
{
    class ErrorList : IDisposable, IEnumerable<string>
    {
        public static string OutputPrefixFormat { get; set; }

        public string Category { get; }

        private List<string> _errors;

        static ErrorList() 
        { 

        }

        public ErrorList(string category)
        {
            Category = category;
            _errors = new List<string>();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _errors.GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(string errorMessage)
        {
            _errors.Add(errorMessage);
        }

        public void Dispose() //метод который почистит сам всё
        {
            _errors?.Clear();
            _errors = null;
        }

        public void WriteToConsole()
        {
            foreach (string error in _errors)
            {
                Console.WriteLine(DateTimeOffset.Now.ToString() + " " + Category + ": " + error);
            }
        }
    }
}
