﻿using BurgerApp.DomainModels;
using BurgerApp.Models;

namespace BurgerApp.Mappers
{
    public static class SizeMapper
    {
        public static SizeViewModel ToViewModel(this Size size)
        {
            return new SizeViewModel 
            {
                Id = size.Id,
                Name = size.Name,
            };
        }
    }
}
