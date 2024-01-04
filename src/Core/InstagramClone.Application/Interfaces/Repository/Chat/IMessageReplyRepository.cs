﻿using InstagramClone.Application.Interfaces.Repository.Common;
using InstagramClone.Domain.Entities.Chat;

namespace InstagramClone.Application.Interfaces.Repository.Chat
{
    public interface IMessageReplyRepository : IRepository<MessageReply, Guid>;
}