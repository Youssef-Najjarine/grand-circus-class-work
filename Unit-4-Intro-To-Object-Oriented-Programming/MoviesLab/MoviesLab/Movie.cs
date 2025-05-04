using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    internal class Movie
    {
        // Fields
        private string _Title;
        private string _Category;
        private int _YearReleased;
        private double _RunTime;

        // Constructors
        public Movie(string title, string category, int yearReleased, double runTime)
        {
            this._Title = title;
            this ._Category = category;
            this._RunTime = runTime;
            this._YearReleased = yearReleased;
            this.Title = this._Title;
            this.Category = this._Category;
            this.RunTime = this._RunTime.ToString();
            this.YearReleased = this._YearReleased.ToString();
        }
        // Properties
        public string Title { get; }
        public string Category { get; }
        public string YearReleased { get; }
        public string RunTime { get; }
    }
}
