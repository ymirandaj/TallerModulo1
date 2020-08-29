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
    public partial class Producto : TabbedPage
    {
        List<ProductoTienda> Productos;
        public Producto(string idLocal, string nombreLocal)
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarProductos();
        }

        void CargarProductos()
        {
            Productos = new List<ProductoTienda>() {
                new ProductoTienda{
                    IdProducto= "1",
                    Nombre = "Camiseta",
                    Descripcion="Camisetas colombianas",
                    Price= 15,
                    UrlImage= "http://18.218.178.167/imagesemail/camiseta.jpg"
                },
                 new ProductoTienda{
                    IdProducto= "2",
                    Nombre = "Jean",
                    Descripcion= "Jeam de origen peruanos",
                    Price=25,
                    UrlImage= "http://18.218.178.167/imagesemail/Jean.png"
                },
                  new ProductoTienda{
                    IdProducto= "3",
                    Nombre = "Juegos PS4",
                    Descripcion= "Juegos usados y nuevos",
                    Price= 50,
                    UrlImage= "http://18.218.178.167/imagesemail/JuegosPlay4.png"
                }
            };
            CLProductos.ItemsSource = Productos;
        }
    }
}