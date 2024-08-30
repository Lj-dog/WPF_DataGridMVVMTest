using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    partial class Mainmodel //: ObservableObject
    {
       // [ObservableProperty]
        private string? _studentname;

        public string? Studentname { get; set; }

       // [ObservableProperty]
        private string? _studentid;

        public string? Studentid { get; set; }
    }
}
