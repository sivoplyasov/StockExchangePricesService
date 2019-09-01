using System.ComponentModel.DataAnnotations;


namespace StockExchangePricesService.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
