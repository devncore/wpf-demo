using System.Windows;

namespace CarSelling.UI.Units
{
    public class NextButton : IconButton
    {
        static NextButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NextButton), new FrameworkPropertyMetadata(typeof(NextButton)));
        }
    }
}
