﻿using HotelListing.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IUniteOfWork : IDisposable 
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
