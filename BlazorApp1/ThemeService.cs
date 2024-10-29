namespace BlazorApp1 // Replace with the actual namespace of your project
{
    public class ThemeService
    {
        public string CurrentTheme { get; private set; } = "blazorstrap.min.css";

        public void SetTheme(string theme)
        {
            CurrentTheme = theme;
        }
    }
}
