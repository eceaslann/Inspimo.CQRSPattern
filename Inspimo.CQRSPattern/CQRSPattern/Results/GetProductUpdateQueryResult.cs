namespace Inspimo.CQRSPattern.CQRSPattern.Results
{
    public class GetProductUpdateQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductStock { get; set; }
        public string ProductPrice { get; set; }
        public string ProductStatus { get; set; }
    }
}
