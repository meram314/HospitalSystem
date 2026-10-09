namespace WebApplication2.viewModels
{
    public class FilterProductVm
    {
        public string Name { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public bool HotDeals { get; set; }
        public int page { get; set; } = 1;
    }
}
