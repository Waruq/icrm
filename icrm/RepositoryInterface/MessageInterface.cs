﻿using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using icrm.Models;
using PagedList;

namespace icrm.RepositoryInterface
{
    public interface MessageInterface
    {
       Message Save(Message message);
       List<Message> GetMessagesOnIds(ArrayList idList);
       Message UpdateMessage(int id);
       List<Message> getChatListOfHrWithLastMessage(string id);
       IPagedList<Message> getPagedMessages(int chatId,int Page);
    }
}