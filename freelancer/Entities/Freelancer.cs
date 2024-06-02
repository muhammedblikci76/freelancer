using freelancer.Abstract;
using freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancer.Entities
{
    public class Freelancer:Person<Guid>, ICsvConvertible
    {
        public string WorkExperience { get; set; }
        public List<Review> Reviews { get; set;}
        public string GetValuesCSV()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{WorkExperience}";

        }

        //f9114cfe-0f89-43db-9da6-8295cb581158,2.06.2024 13:51:17 +03:00,gökhan,ÖVSENE,ıd3
       
        public void SetValuesCSV( string csvLine)
        {
            string[] data= csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName= data[3];
            WorkExperience = data[4];
        }
    }
}
