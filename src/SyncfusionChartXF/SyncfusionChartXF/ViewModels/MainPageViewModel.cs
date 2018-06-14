using SyncfusionChartXF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SyncfusionChartXF.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<ExpenditureData> expenditureData;

        public ObservableCollection<ExpenditureData> ExpenditureData
        {
            get { return expenditureData; }
            set { SetProperty(ref expenditureData, value); }
        }

        public MainPageViewModel()
        {
            ExpenditureData = new ObservableCollection<ExpenditureData>(Data.Expenditures);
        }

    }
}
