﻿namespace Telegram.Bot.Types;

/// <summary>This object represents an inline keyboard button that copies specified text to the clipboard.</summary>
public partial class CopyTextButton
{
    /// <summary>The text to be copied to the clipboard; 1-256 characters</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Text { get; set; } = default!;
}
