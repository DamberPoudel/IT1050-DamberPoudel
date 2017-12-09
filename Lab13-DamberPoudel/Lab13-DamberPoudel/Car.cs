using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_DamberPoudel
{
    class Car
    {
        private int Speed;
        private string Make;
        private string Model;
        private int Year;
    }
}
        public Car(string make, string model, int year, int speed)
{
    this.Make = make;
    this.Model = model;
    this.Year = year;
    this.Speed = speed;

   
}
        public car(string make, string model, int year)
{
    this.Make = make;
    this.Model = model;
    this.Year = year;
    this.Speed = 0;

}

public int SpeedUp()
{
    this.Speed++;
    return this.speed;
}
public int slowdown()
{
    this.Speed--;
    return this.Speed;
}