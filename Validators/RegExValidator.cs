using System.Text.RegularExpressions;

namespace FileGenerator.Validators
{
    public class RegExValidator : IValidator
    {
        private string _regEx;
        private int _minLength;
        private int _maxLength;

        public RegExValidator(string regEx) : this(regEx, 0, int.MaxValue)
        {
           
        }

        public RegExValidator(string regEx, int minLength, int maxLength)
        {
            _regEx = regEx;
            _minLength = minLength;
            _maxLength = maxLength;
        }

        public bool Validate(string data)
        {
            return 
                data.Length >= _minLength &&
                data.Length <= _maxLength &&
                Regex.IsMatch(data, _regEx, RegexOptions.CultureInvariant);
        }
    }
}
