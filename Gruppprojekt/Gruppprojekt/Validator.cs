using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class Validator
    {
        public bool hasValue(String input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void validateName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Name must have a value");
            if (input.Length > 30)
                throw new ArgumentException("Name cannot be longer than 30 characters");
            if (input.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Name cannot contain numbers");
            }

        }

        public static void validateUrl(string url_input)
        {
            bool isUri = Uri.IsWellFormedUriString(url_input, UriKind.RelativeOrAbsolute);

            if (!isUri)
            {
                throw new Exception("URL not valid");
            }
            if (!url_input.EndsWith("xml"))
            {
                throw new Exception("The url does not contain an xml link");
            }
        }

        public void validateCategoryName(String name, List<Category> categoryList)
        {
            for (int i = 0; i < categoryList.Count; i++)
            {
                 if (name == categoryList[i].ToString())
                {
                    throw new Exception(name + " already exists as a category");
                }
            }
        }
    }
}
