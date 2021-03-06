﻿using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace Highway.Insurance.UI.Windows.Controls.WinForms
{
    /// <summary>
    /// Wrapper class for WinSlider
    /// </summary>
    public class EnhancedWinSlider : EnhancedWinControl<WinSlider>
    {
        public EnhancedWinSlider() : base() { }
        public EnhancedWinSlider(string searchParameters) : base(searchParameters) { }

        public double LineSize
        {
            get { return this.UnWrap().LineSize; }
        }

        public double MaximumPosition
        {
            get { return this.UnWrap().MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return this.UnWrap().MinimumPosition; }
        }

        public double PageSize
        {
            get { return this.UnWrap().PageSize; }
        }

        public double Position
        {
            get { return this.UnWrap().Position; }
            set { this.UnWrap().Position = value; }
        }

        public string PositionAsString
        {
            get { return this.UnWrap().PositionAsString; }
            set { this.UnWrap().PositionAsString = value; }
        }

        public double TickCount
        {
            get { return this.UnWrap().TickCount; }
        }

        public double TickPosition
        {
            get { return this.UnWrap().TickPosition; }
        }

        public double TickValue
        {
            get { return this.UnWrap().TickValue; }
        }
    }
}