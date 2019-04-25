﻿using Bit.Core.Enums;
using System;
using System.Collections.Generic;

namespace Bit.Core.Models.Response
{
    public class PushNotificationResponse
    {
        public NotificationType Type { get; set; }
        public string Payload { get; set; }
    }

    public class SyncCipherNotification
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }
        public HashSet<string> CollectionIds { get; set; }
        public DateTime RevisionDate { get; set; }
    }

    public class SyncFolderNotification
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime RevisionDate { get; set; }
    }

    public class UserNotification
    {
        public string UserId { get; set; }
        public DateTime Date { get; set; }
    }
}