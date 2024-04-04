namespace GymPassBackend.DALs
{
    public class UserPass
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int PassID { get; set; }
        //public int  { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpirationDate { get; set; }

    }

}
