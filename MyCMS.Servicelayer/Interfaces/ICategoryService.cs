﻿using System.Collections.Generic;
using MyCMS.DomainClasses.Entities;
using MyCMS.Model.AdminModel;
using MyCMS.Model.SideBar;
using MyCMS.Servicelayer.EFServices.Enums;

namespace MyCMS.Servicelayer.Interfaces
{
    public interface ICategoryService
    {
        int Count { get; }
        void Add(Category category);
        bool IsExistByName(string name);
        void Remove(int id);
        void Update(Category category);
        Category Find(int id);
        Category Find(string categoryName);

        IList<CategoryDataTableModel> GetDataTable(string term, int page, int count,
            Order order, CategoryOrderBy orderBy, CategorySearchBy searchBy);

        int GetMaxOrder();
        bool IsExistByOrder(int orderNumber);
        IList<Category> GetAll();
        IList<Category> GetAnnounceData(int count);
        IList<CategoryModel> GetSideBarData(int articleCount = 10);
    }
}