
using CommunityToolkit.Mvvm.ComponentModel;
using PediGo.Data.Entities;

namespace PediGo.Models
{
    public partial class CategoryModel : ObservableObject
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        [ObservableProperty]
        private bool _isSelected;

        // This is a Factory Method. Its job is to convert a Entity from database into a UI model (CategoryModel)
        // Why is Static?
            // Doesn't need a class instance to be called
            // Doesn't access instance members (with this)
            // It just recive a paramenter (Categories entity) and return a new CategoryModel
            // Doesn't depend of internal instance of CategoryModel class
            // It's a singular operation => transform a type into another type
        public static CategoryModel FromEntity(Categories entity) =>
            // new CategoryModel or new ()
            new ()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Icon = entity.Icon,
            };
    }
}
