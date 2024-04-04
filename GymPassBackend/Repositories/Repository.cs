using GymPassBackend.DALs;
using GymPassBackend.DataAccess;
using GymPassBackend.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymPassBackend.Repositories
{
    public class Repository : IRepository
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }

        // Benefit crud
        public async Task<Benefit> AddBenefit(Benefit benefit)
        {
            benefit = _context.Benefits.Add(benefit).Entity;
            await _context.SaveChangesAsync();
            return benefit;
        }

        public async Task<List<Benefit>> GetBenefits()
        {
            List<Benefit> benefits = await _context.Benefits.ToListAsync();
            return benefits;
        }

        public async Task<Benefit> GetBenefit(int id)
        {
            Benefit benefit = await _context.Benefits.FirstOrDefaultAsync(b => b.Id == id);
            return benefit;
        }

        public async Task<Benefit> UpdateBenefit(Benefit benefit)
        {
            benefit = _context.Benefits.Update(benefit).Entity;
            await _context.SaveChangesAsync();
            return benefit;
        }

        public async Task DeleteBenefit(Benefit benefit)
        {
            _context.Benefits.Remove(benefit);
            await _context.SaveChangesAsync();
        }

        // ImageModel crud

        // Pass crud
        public async Task<Pass> AddPass(Pass pass)
        {
            pass = _context.Passes.Add(pass).Entity;
            await _context.SaveChangesAsync();
            return pass;
        }

        public async Task<List<Pass>> GetPasses()
        {
            List<Pass> passes = await _context.Passes.ToListAsync();
            return passes;
        }

        public async Task<Pass> GetPass(int id)
        {
            Pass pass = await _context.Passes.FirstOrDefaultAsync(p => p.Id == id);
            return pass;
        }

        public async Task<Pass> UpdatePass(Pass pass)
        {
            pass = _context.Passes.Update(pass).Entity;
            await _context.SaveChangesAsync();
            return pass;
        }

        public async Task DeletePass(Pass pass)
        {
            _context.Passes.Remove(pass);
            await _context.SaveChangesAsync();
        }

        // PassBenefit crud
        public async Task<PassBenefit> AddPassBenefit(PassBenefit passBenefit)
        {
            passBenefit = _context.PassBenefits.Add(passBenefit).Entity;
            await _context.SaveChangesAsync();
            return passBenefit;
        }

        public async Task<List<PassBenefit>> GetPassBenefits()
        {
            List<PassBenefit> passBenefits = await _context.PassBenefits.ToListAsync();
            return passBenefits;
        }

        public async Task<PassBenefit> GetPassBenefit(int id)
        {
            PassBenefit passBenefit = await _context.PassBenefits.FirstOrDefaultAsync(pb => pb.Id == id);
            return passBenefit;
        }

        public async Task<PassBenefit> UpdatePassBenefit(PassBenefit passBenefit)
        {
            passBenefit = _context.PassBenefits.Update(passBenefit).Entity;
            await _context.SaveChangesAsync();
            return passBenefit;
        }

        public async Task DeletePassBenefit(PassBenefit passBenefit)
        {
            _context.PassBenefits.Remove(passBenefit);
            await _context.SaveChangesAsync();
        }

        // ShopItem crud

        public async Task<ShopItem> AddShopItem(ShopItem shopItem)
        {
            shopItem = _context.ShopItems.Add(shopItem).Entity;
            await _context.SaveChangesAsync();
            return shopItem;
        }

        public async Task<List<ShopItem>> GetShopItems()
        {
            List<ShopItem> shopItems = await _context.ShopItems.ToListAsync();
            return shopItems;
        }

        public async Task<ShopItem> GetShopItem(int id)
        {
            ShopItem shopItem = await _context.ShopItems.FirstOrDefaultAsync(si => si.Id == id);
            return shopItem;
        }

        public async Task<ShopItem> UpdateShopItem(ShopItem shopItem)
        {
            shopItem = _context.ShopItems.Update(shopItem).Entity;
            await _context.SaveChangesAsync();
            return shopItem;
        }

        public async Task DeleteShopItem(ShopItem shopItem)
        {
            _context.ShopItems.Remove(shopItem);
            await _context.SaveChangesAsync();
        }

        // User crud

        public async Task<User> AddUser(User user)
        {
            user = _context.Users.Add(user).Entity;
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            List<User> users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUser(int id)
        {
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<User> GetUser(User user)
        {
            User userFound = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);
            return userFound;
        }

        public async Task<User> UpdateUser(User user)
        {
            user = _context.Users.Update(user).Entity;
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        // UserPass crud

        public async Task<UserPass> AddUserPass(UserPass userPass)
        {
            userPass = _context.UserPasses.Add(userPass).Entity;
            await _context.SaveChangesAsync();
            return userPass;
        }

        public async Task<List<UserPass>> GetUserPasses()
        {
            List<UserPass> userPasses = await _context.UserPasses.ToListAsync();
            return userPasses;
        }

        public async Task<UserPass> GetUserPass(int id)
        {
            UserPass userPass = await _context.UserPasses.FirstOrDefaultAsync(up => up.Id == id);
            return userPass;
        }

        public async Task<UserPass> UpdateUserPass(UserPass userPass)
        {
            userPass = _context.UserPasses.Update(userPass).Entity;
            await _context.SaveChangesAsync();
            return userPass;
        }

        public async Task DeleteUserPass(UserPass userPass)
        {
            _context.UserPasses.Remove(userPass);
            await _context.SaveChangesAsync();
        }

        // UserShopItem crud

        public async Task<UserShopItem> AddUserShopItem(UserShopItem userShopItem)
        {
            userShopItem = _context.UserShopItems.Add(userShopItem).Entity;
            await _context.SaveChangesAsync();
            return userShopItem;
        }

        public async Task<List<UserShopItem>> GetUserShopItems()
        {
            List<UserShopItem> userShopItems = await _context.UserShopItems.ToListAsync();
            return userShopItems;
        }

        public async Task<UserShopItem> GetUserShopItem(int id)
        {
            UserShopItem userShopItem = await _context.UserShopItems.FirstOrDefaultAsync(usi => usi.Id == id);
            return userShopItem;
        }

        public async Task<UserShopItem> UpdateUserShopItem(UserShopItem userShopItem)
        {
            userShopItem = _context.UserShopItems.Update(userShopItem).Entity;
            await _context.SaveChangesAsync();
            return userShopItem;
        }

        public async Task DeleteUserShopItem(UserShopItem userShopItem)
        {
            _context.UserShopItems.Remove(userShopItem);
            await _context.SaveChangesAsync();
        }
    }
}
