﻿using MediatR;

namespace Dictionary.Common.Features.EntryVotes.Commands.Delete;

public sealed class DeleteEntryVoteCommandRequest : IRequest<bool>
{
    public Guid UserId { get; }
    public Guid EntryId { get; }

    public DeleteEntryVoteCommandRequest(Guid userId, Guid entryId)
    {
        UserId = userId;
        EntryId = entryId;
    }
}