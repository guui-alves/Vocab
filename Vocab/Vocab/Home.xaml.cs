using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Vocab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : MasterDetailPage
    {
        
        public List<MasterPageItem> MenuList
        {
            get;
            set;
        }
        public Home()
        {
            InitializeComponent();
            
            MenuList = new List<MasterPageItem>();
            
            // Adding menu items to menuList and you can define title ,page and icon  
            MenuList.Add(new MasterPageItem()
            {
                Title = "Add",
                Icon = "add_icon.png",
                TargetType = typeof(Add)
            });
            MenuList.Add(new MasterPageItem()
            {
                Title = "Play",
                Icon = "play_icon.png",
                TargetType = typeof(Play)
            });
            
            MenuList.Add(new MasterPageItem()
            {
                Title = "Adjetivos",
                Icon = "adjetivo_icon.png",
                TargetType = typeof(Adjetivos)
            });
            MenuList.Add(new MasterPageItem()
            {
                Title = "Adverbios",
                Icon = "adverbio_icon.png",
                TargetType = typeof(Adverbios)
            });
            MenuList.Add(new MasterPageItem()
            {
                Title = "Substantivos",
                Icon = "substantivo_icon.png",
                TargetType = typeof(Substantivos)
            });
            MenuList.Add(new MasterPageItem()
            {
                Title = "Verbos",
                Icon = "verbo_icon.png",
                TargetType = typeof(Verbos)
            });
            
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = MenuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Background))){ BarBackgroundColor = Color.Tan };
            
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page)) { BarBackgroundColor = Color.Tan };

            IsPresented = false;
        }
        
     }
}

        

