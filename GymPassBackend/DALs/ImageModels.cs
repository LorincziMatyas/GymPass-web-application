namespace GymPassBackend.DALs
{
    public class ImageModels
    {
        public int Id { get; set; }
        public int CampHostId { get; set; }
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
    }

}
