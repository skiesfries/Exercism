using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{ 
    public class SpaceAge
    {
        public const double earthSecondsInYear = 31_557_600;
        public double Seconds { get; set; }
        public Dictionary<string, double> orbitalPeriods = new()
        {
            { "Mercury", 0.2408467 },
            { "Venus", 0.61519726 },
            { "Earth", 1.0 },
            { "Mars", 1.8808158 },
            { "Jupiter", 11.862615 },
            { "Saturn", 29.447498 },
            { "Uranus", 84.016846 },
            { "Neptune", 164.79132 }
        };

        public SpaceAge(int seconds)
        {
            Seconds = seconds;
            
        }
        
        public double GetYears(string planet) => Math.Round(Seconds / (orbitalPeriods[planet] * earthSecondsInYear), 2);

        public double OnEarth() => GetYears("Earth");
        public double OnMercury() => GetYears("Mercury");
        public double OnVenus() => GetYears("Venus");
        public double OnMars() => GetYears("Mars");
        public double OnJupiter() => GetYears("Jupiter");
        public double OnSaturn() => GetYears("Saturn");
        public double OnUranus() => GetYears("Uranus");
        public double OnNeptune() => GetYears("Neptune");
        
    }
}
