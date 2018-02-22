namespace WpfApp2
{
    using System;

    using OxyPlot;
    using OxyPlot.Series;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.MyModel = new PlotModel { Title = "Result" };
            this.MyModel.Series.Add(new FunctionSeries((Math.Cos), 0, 10, 0.1, "cos(x)"));
        }

        private void ToCode(string v)
        {
            throw new NotImplementedException();
        }

        public PlotModel MyModel { get; private set; }
    }
}