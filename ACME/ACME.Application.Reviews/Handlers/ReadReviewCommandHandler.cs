using ACME.Domain.Reviews.Entities;
using ACME.Domain.Reviews.Repositories;
using ACME.Application.Reviews.Commands;
using MediatR;

namespace ACME.Application.Reviews.Handlers;

public class ReadReviewCommandHandler : IRequestHandler<ReadReviewCommand, Review>
{
    private readonly IReviewReadRepository _repository;

    public ReadReviewCommandHandler(IReviewReadRepository repository)
    {
        _repository = repository;
    }

    public async Task<Review> Handle(ReadReviewCommand request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}
