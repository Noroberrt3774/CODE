using System.ComponentModel.DataAnnotations;

namespace actX.Models;

// Representa a un estudiante con los datos solicitados por el formulario
public class Estudiante
{
    // El nombre no puede quedar vacío
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = string.Empty;

    // El correo no puede quedar vacío y debe tener un formato válido
    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
    public string Correo { get; set; } = string.Empty;

    // La calificación debe estar en el rango de 0 a 10
    [Range(0, 10, ErrorMessage = "La calificación debe estar entre 0 y 10.")]
    public decimal Calificacion { get; set; }
}
