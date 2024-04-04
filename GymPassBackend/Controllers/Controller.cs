using GymPassBackend.DALs;
using GymPassBackend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymPassBackend.Controllers
{
    [ApiController]
    [Route("/api")]
    public class Controller : ControllerBase
    {
        private readonly IService _service;

        public Controller(IService service)
        {
            _service = service;
        }

        [HttpPost("/registration")]
        public async Task<IActionResult> AddUserTask([FromBody] User user)
        {
            User userAdded = await _service.AddUser(user);
            return Ok();
        }

        [HttpGet("/users")]
        public async Task<IActionResult> GetUsersTask()
        {
            List<User> users = await _service.GetUsers();
            return Ok(users);
        }

        [HttpGet("/user/{id}")]
        public async Task<IActionResult> GetUserTask(int id)
        {
            User user = await _service.GetUser(id);
            return Ok(user);
        }

        [HttpPut("/user")]
        public async Task<IActionResult> UpdateUserTask([FromBody] User user)
        {
            User userUpdated = await _service.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("/user")]
        public async Task<IActionResult> DeleteUserTask([FromBody] User user)
        {
            await _service.DeleteUser(user);
            return Ok();
        }

        [HttpPost("/pass")]
        public async Task<IActionResult> AddPassTask([FromBody] Pass pass)
        {
            Pass passAdded = await _service.AddPass(pass);
            return Ok();
        }

        [HttpGet("/passes")]
        public async Task<IActionResult> GetPassesTask()
        {
            List<Pass> passes = await _service.GetPasses();
            return Ok(passes);
        }

        [HttpGet("/pass/{id}")]
        public async Task<IActionResult> GetPassTask(int id)
        {
            Pass pass = await _service.GetPass(id);
            return Ok(pass);
        }

        [HttpPut("/pass")]
        public async Task<IActionResult> UpdatePassTask([FromBody] Pass pass)
        {
            Pass passUpdated = await _service.UpdatePass(pass);
            return Ok();
        }

        [HttpDelete("/pass")]
        public async Task<IActionResult> DeletePassTask([FromBody] Pass pass)
        {
            await _service.DeletePass(pass);
            return Ok();
        }

        [HttpPost("/userpass")]
        public async Task<IActionResult> AddUserPassTask([FromBody] UserPass userPass)
        {
            UserPass userPassAdded = await _service.AddUserPass(userPass);
            return Ok();
        }

        [HttpGet("/userpasses")]
        public async Task<IActionResult> GetUserPassesTask()
        {
            List<UserPass> userPasses = await _service.GetUserPasses();
            return Ok(userPasses);
        }

        [HttpGet("/userpass/{id}")]
        public async Task<IActionResult> GetUserPassTask(int id)
        {
            UserPass userPass = await _service.GetUserPass(id);
            return Ok(userPass);
        }

        [HttpPut("/userpass")]
        public async Task<IActionResult> UpdateUserPassTask([FromBody] UserPass userPass)
        {
            UserPass userPassUpdated = await _service.UpdateUserPass(userPass);
            return Ok();
        }

        [HttpDelete("/userpass")]
        public async Task<IActionResult> DeleteUserPassTask([FromBody] UserPass userPass)
        {
            await _service.DeleteUserPass(userPass);
            return Ok();
        }

        [HttpPost("/benefit")]
        public async Task<IActionResult> AddBenefitTask([FromBody] Benefit benefit)
        {
            Benefit benefitAdded = await _service.AddBenefit(benefit);
            return Ok();
        }

        [HttpGet("/benefits")]
        public async Task<IActionResult> GetBenefitsTask()
        {
            List<Benefit> benefits = await _service.GetBenefits();
            return Ok(benefits);
        }

        [HttpGet("/benefit/{id}")]
        public async Task<IActionResult> GetBenefitTask(int id)
        {
            Benefit benefit = await _service.GetBenefit(id);
            return Ok(benefit);
        }

        [HttpPut("/benefit")]
        public async Task<IActionResult> UpdateBenefitTask([FromBody] Benefit benefit)
        {
            Benefit benefitUpdated = await _service.UpdateBenefit(benefit);
            return Ok();
        }

        [HttpDelete("/benefit")]
        public async Task<IActionResult> DeleteBenefitTask([FromBody] Benefit benefit)
        {
            await _service.DeleteBenefit(benefit);
            return Ok();
        }

        [HttpPost("/passbenefit")]
        public async Task<IActionResult> AddPassBenefitTask([FromBody] PassBenefit passBenefit)
        {
            PassBenefit passBenefitAdded = await _service.AddPassBenefit(passBenefit);
            return Ok();
        }

        [HttpGet("/passbenefits")]
        public async Task<IActionResult> GetPassBenefitsTask()
        {
            List<PassBenefit> passBenefits = await _service.GetPassBenefits();
            return Ok(passBenefits);
        }

        [HttpGet("/passbenefit/{id}")]
        public async Task<IActionResult> GetPassBenefitTask(int id)
        {
            PassBenefit passBenefit = await _service.GetPassBenefit(id);
            return Ok(passBenefit);
        }

        [HttpPut("/passbenefit")]
        public async Task<IActionResult> UpdatePassBenefitTask([FromBody] PassBenefit passBenefit)
        {
            PassBenefit passBenefitUpdated = await _service.UpdatePassBenefit(passBenefit);
            return Ok();
        }

        [HttpDelete("/passbenefit")]
        public async Task<IActionResult> DeletePassBenefitTask([FromBody] PassBenefit passBenefit)
        {
            await _service.DeletePassBenefit(passBenefit);
            return Ok();
        }

        [HttpPost("/shopitem")]
        public async Task<IActionResult> AddShopItemTask([FromBody] ShopItem shopItem)
        {
            ShopItem shopItemAdded = await _service.AddShopItem(shopItem);
            return Ok();
        }

        [HttpGet("/shopitems")]
        public async Task<IActionResult> GetShopItemsTask()
        {
            List<ShopItem> shopItems = await _service.GetShopItems();
            return Ok(shopItems);
        }

        [HttpGet("/shopitem/{id}")]
        public async Task<IActionResult> GetShopItemTask(int id)
        {
            ShopItem shopItem = await _service.GetShopItem(id);
            return Ok(shopItem);
        }

        [HttpPut("/shopitem")]
        public async Task<IActionResult> UpdateShopItemTask([FromBody] ShopItem shopItem)
        {
            ShopItem shopItemUpdated = await _service.UpdateShopItem(shopItem);
            return Ok();
        }

        [HttpDelete("/shopitem")]
        public async Task<IActionResult> DeleteShopItemTask([FromBody] ShopItem shopItem)
        {
            await _service.DeleteShopItem(shopItem);
            return Ok();
        }

        [HttpPost("/usershopitem")]
        public async Task<IActionResult> AddUserShopItemTask([FromBody] UserShopItem userShopItem)
        {
            UserShopItem userShopItemAdded = await _service.AddUserShopItem(userShopItem);
            return Ok();
        }

        [HttpGet("/usershopitems")]
        public async Task<IActionResult> GetUserShopItemsTask()
        {
            List<UserShopItem> userShopItems = await _service.GetUserShopItems();
            return Ok(userShopItems);
        }

        [HttpGet("/usershopitem/{id}")]
        public async Task<IActionResult> GetUserShopItemTask(int id)
        {
            UserShopItem userShopItem = await _service.GetUserShopItem(id);
            return Ok(userShopItem);
        }

        [HttpPut("/usershopitem")]
        public async Task<IActionResult> UpdateUserShopItemTask([FromBody] UserShopItem userShopItem)
        {
            UserShopItem userShopItemUpdated = await _service.UpdateUserShopItem(userShopItem);
            return Ok();
        }

        [HttpDelete("/usershopitem")]
        public async Task<IActionResult> DeleteUserShopItemTask([FromBody] UserShopItem userShopItem)
        {
            await _service.DeleteUserShopItem(userShopItem);
            return Ok();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> LoginTask([FromBody] User user)
        {
            User userFound = await _service.GetUser(user);
            if (userFound == null)
            {
                return NotFound();
            }
            return Ok(true);
        }

        [HttpPost("/buy")]
        public async Task<IActionResult> BuyTask([FromBody] UserShopItem userShopItem)
        {
            UserShopItem userShopItemAdded = await _service.AddUserShopItem(userShopItem);
            return Ok();
        }

        [HttpPost("/register")]
        public async Task<IActionResult> RegisterTask([FromBody] User user)
        {
            User userAdded = await _service.AddUser(user);
            return Ok();
        }


    }
}
