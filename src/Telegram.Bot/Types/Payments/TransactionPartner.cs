﻿namespace Telegram.Bot.Types.Payments;

/// <summary>This object describes the source of a transaction, or its recipient for outgoing transactions. Currently, it can be one of<br/><see cref="TransactionPartnerUser"/>, <see cref="TransactionPartnerFragment"/>, <see cref="TransactionPartnerTelegramAds"/>, <see cref="TransactionPartnerTelegramApi"/>, <see cref="TransactionPartnerOther"/></summary>
[JsonConverter(typeof(PolymorphicJsonConverter<TransactionPartner>))]
[CustomJsonPolymorphic("type")]
[CustomJsonDerivedType(typeof(TransactionPartnerUser), "user")]
[CustomJsonDerivedType(typeof(TransactionPartnerFragment), "fragment")]
[CustomJsonDerivedType(typeof(TransactionPartnerTelegramAds), "telegram_ads")]
[CustomJsonDerivedType(typeof(TransactionPartnerTelegramApi), "telegram_api")]
[CustomJsonDerivedType(typeof(TransactionPartnerOther), "other")]
public abstract partial class TransactionPartner
{
    /// <summary>Type of the transaction partner</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public abstract TransactionPartnerType Type { get; }
}

/// <summary>Describes a transaction with a user.</summary>
public partial class TransactionPartnerUser : TransactionPartner
{
    /// <summary>Type of the transaction partner, always <see cref="TransactionPartnerType.User"/></summary>
    public override TransactionPartnerType Type => TransactionPartnerType.User;

    /// <summary>Information about the user</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public User User { get; set; } = default!;

    /// <summary><em>Optional</em>. Bot-specified invoice payload</summary>
    public string? InvoicePayload { get; set; }

    /// <summary><em>Optional</em>. Information about the paid media bought by the user</summary>
    public PaidMedia[]? PaidMedia { get; set; }

    /// <summary><em>Optional</em>. Bot-specified paid media payload</summary>
    public string? PaidMediaPayload { get; set; }
}

/// <summary>Describes a withdrawal transaction with Fragment.</summary>
public partial class TransactionPartnerFragment : TransactionPartner
{
    /// <summary>Type of the transaction partner, always <see cref="TransactionPartnerType.Fragment"/></summary>
    public override TransactionPartnerType Type => TransactionPartnerType.Fragment;

    /// <summary><em>Optional</em>. State of the transaction if the transaction is outgoing</summary>
    public RevenueWithdrawalState? WithdrawalState { get; set; }
}

/// <summary>Describes a withdrawal transaction to the Telegram Ads platform.</summary>
public partial class TransactionPartnerTelegramAds : TransactionPartner
{
    /// <summary>Type of the transaction partner, always <see cref="TransactionPartnerType.TelegramAds"/></summary>
    public override TransactionPartnerType Type => TransactionPartnerType.TelegramAds;
}

/// <summary>Describes a transaction with payment for <a href="https://core.telegram.org/bots/api#paid-broadcasts">paid broadcasting</a>.</summary>
public partial class TransactionPartnerTelegramApi : TransactionPartner
{
    /// <summary>Type of the transaction partner, always <see cref="TransactionPartnerType.TelegramApi"/></summary>
    public override TransactionPartnerType Type => TransactionPartnerType.TelegramApi;

    /// <summary>The number of successful requests that exceeded regular limits and were therefore billed</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public int RequestCount { get; set; }
}

/// <summary>Describes a transaction with an unknown source or recipient.</summary>
public partial class TransactionPartnerOther : TransactionPartner
{
    /// <summary>Type of the transaction partner, always <see cref="TransactionPartnerType.Other"/></summary>
    public override TransactionPartnerType Type => TransactionPartnerType.Other;
}
