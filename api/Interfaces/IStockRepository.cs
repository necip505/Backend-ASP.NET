﻿using System.Collections.Generic;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Helpers;
using api.Models; // for Stock
namespace api.Interfaces
{
    public interface IStockRepository
    {
    Task<List<Stock>> GetAllAsync(QueryObject query);
    Task<Stock?> GetByIdAsync(int id);
    Task<Stock> CreateAsync(Stock stockModel);
    Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
    Task<Stock?> DeleteAsync(int id);
    Task<bool> StockExists(int id);
    }
}
