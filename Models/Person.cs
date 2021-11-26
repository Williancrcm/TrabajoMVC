using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace papas.Models
{
    
    public class Person
    {
        //definir propiedades
        [Key]
        public int PersonID {get; set;}

         [Required(ErrorMessage ="El nombre es requerido")]
        [Display(Name ="nombre")]
        public string Nombre {get; set;}

         [Required(ErrorMessage ="El apellido es requerido")]
         [Display(Name ="Apellido")]
        public string Apellido {get; set;}

        [Required(ErrorMessage ="El Genero es requerido")]
         [Display(Name ="Genero")]
        public string Genero {get; set;}

         [Required(ErrorMessage ="La edad es requerida")]
        [Display(Name ="Edad")]
        public string Edad {get; set;}

         [Required(ErrorMessage ="La dirección es requerida")]
        [Display(Name ="Dirección")]
        [StringLength (100)]
        public string Direccion {get; set;}

       public ICollection<Catalogo> Catalogos {get; set; } =new List<Catalogo>();

    }
}