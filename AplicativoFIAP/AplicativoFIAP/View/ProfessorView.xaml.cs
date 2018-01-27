using AplicativoFIAP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AplicativoFIAP.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfessorView : ContentPage
	{
		public ProfessorView ()
		{

           BindingContext = ProfessorViewModel.Instancia;
            InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            lstProfessores.IsRefreshing = !lstProfessores.IsRefreshing;
            await ProfessorViewModel.Instancia.Carregar();
            lstProfessores.IsRefreshing = !lstProfessores.IsRefreshing;

        }

    }
}