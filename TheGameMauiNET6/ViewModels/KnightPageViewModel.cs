using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameMauiNET6.Models;


namespace TheGameMauiNET6.ViewModels
{
    internal partial class KnightPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public Models.Knight goKnight;

        public KnightPageViewModel()
        {
            GoKnight = new Models.Knight();
        }      
    }
}
