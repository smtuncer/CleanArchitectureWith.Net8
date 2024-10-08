﻿using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Register;

public sealed record RegisterCommand(
    string Email,
    string UserName,
    string FirstName,
    string LastName,
    string Password) : IRequest<Result<string>>;
