using MediatR;

namespace Application.Products.Update
{
    public sealed class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        public Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
