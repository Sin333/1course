using PhoneApp2.Resources;

namespace PhoneApp2
{
    /// <summary>
    /// Предоставляет доступ к строковым ресурсам.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}