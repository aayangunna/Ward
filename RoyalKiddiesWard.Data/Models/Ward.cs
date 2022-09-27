using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalKiddiesWard.Data.Models
{
    [Table ("Ward")]
    public class Ward
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
