using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab07.Models
{
    public static class carList
    {
       public static List<Car> cars = new List<Car>()
            {
                new Car(){Num=1,Color="red",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=2,Color="blue",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=3,Color="green",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=4,Color="red",Model="AS123",Manfacture="Marcidase"},
                new Car(){Num=5,Color="yellow",Model="AS123",Manfacture="Marcidase"}
            };
    }
}
