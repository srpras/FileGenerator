using FileGenerator.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGenerator.Formats
{
    public abstract class Format
    {
        public abstract string Name { get; }

        public abstract ICollection<FieldDefinition> GetAllFields();

        public abstract ICollection<FieldDefinition> GetApplicableFields(IList<string> names);

        public virtual FieldDefinition GetFieldByName(string name)
        {
            var fields = GetAllFields();

            return fields.First(i => i.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
