using DallUIApp.Models;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;


namespace DallUIApp.Views;

public partial class Screen1View : ContentPage
{
   public ObservableCollection<Profile> Profiles { get; set; }
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }	
    public Screen1View()
	{
		InitializeComponent();
        FillData();

        BindingContext = this;
	}

    private void FillData()
    {
        Profiles = new ObservableCollection<Profile>
       {
           new Profile
           {
               Name = "John",
               NoImages = 12,
               Image = "profile1.jpg"

           },
           new Profile
           {
               Name = "Ria",
               NoImages = 13,
               Image = "profile2.jpg"

           },
           new Profile
           {
               Name = "Rose",
               NoImages = 14,
               Image = "profile3.jpg"

           }

       };

        GeneratedImages = new ObservableCollection<GeneratedImage>
       {
           new GeneratedImage
           {
               ImagePath="dashboard1.jpg",             
               MainKeyword="Palace",
                Keywords = new List<string>{
                   "Castle, Mountain, Trees"}
           },
           new GeneratedImage
           {
               ImagePath="dashboard2.jpg",
               MainKeyword="Hills",
                Keywords = new List<string>{
                   "Mist, Moon, Mountains"}
           },
           new GeneratedImage
           {
               ImagePath="dashboard3.jpg",
               MainKeyword="Robot",
                Keywords = new List<string>{
                   "AI, Technology, Future"}
           },
       };
    }
}