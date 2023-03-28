using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Service.model
{
    public class VehicleModel
    {
        public int Id { get; set; }

        [ForeignKey("VMake")]
        public int VehicleMakeId { get; set; }
        public string? Name { get; set; }
        public string? Abrv { get; set; }

        public virtual VehicleMake? VMake { get; set; }
    }
}
