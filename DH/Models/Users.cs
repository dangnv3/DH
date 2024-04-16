using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DH.Models
{
    public class Users
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string phone { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public bool isAdmin { get; set; }

        public int RoleID { get; set; }
        public int create_at { get; set; }
        public int update_at { get; set; }
        public int delete_at { get; set; }
        public DateTime createdate { get; set; }
        public DateTime updatedate { get; set; }
        public DateTime deletedate { get; set; }
        public DateTime birthday { get; set; }
    }
}
