using CommunityToolkit.Mvvm.ComponentModel;
using PrismApp1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp1.Models
{
    public partial class MenuData : ObservableObject
    {
        [ObservableProperty]
        string title = "";
        [ObservableProperty]
        string icon = "";
    }
}
