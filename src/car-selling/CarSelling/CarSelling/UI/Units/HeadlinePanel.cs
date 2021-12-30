using System.Windows;
using System.Windows.Controls;

namespace CarSelling.UI.Units
{
    public class HeadlinePanel : ContentControl
    {
        static HeadlinePanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HeadlinePanel), new FrameworkPropertyMetadata(typeof(HeadlinePanel)));
        }
    }
}
