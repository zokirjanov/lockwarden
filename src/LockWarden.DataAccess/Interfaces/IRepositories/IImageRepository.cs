﻿using LockWarden.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockWarden.DataAccess.Interfaces.IRepositories
{
	public interface IImageRepository : IGenericRepository<Image>
	{
        public Task<bool> DeleteAllAsync(int userId);
        public Task<bool> AddAllAsync(List<Image> entities);

    }
}
