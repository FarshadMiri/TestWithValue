﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithValue.Domain.Enitities;

namespace TestWithValue.Application.Contract.Persistence
{
    public interface ICategoryRepository
    {
        Task<Tbl_Category> GetCategoryByScore(int totalScore);
    }
}
