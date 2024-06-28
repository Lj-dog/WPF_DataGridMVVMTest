using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using WpfApp.Models;

namespace WpfApp.ViewModels
{
    internal partial class Mainviewmodel : ObservableObject
    {
        public Mainviewmodel()
        {
            Mainmodels = new();
            Mainmodels.CollectionChanged += MainmodelsChanged;
            Model = new();
        }

        [ObservableProperty]
        private ObservableCollection<Mainmodel>? _mainmodels;

        [ObservableProperty]
        private Mainmodel _model;

        [ObservableProperty]
        private Mainmodel? _selectmodel;

        [ObservableProperty]
        private int _number;

        [RelayCommand]
        private void BtnAdd()
        {
            Mainmodel newmodel = new() { Studentid = Model.Studentid, Studentname = Model.Studentname };
            Mainmodels?.Add(newmodel);
            //Trace.WriteLine("我只演示一次");
        }

        [RelayCommand]
        private void BtnRemove()
        {
            if (Selectmodel != null)
            {
                Mainmodels?.Remove(Selectmodel);
            }
        }

        //partial void OnMainmodelsChanged(ObservableCollection<Mainmodel> value)
        //{
        //    MessageBox.Show("Changeded");
        //}

        private void MainmodelsChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            MessageBox.Show("Changeded");
        }
    }
}