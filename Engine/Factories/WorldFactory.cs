using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home", "You currently reside in Culver City", "/Engine;component/Images/Locations/CulverCityRevise.jpg");

            return newWorld;
        }
    }
}
