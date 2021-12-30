using System.Windows;
using System.Windows.Controls;

namespace CarSelling.UI.Units
{
    public class SpecificationItem : ListBoxItem
    {
        static SpecificationItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpecificationItem), new FrameworkPropertyMetadata(typeof(SpecificationItem)));
        }
    }
}
