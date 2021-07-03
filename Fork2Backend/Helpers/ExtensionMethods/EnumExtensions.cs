using Fork2Backend.Managers;
using Fork2Model.Enums;

namespace Fork2Backend.Helpers.ExtensionMethods
{
    public static class EnumExtensions
    {
        public static string Localize(this ErrorMessage errorMessage)
        {
            return LocalizationManager.Instance.Localization.Localize(LocalizationManager.Instance.Language, errorMessage);
        }
    }
}