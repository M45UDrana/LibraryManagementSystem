﻿using LMS.Core.Entities.Books;

namespace LMS.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllWithBooks();
        Author GetSingleWithBooks(int id);
    }
}