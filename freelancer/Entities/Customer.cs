using freelancer.Abstract;
using freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancer.Entities
{
    public class Customer : Person<Guid>, ICsvConvertible
    {
        public string PhoneNumber { get; set; }

        public string GetValuesCSV()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{PhoneNumber}";

        }

        public void SetValuesCSV(string csv)
        {
            throw new NotImplementedException();
        }
    }
}
