using Inspimo.CQRSPattern.CQRSPattern.Commands;
using Inspimo.CQRSPattern.DAL;

namespace Inspimo.CQRSPattern.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.ProductName = command.ProductName;
            values.ProductBrand = command.ProductBrand;
            values.ProductStatus = command.ProductStatus;
            values.ProductPrice = command.ProductPrice;
            values.ProductStock = command.ProductStock;
            _context.SaveChanges();
        
        
        
        }
    }
}
