using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class HeroiSuperpoderModel
    {
        public int HeroiId { get; set; }
        public int SuperpoderId { get; set; }
    }
}
