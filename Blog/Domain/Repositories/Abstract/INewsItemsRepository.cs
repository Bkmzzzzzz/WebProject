using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.Abstract
{
    public interface INewsItemsRepository
    {
        IQueryable<NewsItem> GetNewsItems();
        IQueryable<NewsItem> GetSideBarNewsItems();
        NewsItem GetNewsItemById(Guid id);
        void SaveNewsItem(NewsItem entity);
        void DeleteNewsItem(Guid id);
    }
}
