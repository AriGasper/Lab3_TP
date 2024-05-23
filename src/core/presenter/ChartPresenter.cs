using Lab3_TP.src.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3_TP.src.core.presenter
{
    internal class ChartPresenter : IChartPresenter
    {
        IChartView view;

        public IChartView View
        {
            set
            {
                if (view != null)
                {
                    this.view.RequestedStatistics -= RunCommand;
                    this.view.ChangedCommand -= ChangeCommand;
                }
                this.view = value;
                this.view.RequestedStatistics += RunCommand;
                this.view.ChangedCommand += ChangeCommand;
            }
        }

        public void ShowAdditionalInfo(string info)
        {
            view.ShowAdditionalInfo(info);
        }

        public void ShowChart(List<Series> series)
        {
            view.ShowChart(series);
        }

        public void ShowGrid(List<string> columnsName, List<List<string>> rows)
        {
            view.ShowGrid(columnsName, rows);
        }

        private void RunCommand()
        {
            string csv = view.GetCSV();

        }

        private void ChangeCommand(String code)
        {
        }
    }
}
