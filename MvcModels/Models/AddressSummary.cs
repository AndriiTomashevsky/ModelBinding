using Microsoft.AspNetCore.Mvc;

namespace MvcModels.Models
{
    [Bind(nameof(City))]
    public class AddressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}
