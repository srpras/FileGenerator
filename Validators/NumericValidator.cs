using System;

namespace FileGenerator.Validators
{
    public class NumericValidator : IValidator
    {
        private decimal? _minValue;
        private decimal? _maxValue;

        public NumericValidator()
        {

        }

        public NumericValidator(decimal minValue, decimal maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public bool Validate(string data)
        {
            decimal value;

            return decimal.TryParse(data, out value) &&
                (_minValue == null || _minValue <= value) &&
                (_maxValue == null || _maxValue >= value);
        }
    }
}
