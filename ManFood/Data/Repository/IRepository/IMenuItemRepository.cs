using System;
using System.Collections.Generic;
using System.Text;
using ManFood.Data.Repository.IRepository;
using ManFood.Models;

namespace ManFood.Data.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
    }
}