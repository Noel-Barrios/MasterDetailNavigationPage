using System;
namespace MasterDetailNavigationPage.MenuItems
{
    public class MasterPageItem
    {
        public string Title { get; set; }
        public string Icon { get; set; }

        // The TargetType will be used to hold information about pages that we want to open.
        public Type TargetType { get; set; }
    }
}
