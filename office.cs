namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class office
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int office_id { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(50)]
        public string state { get; set; }
    }
}
