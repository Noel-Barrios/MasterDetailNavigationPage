using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetailNavigationPage.MenuItems;
using MasterDetailNavigationPage.Views;
using Xamarin.Forms;

namespace MasterDetailNavigationPage 
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterPageItem> menuList { get; set; }


        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "FastDelivery", Icon = "schedule.png", TargetType = typeof(View1) };
            var page2 = new MasterPageItem() { Title = "Menus", Icon = "settings.png", TargetType = typeof(View2) };
            var page3 = new MasterPageItem() { Title = "Free Pizza", Icon = "today.png", TargetType = typeof(View3) };
            var page4 = new MasterPageItem() { Title = "Dining", Icon = "schedule.png", TargetType = typeof(View4) };
            var page5 = new MasterPageItem() { Title = "Parking", Icon = "settings.png", TargetType = typeof(View1) };
            var page6 = new MasterPageItem() { Title = "LocateUs", Icon = "today.png", TargetType = typeof(View2) };

            // add menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);

            // set the list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // initial navigation, which can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ViewMain)));

            this.BindingContext = new
            {
                Header = "",
                Image = "settings.png",
                Footer = "Welcome to Hotel Plaza"
            };
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }


    }
}
