using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Appteste2
{
    public partial class MainPage : ContentPage
    {
        static string sorte= new Random().Next(1,4).ToString();

        async void Cliquei(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao.Text == sorte)
            {
                await DisplayAlert("Achou!", "Você é sortudo!", "Tente novamente!");
                sorte = new Random().Next(1,4).ToString();
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
