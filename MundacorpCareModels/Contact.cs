namespace MundacorpCareModels
{
    public class Contact
    {
        public int Id { get; set; }
        public int MundacorpcareId { get; set; }
        public MundacorpcareInfo Mundacorpcare { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


    }
}