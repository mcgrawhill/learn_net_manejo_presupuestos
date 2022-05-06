using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ManejoPresupuestos.Views.Validaciones;

namespace ManejoPresupuestos.Models
{
    public class TipoCuentaConValidacionesExtra: IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:50, MinimumLength =3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name = "Nombre del tipo cuenta")]
        //[PrimeraLetraMayuscula] 
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        /* Pruebas de otras validaciones por defecto */
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")]
        public string Email { get; set; }
        [Range(minimum:18, maximum:130, ErrorMessage = "El valor debe estar entre {1} {2}")]
        public int Edad { get; set; }
        [Url(ErrorMessage = "El campo debe ser una URL válida")]
        public string URL { get; set; }
        [CreditCard(ErrorMessage = "La tarjeta de crédito no es válida")]
        [Display(Name = "Tarjeta de crédito")]
        public string TarjetaDeCredito { get; set; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (Nombre != null && Nombre.Length > 0)
            {
                var primeraLetra = Nombre[0].ToString();

                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayúscula", new[] { nameof(Nombre)});
                }
            }
        }
    }
}
