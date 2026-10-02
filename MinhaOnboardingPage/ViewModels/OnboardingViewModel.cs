using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MinhaOnboardingPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaOnboardingPage.ViewModels
{
    public partial class OnboardingViewModel : ObservableObject 
    {
        [ObservableProperty]
        private List<OnboardingItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;

        public bool ExibirBotao => !IsLastPosicao;

        public OnboardingViewModel()
        {
            Itens = new List<OnboardingItem>
            {
                new OnboardingItem
                {
                    Titulo = "Compre agora!",
                    Descricao = "Qualquer hora, qualquer lugar",
                    ImageUrl = "shop.png"
                },
                new OnboardingItem
                {
                    Titulo = "Frete grátis",
                    Descricao = "Receba em casa ou retire na loja",
                    ImageUrl = "shipping.png"
                },
                new OnboardingItem
                {
                    Titulo = "Pague como quiser",
                    Descricao = "Cartão, pix, boleto ou na entrega",
                    ImageUrl = "payment.png"
                }
            };
        }

        [RelayCommand]
        private void Proximo()
        {
            if (Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
        }
    }
}
