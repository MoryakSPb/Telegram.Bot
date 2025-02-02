﻿namespace Telegram.Bot.Requests;

/// <summary>Use this method to get information about the connection of the bot with a business account.<para>Returns: A <see cref="BusinessConnection"/> object on success.</para></summary>
public partial class GetBusinessConnectionRequest() : RequestBase<BusinessConnection>("getBusinessConnection"), IBusinessConnectable
{
    /// <summary>Unique identifier of the business connection</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required string BusinessConnectionId { get; set; }
}
