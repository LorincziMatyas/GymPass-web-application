using GymPassBackend.DALs;
using GymPassBackend.Interfaces;

namespace GymPassBackend.Services
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }

        // Benefit CRUD operations
        public async Task<Benefit> AddBenefit(Benefit benefit)
        {
            return await _repository.AddBenefit(benefit);
        }

        public async Task<List<Benefit>> GetBenefits()
        {
            return await _repository.GetBenefits();
        }

        public async Task<Benefit> GetBenefit(int id)
        {
            return await _repository.GetBenefit(id);
        }

        public async Task<Benefit> UpdateBenefit(Benefit benefit)
        {
            return await _repository.UpdateBenefit(benefit);
        }

        public async Task DeleteBenefit(Benefit benefit)
        {
            await _repository.DeleteBenefit(benefit);
        }

        // Pass CRUD operations
        public async Task<Pass> AddPass(Pass pass)
        {
            return await _repository.AddPass(pass);
        }

        public async Task<List<Pass>> GetPasses()
        {
            return await _repository.GetPasses();
        }

        public async Task<Pass> GetPass(int id)
        {
            return await _repository.GetPass(id);
        }

        public async Task<Pass> UpdatePass(Pass pass)
        {
            return await _repository.UpdatePass(pass);
        }

        public async Task DeletePass(Pass pass)
        {
            await _repository.DeletePass(pass);
        }

        // PassBenefit CRUD operations
        public async Task<PassBenefit> AddPassBenefit(PassBenefit passBenefit)
        {
            return await _repository.AddPassBenefit(passBenefit);
        }

        public async Task<List<PassBenefit>> GetPassBenefits()
        {
            return await _repository.GetPassBenefits();
        }

        public async Task<PassBenefit> GetPassBenefit(int id)
        {
            return await _repository.GetPassBenefit(id);
        }

        public async Task<PassBenefit> UpdatePassBenefit(PassBenefit passBenefit)
        {
            return await _repository.UpdatePassBenefit(passBenefit);
        }

        public async Task DeletePassBenefit(PassBenefit passBenefit)
        {
            await _repository.DeletePassBenefit(passBenefit);
        }

        // ShopItem CRUD operations
        public async Task<ShopItem> AddShopItem(ShopItem shopItem)
        {
            return await _repository.AddShopItem(shopItem);
        }

        public async Task<List<ShopItem>> GetShopItems()
        {
            return await _repository.GetShopItems();
        }

        public async Task<ShopItem> GetShopItem(int id)
        {
            return await _repository.GetShopItem(id);
        }

        public async Task<ShopItem> UpdateShopItem(ShopItem shopItem)
        {
            return await _repository.UpdateShopItem(shopItem);
        }

        public async Task DeleteShopItem(ShopItem shopItem)
        {
            await _repository.DeleteShopItem(shopItem);
        }

        // User CRUD operations
        public async Task<User> AddUser(User user)
        {
            return await _repository.AddUser(user);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _repository.GetUsers();
        }

        public async Task<User> GetUser(int id)
        {
            return await _repository.GetUser(id);
        }

        public async Task<User> GetUser(User user)
        {
            return await _repository.GetUser(user);
        }

        public async Task<User> UpdateUser(User user)
        {
            return await _repository.UpdateUser(user);
        }

        public async Task DeleteUser(User user)
        {
            await _repository.DeleteUser(user);
        }

        // UserPass CRUD operations
        public async Task<UserPass> AddUserPass(UserPass userPass)
        {
            return await _repository.AddUserPass(userPass);
        }

        public async Task<List<UserPass>> GetUserPasses()
        {
            return await _repository.GetUserPasses();
        }

        public async Task<UserPass> GetUserPass(int id)
        {
            return await _repository.GetUserPass(id);
        }

        public async Task<UserPass> UpdateUserPass(UserPass userPass)
        {
            return await _repository.UpdateUserPass(userPass);
        }

        public async Task DeleteUserPass(UserPass userPass)
        {
            await _repository.DeleteUserPass(userPass);
        }

        // UserShopItem CRUD operations
        public async Task<UserShopItem> AddUserShopItem(UserShopItem userShopItem)
        {
            return await _repository.AddUserShopItem(userShopItem);
        }

        public async Task<List<UserShopItem>> GetUserShopItems()
        {
            return await _repository.GetUserShopItems();
        }

        public async Task<UserShopItem> GetUserShopItem(int id)
        {
            return await _repository.GetUserShopItem(id);
        }

        public async Task<UserShopItem> UpdateUserShopItem(UserShopItem userShopItem)
        {
            return await _repository.UpdateUserShopItem(userShopItem);
        }

        public async Task DeleteUserShopItem(UserShopItem userShopItem)
        {
            await _repository.DeleteUserShopItem(userShopItem);
        }
    }
}
