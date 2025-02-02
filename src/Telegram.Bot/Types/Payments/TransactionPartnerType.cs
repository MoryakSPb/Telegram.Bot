﻿namespace Telegram.Bot.Types.Payments;

/// <summary>Type of the transaction partner</summary>
[JsonConverter(typeof(EnumConverter<TransactionPartnerType>))]
public enum TransactionPartnerType
{
    /// <summary>Describes a withdrawal transaction with Fragment.<br/><br/><i>(<see cref="TransactionPartner"/> can be cast into <see cref="TransactionPartnerFragment"/>)</i></summary>
    Fragment = 1,
    /// <summary>Describes a transaction with a user.<br/><br/><i>(<see cref="TransactionPartner"/> can be cast into <see cref="TransactionPartnerUser"/>)</i></summary>
    User,
    /// <summary>Describes a transaction with an unknown source or recipient.<br/><br/><i>(<see cref="TransactionPartner"/> can be cast into <see cref="TransactionPartnerOther"/>)</i></summary>
    Other,
    /// <summary>Describes a withdrawal transaction to the Telegram Ads platform.<br/><br/><i>(<see cref="TransactionPartner"/> can be cast into <see cref="TransactionPartnerTelegramAds"/>)</i></summary>
    TelegramAds,
    /// <summary>Describes a transaction with payment for <a href="https://core.telegram.org/bots/api#paid-broadcasts">paid broadcasting</a>.<br/><br/><i>(<see cref="TransactionPartner"/> can be cast into <see cref="TransactionPartnerTelegramApi"/>)</i></summary>
    TelegramApi,
}
