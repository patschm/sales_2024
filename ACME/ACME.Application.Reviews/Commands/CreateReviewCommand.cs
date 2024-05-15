using ACME.Domain.Reviews.Entities;
using MediatR;

namespace ACME.Application.Reviews.Commands;

public record CreateReviewCommand(Review Review) : IRequest;

