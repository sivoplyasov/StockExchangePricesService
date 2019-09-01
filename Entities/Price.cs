using System;
using System.ComponentModel.DataAnnotations;


namespace StockExchangePricesService.Entities
{
    public class Price
    {
        [Key]
        public int Id { get; set; }

        public double PriceValue { get; set; }

        public Company Company { get; set; }

        public DateTime Date { get; set; }

        public bool IsPredicted { get; set; }
    }
}
