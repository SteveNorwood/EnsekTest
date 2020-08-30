using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnsekTest.Shared.Entities
{
    public class MeterReading
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Meter Reading Date & Time")]
        public DateTime MeterReadingDateTime { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 5)]
        [DisplayName("Meter Reading Value")]
        public string MeterReadValue { get; set; }

        #region Foreign Keys
        [Required]
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        [Required]
        public virtual Account Account { get; set; }
        #endregion
    }
}
