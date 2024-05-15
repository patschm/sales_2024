using ACME.Domain.Reviews.Entities;
using ACME.Domain.Reviews.ValueObjects;
using MediatR;

namespace ACME.Application.Reviews.Commands;

public record ReadReviewsByProductCommand(Product Product, ReviewParameters Parameters) :IRequest<IEnumerable<Review>>;

