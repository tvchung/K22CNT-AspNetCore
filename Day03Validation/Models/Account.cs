using System.ComponentModel.DataAnnotations;

namespace Day03Validation.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name ="Họ và tên"),
            Required(ErrorMessage ="Họ và tên không để trống"),
            MinLength(6,ErrorMessage ="Họ tên ít nhất 6 ký tự"),
            MaxLength(25,ErrorMessage ="Họ tên tối đa 25 ký tự")
        ] 
        public string FullName { get; set; }

        [
            Display(Name ="Địa chỉ email"),
            Required(ErrorMessage ="Địa chỉ mail không được trống"),
            EmailAddress(ErrorMessage ="Email chưa đúng định dạng")
        ]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại không đúng định dạng - (xxx)-xxx-xxxx")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string Phone { get; set; }

        [Display(Name = "Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới tính")]
        public string Gender { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Mật khẩu ít nhất 6 ký tự")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$#^~!%*?&._-]).+$",
            ErrorMessage = "Mật khẩu phải có chữ hoa, chữ thường, số và ký tự đặc biệt")]
        public string Password { get; set; }

        [Display(Name = "Link Facebook cá nhân")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm http hoặc https, tên miền VD: https://facebook.com / deveduvn")]
        public string Facebook { get; set; }
    }
}
