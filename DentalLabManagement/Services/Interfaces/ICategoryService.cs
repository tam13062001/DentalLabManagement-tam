﻿using DentalLabManagement.BusinessTier.Enums;
using DentalLabManagement.BusinessTier.Payload.Account;
using DentalLabManagement.BusinessTier.Payload.Category;
using DentalLabManagement.BusinessTier.Payload.ProductStage;
using DentalLabManagement.DataTier.Models;
using DentalLabManagement.DataTier.Paginate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalLabManagement.API.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<CategoryResponse> CreateCategory(CategoryRequest categoryRequest);

        public Task<IPaginate<CategoryResponse>> GetCategories(string? searchCategoryName, CategoryStatus? status, int page, int size);

        public Task<CategoryResponse> GetCategoryById(int id);
        public Task<CategoryResponse> UpdateCategoryInformation(int categoryId, UpdateCategoryRequest updateCategoryRequest);
        public Task<bool> CategoryMappingProductStage(int categoryId, List<int> request);
        public Task<IPaginate<ProductStageResponse>> GetProductStageByCategory(int categoryId, int page, int size);
        public Task<bool> UpdateCategoryStatus(int id);
    }
}
