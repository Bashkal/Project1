using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCEgitimi.Models
{
    public class Uye
    {

        public int Id { get; set;
        }
        [Required]
        public string Ad { get; set;
        }
        [Required]
        public string Soyad { get; set;
        }
        [Required, DataType(DataType.EmailAddress)]
        [EmailAddress()]
        [DisplayName("E-Posta Adresi")]
        public string Eposta { get; set;
        }
        [DisplayName("Kullanıcı Adı")]
       
        public string KullaniciAdi { get; set;
        }
        [Required, DisplayName("TC Kimlik Numarası")]
        [MinLength(11,ErrorMessage ="TC Kimlik Numarası En az 11 Haneli Olmalıdır")]
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası En Fazla 11 Haneli Olmalıdır")]
        public string TcKimlikNo { get; set;
        }
        public string Telefon { get; set;
        }
        [Required,StringLength(100,MinimumLength =10,ErrorMessage ="Şİfreniz 10 ile 100 karakter arasında olmalı")]
        [DataType(DataType.Password),DisplayName("Şifre")]
        public string Sifre { get; set;
        }
        [Required]
        [DataType(DataType.Password), DisplayName("Şifre Tekrarı")]
        [Compare("Sifre", ErrorMessage = "Şifreler Eşleşmiyor")]
        public string SifreTekrar { get; set;
        }
        [Required, DisplayName("Doğum Tarihi"),DisplayFormat(DataFormatString ="{0:dd.MM.yy}")]
        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set;}

    }
}