using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class HeroiSuperpoderModel
    {
        public int? id { get; set; }
        public int HeroiId { get; set; }
        public int SuperpoderId { get; set; }
    }

}
