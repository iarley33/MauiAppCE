using MauiAppCE.Models;

namespace MauiAppCE.Views
{
    public partial class ResumoEvento : ContentPage
    {
        public ResumoEvento(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento; // Definir o contexto de dados do evento
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Voltar à página anterior
        }
    }
}
