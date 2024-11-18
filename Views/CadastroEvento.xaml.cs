using MauiAppCE.Models;

namespace MauiAppCE.Views
{
    public partial class CadastroEvento : ContentPage
    {
        public CadastroEvento()
        {
            InitializeComponent();
        }

        // Evento de mudança no Stepper para atualizar o label com o número de participantes
        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelParticipantes.Text = ((int)e.NewValue).ToString();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            // Obter os dados inseridos no formulário
            string nomeEvento = entryNomeEvento.Text;
            DateTime dataInicio = datePickerInicio.Date;
            DateTime dataTermino = datePickerTermino.Date;
            int numeroParticipantes = (int)stepperParticipantes.Value;
            decimal custoPorParticipante = decimal.Parse(entryCustoParticipante.Text);
            string localEvento = entryLocal.Text;

            // Criar o objeto Evento com os dados
            Evento evento = new Evento
            {
                Nome = nomeEvento,
                DataInicio = dataInicio,
                DataTermino = dataTermino,
                NumeroParticipantes = numeroParticipantes,
                CustoPorParticipante = custoPorParticipante,
                Local = localEvento // Agora o local do evento está sendo passado corretamente
            };

            // Navegar para a página de resumo de evento
            await Navigation.PushAsync(new ResumoEvento(evento));
        }
    }
}
