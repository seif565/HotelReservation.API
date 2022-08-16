﻿using System.ComponentModel.DataAnnotations;

namespace HotelReservation.API.Models
{
    public class RoomType
    {
        [Key]
        public int TypeId { get; internal set; }        
        public double PricePerDay { get; internal set; }
        public string RoomKind { get; set; }
        public readonly Dictionary<string, double> roomPrice = new()
        {
            { "SUPERIOR ROOM", 100 },
            { "SUITE", 200 },
            { "FAMILY ROOM", 300 },
            { "VILLA", 400 }
        };
        public string[] type = { "SUPERIOR ROOM", "SUITE", "FAMILY ROOM", "VILLA" };
    }
}
