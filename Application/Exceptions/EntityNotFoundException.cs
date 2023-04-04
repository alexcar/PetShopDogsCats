﻿namespace Application.Exceptions
{
    public class EntityNotFoundException : NotFoundException
    {
        public EntityNotFoundException(string message) 
            : base(message)
        {
        }
    }
}
