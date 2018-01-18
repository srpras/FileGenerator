using FileGenerator.Validators;
using System.Collections.Generic;

namespace FileGenerator.Fields
{
    public abstract class FieldDefinition : IValidatableField
    {
        private ICollection<IValidator> _validators;

        public string Name { get; set; }

        public ICollection<IValidator> Validators {
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
