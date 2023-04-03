﻿using System.Text.Json;

namespace PetShopDogsCats.API.Extensions
{
    public class ErrorDetails
    {
        public ErrorDetails()
        {
            
        }        

        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
