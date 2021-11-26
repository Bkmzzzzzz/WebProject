using System;
using System.Linq;
using Blog.Domain;
using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;


namespace Blog.Domain.Repositories.EntityFramework
{
    public class EFNewsItemsRepository : INewsItemsRepository
    {
        private readonly AppDbContext context;
        public EFNewsItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<NewsItem> GetNewsItems()
        {
           
                return context.NewsItems;
        }
        public IQueryable<NewsItem> GetSideBarNewsItems()
        {
            return context.NewsItems.Take(3);
        }

        public NewsItem GetNewsItemById(Guid id)
        {
            return context.NewsItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveNewsItem(NewsItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteNewsItem(Guid id)
        {
            context.NewsItems.Remove(new NewsItem() { Id = id });
            context.SaveChanges();
        }
    }
}
