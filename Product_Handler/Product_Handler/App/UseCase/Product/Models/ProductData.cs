using System;
namespace cqrs_Test.Application.UseCase.Product.Models
{
    public class ProductData
    {
        public int id { get; set; }
        public int merhcant_id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public long created_at { get; set; }
        public long updated_at { get; set; }
    }
}
