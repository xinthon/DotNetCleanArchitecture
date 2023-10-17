using Application.Data;
using Domain.Products;
using MediatR;

namespace Application.Products.Create
{
    public sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly AppDbContext _dbContext;
        public CreateProductCommandHandler(AppDbContext dbContext ,IProductRepository productRepository, AppDbContext appDbContext)
        {
            _dbContext = dbContext;
            _productRepository = productRepository;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(new ProductId(Guid.NewGuid()), request.Name, request.Description);
            _productRepository.Add(product);
            await _dbContext.SaveChangesAsync();
        } 
    }
}
