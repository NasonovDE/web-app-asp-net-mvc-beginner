using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace KinoAfisha.Models
{
    public class Kino
    {
        /// <summary>
        /// Id
        /// </summary> 
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary> 
        [Required]
        [Display(Name = "Название", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// Цена
        /// </summary> 
        [Required]
        [Display(Name = "Цена", Order = 10)]
        public decimal Price { get; set; }

        /// <summary>
        /// Количество билетов
        /// </summary> 
        [Required]
        [Display(Name = "Количество билетов", Order = 20)]
        public int NumberOfBilets { get; set; }

        /// <summary>
        /// Место показа
        /// </summary> 
        [Required]
        [Display(Name = "Место показа", Order = 30)]
        public string Place{ get; set; }

        /// <summary>
        /// Дата
        /// </summary> 
        [Required]
        [Display(Name = "Дата", Order = 40)]
        public DateTime NextArrivalDate { get; set; }

        /// <summary>
        /// Дата создания записи
        /// </summary> 
        [ScaffoldColumn(false)]
        public DateTime CreateAt { get; set; }
    }
}