using Microsoft.EntityFrameworkCore;
using QuizAPI.Models;
using QuizAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<int> Add(User user);

        Task<int> Delete(int? Id);

        Task Update(User user);
    }
    public class UserRepository : IUserRepository
    {
        RexQuizContext _context;
        public UserRepository(RexQuizContext context)
        {
            this._context = context;
        }
        public async Task<int> Add(User user)
        {
            if (_context != null)
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return user.Id;
            }

            return 0;
        }

        public Task<int> Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll()
        {
            if (_context != null)
            {
                return await _context.Users.ToListAsync();
            }
            return null;
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
