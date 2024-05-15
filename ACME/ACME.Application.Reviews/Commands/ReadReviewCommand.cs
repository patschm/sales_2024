using ACME.Domain.Reviews.Entities;
using MediatR;

namespace ACME.Application.Reviews.Commands;

public record ReadReviewCommand(long Id) : IRequest<Review>;
