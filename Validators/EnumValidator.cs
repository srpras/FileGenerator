using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FileGenerator.Validators
{
    public class EnumValidator : IValidator
    {
        private ICollection<string> _list;
        private bool _ignoreCase;

        public EnumValidator(ICollection<string> list) : this(list, true)
        {

        }

        public EnumValidator(ICollection<string> list, bool ignoreCase)
        {
            _list = list;
            _ignoreCase = ignoreCase;
        }

        public bool Validate(string data)
        {
            return _list.Contains(data, StringComparer.Create(CultureInfo.InvariantCulture, _ignoreCase));
        }
    }
}
