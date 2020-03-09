using System;
namespace cqrs_Test.Domain.Entities
{
    
        public enum kelamin
        {
            male = 1,
            female,
            transexual_male,
            transexual_female,
            Metrosexual_male,
            Metrosexual_female,
            male_but_curious_what_being_female_is_like,
            female_but_curious_what_being_male_is_like

        }


        public class Customers
        {
            public int id { get; set; }
            public string full_name { get; set; }
            public string username { get; set; }
            public DateTime birthdate { get; set; }
            public string password { get; set; }
            public kelamin gender { get; set; }
            public string sex { get; set; }
            public string email { get; set; }
            public string phone_number { get; set; }
            public long created_at { get; set; } = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds);
            public long updated_at { get; set; } = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds);
        }
    
}
