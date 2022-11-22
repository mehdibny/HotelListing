using System.Collections;
using System.Collections.Generic;

namespace HotelListing.Data
{
    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ShortName { get; set; }
        public virtual IList<Hotel> Hotels { get; set; }

    }
}
