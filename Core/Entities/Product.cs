namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public ProductTypes ProductTypes { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrands ProductBrands { get; set; }
        public int ProductBrandId { get; set; }


    }
}