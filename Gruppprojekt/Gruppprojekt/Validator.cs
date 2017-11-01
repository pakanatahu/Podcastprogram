using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class Validator
    {

        public void validateName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Name cant be empty");
            if (input.Length > 30)
                throw new ArgumentException("Name cannot be longer than 30 characters");
            if (input.Any(c => char.IsDigit(c)))
                throw new ArgumentException("Name cannot contain numbers");
        }

  
        public void validateCategory(String input, List<Category> list)
        {
            validateName(input);
            
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Name.Equals(input))
                {
                    throw new ArgumentException("A category with that name already exists");
                }
            }
        }

        public void validateInterval(String input)
        {
            if (String.IsNullOrWhiteSpace(input))
                throw new ArgumentException("You must asign an intervall in format HH:MM");

            bool isInt = Int32.TryParse(input, out var output);
            if (!isInt)
            {
                throw new ArgumentException("Interval is not a number");
            }
            else if (output > 99)
            {
                throw new ArgumentException("Max interval is 99");
            }

        }

        public Boolean hasValue(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return false;
            else
                return true;
        }

        public void validateUrl(string url_input)
        {
            if (String.IsNullOrWhiteSpace(url_input))
                throw new ArgumentException("Url cant be empty");

            bool isUri = Uri.IsWellFormedUriString(url_input, UriKind.RelativeOrAbsolute);
            if (!isUri)
            {
                throw new ArgumentException("URL not valid");
            }
            if (!url_input.EndsWith("xml"))
            {
                throw new ArgumentException("The url does not contain an xml link");
            }
        }
    }
}
