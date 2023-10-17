using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.API.Exceptions;
using Application.Products.Create;
using Application.Products.Delete;
using Application.Products.Update;
using Application.Products.Get;
using Domain.Products;

namespace Web.API.Endpoints
{
    public class Products : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("products",  async ([FromBody] CreateProductCommand request, ISender sender) =>
            {
                await sender.Send(request);
                return Results.Ok();
            });

            app.MapDelete("products/{id:guid}", async (Guid Id, ISender sender) =>
            {
                try
                {
                    await sender.Send(new DeleteProductCommand(Id));
                    return Results.NoContent();
                } catch(ResourceNotFundException ex)
                {
                    return Results.NotFound(ex.Message);
                }
            });

            app.MapPut("products/{id:guid}", async (Guid Id, [FromBody] UpdateProductCommand request, ISender sender) =>
            {
                try
                {
                    await sender.Send(new UpdateProductCommand(Id, request.Name, request.Description));
                    return Results.NoContent();
                }
                catch (ResourceNotFundException ex)
                {
                    return Results.NotFound(ex.Message);
                }
            });

            app.MapGet("products/{id:guid}", async (Guid Id, ISender sender) =>
            {
                return Results.Ok(await sender.Send(new GetProductQuery(new ProductId(Id))));
            });
        }
    }
}
