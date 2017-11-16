using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcPracticumAutoverzekering.Models
{
    public class Claim
    {
        public int ID { get; set; }

        [Display(Name = "Klant")]
        public ApplicationUser Customer { get; set; }

        [Required]
        [Display(Name = "Kenteken")]
        public string LicensePlate { get; set; }

        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Omschrijving")]
        public string Description { get; set; }

        [Display(Name = "Datum")]
        public DateTime Date { get; set; }

        [Display(Name = "Status")]
        public StatusEnum Status { get; set; }

        [NotMapped]
        public string TitleShort
        {
            get
            {
                if (Title.Length < 30)
                {
                    return Title;
                }
                else
                {
                    return Title.Substring(0, 30);
                }
            }
        }

        [NotMapped]
        public string DescriptionShort
        {
            get
            {
                if (Description.Length < 40)
                {
                    return Description;
                }
                else
                {
                    return Description.Substring(0, 40);
                }
            }
        }

        public Claim()
        {
            Date = DateTime.Now;
            Status = StatusEnum.New;
        }
    }

    public enum StatusEnum
    {
        [Display (Name = "Nieuw")]
        New,
        [Display (Name = "In behandeling")]
        Processing,
        [Display(Name = "Goedgekeurd")]
        Approved,
        [Display(Name = "In behandeling")]
        Rejected
    }
}