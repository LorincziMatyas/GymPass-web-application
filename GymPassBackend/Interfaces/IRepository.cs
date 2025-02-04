﻿using GymPassBackend.DALs;

namespace GymPassBackend.Interfaces
{
    public interface IRepository
    {
        Task<User> AddUser(User user);
        Task<List<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<User> GetUser(User user);
        Task<User> UpdateUser(User user);
        Task DeleteUser(User user);

        Task<Pass> AddPass(Pass pass);
        Task<List<Pass>> GetPasses();
        Task<Pass> GetPass(int id);
        Task<Pass> UpdatePass(Pass pass);
        Task DeletePass(Pass pass);

        Task<UserPass> AddUserPass(UserPass userPass);
        Task<List<UserPass>> GetUserPasses();
        Task<UserPass> GetUserPass(int id);
        Task<UserPass> UpdateUserPass(UserPass userPass);
        Task DeleteUserPass(UserPass userPass);

        Task<Benefit> AddBenefit(Benefit benefit);
        Task<List<Benefit>> GetBenefits();
        Task<Benefit> GetBenefit(int id);
        Task<Benefit> UpdateBenefit(Benefit benefit);
        Task DeleteBenefit(Benefit benefit);

        Task<PassBenefit> AddPassBenefit(PassBenefit passBenefit);
        Task<List<PassBenefit>> GetPassBenefits();
        Task<PassBenefit> GetPassBenefit(int id);
        Task<PassBenefit> UpdatePassBenefit(PassBenefit passBenefit);
        Task DeletePassBenefit(PassBenefit passBenefit);

        Task<ShopItem> AddShopItem(ShopItem shopItem);
        Task<List<ShopItem>> GetShopItems();
        Task<ShopItem> GetShopItem(int id);
        Task<ShopItem> UpdateShopItem(ShopItem shopItem);
        Task DeleteShopItem(ShopItem shopItem);

        Task<UserShopItem> AddUserShopItem(UserShopItem userShopItem);
        Task<List<UserShopItem>> GetUserShopItems();
        Task<UserShopItem> GetUserShopItem(int id);
        Task<UserShopItem> UpdateUserShopItem(UserShopItem userShopItem);
        Task DeleteUserShopItem(UserShopItem userShopItem);
    }
}