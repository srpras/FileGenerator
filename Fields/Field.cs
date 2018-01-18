using FileGenerator.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGenerator.Fields
{
    public class Field : IValidatableField
    {
        private ICollection<IValidator> _validators;

        public FieldDefinition Definition { get; set; }

        public string Value { get; set; }

        public ICollection<IValidator> Validators
        {
            get
            {
                return _validators;
            }
        }

        public void AddValidator(IValidator validator)
        {
            if (_validators == null)
                _validators = new List<IValidator>();

            _validators.Add(validator);
        }
    }
}
