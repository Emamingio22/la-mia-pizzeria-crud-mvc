using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;

namespace LaMiaPizzeria.Models
{
    public class Pizze
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }


        public Pizze(int id, string image, string name, string description, int price)
        {
            id = Id;
            image = Image;

        }

    }
}
