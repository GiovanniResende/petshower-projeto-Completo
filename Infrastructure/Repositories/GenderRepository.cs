﻿using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class GenderRepository : IGenderRepository
    {
        public Task<Gender?> CreateAsync(Gender gender)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Gender?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Gender?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Gender?> UpdateAsync(Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}