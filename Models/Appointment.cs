using System.ComponentModel.DataAnnotations;

namespace HW_ASP_8._3.Models
{
    public class Appointment
    {
        [Required(ErrorMessage = "Имя обязательно.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email обязателен.")]
        [EmailAddress(ErrorMessage = "Некорректный Email.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Номер телефона обязателен.")]
        [Phone(ErrorMessage = "Некорректный номер телефона.")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Причина приема обязательна.")]
        [StringLength(500, ErrorMessage = "Причина не должна превышать 500 символов.")]
        public string Reason { get; set; } = string.Empty;

        [Required(ErrorMessage = "Дата обязательна.")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required(ErrorMessage = "Время обязательно.")]
        [DataType(DataType.Time)]
        public TimeSpan AppointmentTime { get; set; }
    }
}
