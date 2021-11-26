using System;
using System.ComponentModel.DataAnnotations;

namespace papas.Models
{
    
    public class Catalogo
    {
        [Key]
        public int CatalogoID{get; set; }

        /// <sumary> 
        /// /Productos
        /// </sumary>
        /// <value></value>
        [Required(ErrorMessage ="El Productos es requerido")]
        [Display(Name ="Productos")]
        public string Productos {get; set; }
        /// <sumary> 
        /// /end Productos
        /// </sumary>
        /// <value></value>

        [Required(ErrorMessage ="El Ofertas es requerido")]
        [Display(Name ="Ofertas")]
        public string Ofertas {get; set; }

        [Required(ErrorMessage ="El Precios es requerido")]
        [Display(Name ="Precios")]
        public string Precios {get; set; }

        [Required(ErrorMessage ="El Descripcion es requerido")]
        [Display(Name ="Descripcion")]
        public string Descripcion {get; set; }

        //referencias para Person
        [Required(ErrorMessage ="El Person es requerido")] 
        [Display(Name ="Person")]
        public int PersonID {get; set; }
        public Person Persons {get; set; }

    }

}