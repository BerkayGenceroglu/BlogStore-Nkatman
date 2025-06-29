using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.EntityLayer.Entities
{
    //3. Neden AppUser’ı IdentityDbContext’e parametre olarak verdik?
    //Bu sayede Identity sistemi, kendi oluşturduğu AspNetUsers tablosunu, senin yazdığın AppUser sınıfına göre yapılandırıyor.
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Desctiption { get; set; }
        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
