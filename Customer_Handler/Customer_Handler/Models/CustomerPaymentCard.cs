using System;
namespace cqrs_Test.Domain.Entities
{
    public class CustomerPaymentCards
    { 
        public int id { get; set; }
        public int customer_id { get; set; }
        public string name_on_card { get; set; }
        public string exp_month { get; set; }
        public string exp_year { get; set; }
        public int postal_code { get; set; }
        public string credit_card_number { get; set; }
        public long created_at { get; set; } = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds);
        public long updated_at { get; set; } = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds);
    }
}
