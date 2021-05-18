using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TROPHYParser
{
    class InvalidTrophyFileException : Exception
    {
        private string fileName;
        public string FileName
        {
            get { return fileName; }
        }

        public InvalidTrophyFileException(string message, string fileName) : base(message)
        {
            this.fileName = fileName;
        }
        public InvalidTrophyFileException(string fileName) : base(string.Format("Not a valid {0}.", fileName)) { }
    }
}
