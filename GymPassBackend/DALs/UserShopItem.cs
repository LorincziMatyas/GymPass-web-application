namespace GymPassBackend.DALs
{
    public class UserShopItem
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

}
