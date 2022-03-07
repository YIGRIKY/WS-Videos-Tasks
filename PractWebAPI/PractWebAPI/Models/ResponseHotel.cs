﻿using PractWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PractWebAPI.Models
{
    public class ResponseHotel
    {
        public ResponseHotel(Hotel hotel)
        {
            Id = hotel.Id;
            Name = hotel.Name;
            CountOfStars = hotel.CountOfStars;
            CountryName = hotel.Country.Name;
            HotelImage = hotel.HotelImages.ToList().FirstOrDefault()?.ImageSource;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountOfStars { get; set; }
        public string CountryName { get; set; }
        public byte[] HotelImage { get; set; }
    }
}