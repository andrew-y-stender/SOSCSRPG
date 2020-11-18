using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home",
                "You currently reside in Culver City",
                "/Engine;component/Images/Locations/CulverCityRevise.jpg");

            newWorld.AddLocation(0, 0, "Beverly Hills",
                "You have arrived in Beverly Hills",
                "/Engine;component/Images/Locations/BeverlyHillsRevise.jpg");

            newWorld.AddLocation(0, 1, "Christian Louboutin",
                "You have arrived at Christian Louboutin",
                "/Engine;component/Images/Locations/LouboutinRevise.jpg");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "West Hollywood",
                "You currently arrived in Weho",
                "/Engine;component/Images/Locations/WehoRevise.jpg");

            newWorld.LocationAt(0, 2).AddMonster(1, 100);

            newWorld.AddLocation(1, 0, "10 Freeway",
                "You are currently *stuck* on the 10 Freeway",
                "/Engine;component/Images/Locations/FreewayRevise.jpg");

            newWorld.AddLocation(2, 0, "Skid Row",
                "You are arrived at Skid Row",
                "/Engine;component/Images/Locations/SkidRowRevise.jpg");

            newWorld.LocationAt(2, 0).AddMonster(3, 100);

            newWorld.AddLocation(-1, 0, "UCLA",
                "You are arrived at UCLA",
                "/Engine;component/Images/Locations/UCLARevise.jpg");

            newWorld.AddLocation(-1, -1, "3rd St. Promenade",
                "You are arrived at the 3rd St. Promenade",
                "/Engine;component/Images/Locations/3rdStreetRevise.jpg");

            newWorld.AddLocation(-2, -1, "Venice Beach",
                "You are arrived at Venice Beach",
                "/Engine;component/Images/Locations/VeniceBeachRevise.jpg");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            return newWorld;
        }
    }
}
