using WebApplication2.Models;

namespace WebApplication2.viewModels
{
    public class personVm
    {
        public IEnumerable<person> Persons { get; set; }
        public int count { get; set; }

    }
}
