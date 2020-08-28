using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerModulo1.Models.Entidades;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerModulo1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public List<LocalesAfiliados> Locales;
        public Home()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CargarLocalesAfiliados();   
        }

        public void CargarLocalesAfiliados()
        {
            Locales = new List<LocalesAfiliados>() { 
                new LocalesAfiliados
                {
                    IdLocal="1",
                    AcercaDe="",
                    HorarioAtencion="",
                    ImageUrl="http://18.218.178.167/imagesemail/walmart.jpg",
                    NombreLocalAfiliado="Walmar"
                },
                 new LocalesAfiliados
                {
                    IdLocal="2",
                    AcercaDe="",
                    HorarioAtencion="",
                    ImageUrl="http://18.218.178.167/imagesemail/target.jpg",
                    NombreLocalAfiliado="Target"
                },
                 new LocalesAfiliados
                {
                    IdLocal="3",
                    AcercaDe="",
                    HorarioAtencion="",
                    ImageUrl="http://18.218.178.167/imagesemail/ferre1.jpg",
                    NombreLocalAfiliado="Ferreteria"
                }


            };

            CLLocales.ItemsSource = Locales;
        }



    }
}