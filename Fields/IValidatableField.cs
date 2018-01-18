using FileGenerator.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGenerator.Fields
{
    public interface IValidatableField
    {
        ICollection<IValidator> Validators { get; }

        void AddValidator(IValidator validator);
    }
}
