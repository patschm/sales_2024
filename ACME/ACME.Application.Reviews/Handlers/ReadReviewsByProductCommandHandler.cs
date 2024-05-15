using ACME.Domain.Reviews.Entities;
using ACME.Domain.Reviews.Repositories;
using ACME.Application.Reviews.Commands;
using MediatR;

namespace ACME.Application.Reviews.Handlers;

public class ReadReviewsByProductCommandHandler : IRequestHandler<ReadReviewsByProductCommand, IEnumerable<Review>>
{
    private readonly IReviewReadRepository _repository;

    public ReadReviewsByProductCommandHandler(IReviewReadRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Review>> Handle(ReadReviewsByProductCommand request, CancellationToken cancellationToken)
    {
        return await _repository.GetByProductAsync(request.Product, request.Parameters);
    }
}
