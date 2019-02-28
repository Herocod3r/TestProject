using System;
using SampleApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace SampleApp.Services
{
    public interface ICategoryService
    {
        [Get("/categories/")]
        Task<List<Category>> GetCategoriesAsync();
        [Get("/categories/{id}")]
        Task<Category> GetCategoryByIdAsync(int id);


    }


    public interface IArticleService
    {
        [Get("/articles/")]
        Task<List<Article>> GetArticlesAsync();

        [Get("/articles/{id}")]
        Task<Article> GetArticle(int id);
    }
}
