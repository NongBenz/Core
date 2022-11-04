﻿using BPEssentials.Abstractions;
using BPEssentials.ExtensionMethods;
using BrokeProtocol.Entities;

namespace BPEssentials.Commands
{
    public class RepairVehicle : BpeCommand
    {
        public void Invoke(ShPlayer player)
        {
            var vehicle = player.curMount as ShTransport;
            if (vehicle == null)
            {
                player.TS("player_notInVehicle");
                return;
            }
            vehicle.svTransport.HealFull();
            player.TS("player_vehicle_repaired", vehicle.name);
        }
    }
}
