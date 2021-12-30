using System.Windows;
using System.Windows.Controls;

namespace CarSelling.UI.Units
{
    public class PreviewButton : IconButton
    {
        static PreviewButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PreviewButton), new FrameworkPropertyMetadata(typeof(PreviewButton)));
        }
    }
}
