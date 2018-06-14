using System;
using System.Collections.Generic;
using System.Text;

namespace SyncfusionChartXF.Models
{
    public static class Data
    {

        public static List<TemperatureData> Temperatures = new List<TemperatureData>
                {
                new TemperatureData {Month = "Jan", Temperature = 30, temp2=24 },
                new TemperatureData {Month = "Feb", Temperature = 43, temp2=15 },
                new TemperatureData {Month = "Mar", Temperature = 20, temp2=45 },
                new TemperatureData {Month = "Apr", Temperature = 54, temp2=78 },
                new TemperatureData {Month = "May", Temperature = 15, temp2=43 },
                new TemperatureData {Month = "Jun", Temperature = 50, temp2=50 },
                new TemperatureData {Month = "Jul", Temperature = 25, temp2 = 67 },
                new TemperatureData {Month = "Aug", Temperature = 36, temp2=30 },
            };
        public static List<ExpenditureData> Expenditures = new List<ExpenditureData>
                {
                    new ExpenditureData { Type = "Sports & Health", AmountSpent = 300 },
                    new ExpenditureData { Type = "Housing", AmountSpent = 500 },
                    new ExpenditureData { Type = "Food", AmountSpent = 450 }
                };
    }
}
