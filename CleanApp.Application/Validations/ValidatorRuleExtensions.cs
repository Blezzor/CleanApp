using FluentValidation;

namespace CleanApp.Application.Validations
{
    public static class ValidatorRuleExtensions
    {
        public static IRuleBuilderOptions<T, string> OnlyLetters<T>(this IRuleBuilder<T, string> rule)
        {
            return rule.Matches(@"^[a-zA-Z]*$").WithMessage("Only letters allowed (a-z, A-Z)");
        }
        public static IRuleBuilderOptions<T, string> OnlyDigits<T>(this IRuleBuilder<T, string> rule)
        {
            return rule.Matches(@"^[0-9]*$").WithMessage("Only digits allowed");
        }
    }
}
