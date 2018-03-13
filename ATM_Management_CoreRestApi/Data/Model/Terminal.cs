using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Management_CoreRestApi.Models
{
    public class Terminal
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TerminalId { get; set; }

        [Required(ErrorMessage = "TerminalCode Must be provided")]
        [StringLength(50, MinimumLength = 2)]
        public string TerminalCode { get; set; }

        [Required(ErrorMessage = "Please provide Desc Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be within 2 to 100 characters")]
        public string Desc { get; set; }
        
        [Required(ErrorMessage = "BrandId is must")]
       // [DataType(DataType.Currency)]
        [Range(1, 999, ErrorMessage = "Must be with range from 1 to 999")]
        public int BrandId { get; set; }
    }
}
