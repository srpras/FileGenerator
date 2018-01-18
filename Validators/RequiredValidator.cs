namespace FileGenerator.Validators
{
    public class RequiredValidator : IValidator
    {
        public bool Validate(string data)
        {
            return !string.IsNullOrEmpty(data);
        }
    }
}
