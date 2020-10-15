using System;

namespace example3.Models
{
    public class Square
    {
        public Square(double wallValue)
        {
            _wall = wallValue;
        }
        
        private double _wall;

        public void Increase(double percent)
        {
            _wall += _wall * percent / 100;
        }

        public void Decrease(double percent)
        {
            _wall -= _wall * percent / 100;
        }
        
        public double GetWall() => _wall;

        public double GetPerimeter() => _wall * 4;
        public double GetArea() => _wall * _wall;
        public double GetDiagonal() => Math.Sqrt(_wall * _wall + _wall * _wall);
    }
}