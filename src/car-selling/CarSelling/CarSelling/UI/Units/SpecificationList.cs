using System.Windows;
using System.Windows.Controls;

namespace CarSelling.UI.Units
{
    public class SpecificationList : ListBox
    {
        static SpecificationList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpecificationList), new FrameworkPropertyMetadata(typeof(SpecificationList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new SpecificationItem();
        }
    }
}
