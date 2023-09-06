using System.ComponentModel.DataAnnotations;

namespace Cascading_Dropdown_List.Models.Cascade
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
