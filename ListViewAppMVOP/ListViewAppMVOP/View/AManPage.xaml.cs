using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ListViewAppMVOP.Model;
using System.ComponentModel;

namespace ListViewAppMVOP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class PageViewModel:INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;

        public PageViewModel(AMan man)
        {
            FirstName = man.FirstName;
            SurName = man.SurName;
            Age = man.Age;
        }

        string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set 
            {
                _FirstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName")); 
            }
        }

        string _SurName;
        public string SurName
        {
            get { return _SurName; }
            set
            {
                _SurName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SurName"));
            }
        }

        int _Age;
        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public AMan ToAMan()
        {
            AMan am = new AMan
            {
                FirstName = this.FirstName,
                SurName = this.SurName,
                Age = this.Age
            };

            return am;
        }
    }

    public partial class AManPage : ContentPage
    {
        ObservableCollection<AMan> oCollection;

        public AManPage()
        {
            InitializeComponent();
        }

        public AManPage(AMan m, ObservableCollection<AMan> collection)
        {
            InitializeComponent();
            PageViewModel pvm = new PageViewModel(m);
            BindingContext = pvm;
            oCollection = collection;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            oCollection.Add((BindingContext as PageViewModel).ToAMan());
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}