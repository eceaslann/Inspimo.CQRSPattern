using Inspimo.CQRSPattern.CQRSPattern.Commands;
using Inspimo.CQRSPattern.DAL;

namespace Inspimo.CQRSPattern.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductBrand = command.ProductBrand,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
               
                ProductStock = command.ProductStock
            });
            _context.SaveChanges();
        }
    }
}
