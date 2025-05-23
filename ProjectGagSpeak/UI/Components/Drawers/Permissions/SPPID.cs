using GagspeakAPI.Data.Permissions;

namespace GagSpeak.CkCommons.Gui.Components;

/// <summary> Sticky Pair Permission ID </summary>
public enum SPPID : byte
{
    ChatGarblerActive,
    ChatGarblerLocked,
    LockToyboxUI,

    PermanentLocks,
    OwnerLocks,
    DevotionalLocks,

    GagVisuals,
    ApplyGags,
    LockGags,
    MaxGagTime,
    UnlockGags,
    RemoveGags,

    RestrictionVisuals,
    ApplyRestrictions,
    LockRestrictions,
    MaxRestrictionTime,
    UnlockRestrictions,
    RemoveRestrictions,

    RestraintSetVisuals,
    ApplyRestraintSets,
    LockRestraintSets,
    MaxRestraintTime,
    UnlockRestraintSets,
    RemoveRestraintSets,

    PuppetPermSit,
    PuppetPermEmote,
    PuppetPermAlias,
    PuppetPermAll,

    ApplyPositive,
    ApplyNegative,
    ApplySpecial,
    ApplyPairsMoodles,
    ApplyOwnMoodles,
    MaxMoodleTime,
    PermanentMoodles,
    RemoveMoodles,

    ToyControl,
    PatternStarting,
    PatternStopping,
    AlarmToggling,
    TriggerToggling,

    HardcoreModeState,
    PairLockedStates,
    ForcedFollow,
    ForcedEmoteState,
    ForcedStay,
    ChatBoxesHidden,
    ChatInputHidden,
    ChatInputBlocked,
    GarbleChannelEditing,

    PiShockShareCode,
    MaxVibrateDuration,
}

public static class SPPIDExtensions
{
    public static (string name, PermissionType type) ToPermValue(this SPPID perm)
        => perm switch
        {
            SPPID.ChatGarblerActive     => (nameof(UserGlobalPermissions.ChatGarblerActive),            PermissionType.Global),
            SPPID.ChatGarblerLocked     => (nameof(UserGlobalPermissions.ChatGarblerLocked),            PermissionType.Global),
            SPPID.LockToyboxUI          => (nameof(UserGlobalPermissions.LockToyboxUI),                 PermissionType.Global),

            SPPID.PermanentLocks        => (nameof(UserPairPermissions.PermanentLocks),                 PermissionType.UniquePairPerm),
            SPPID.OwnerLocks            => (nameof(UserPairPermissions.OwnerLocks),                     PermissionType.UniquePairPerm),
            SPPID.DevotionalLocks       => (nameof(UserPairPermissions.DevotionalLocks),                PermissionType.UniquePairPerm),

            SPPID.GagVisuals            => (nameof(UserGlobalPermissions.GagVisuals),                   PermissionType.Global),
            SPPID.ApplyGags             => (nameof(UserPairPermissions.ApplyGags),                      PermissionType.UniquePairPerm),
            SPPID.LockGags              => (nameof(UserPairPermissions.LockGags),                       PermissionType.UniquePairPerm),
            SPPID.MaxGagTime            => (nameof(UserPairPermissions.MaxGagTime),                     PermissionType.UniquePairPerm),
            SPPID.UnlockGags            => (nameof(UserPairPermissions.UnlockGags),                     PermissionType.UniquePairPerm),
            SPPID.RemoveGags            => (nameof(UserPairPermissions.RemoveGags),                     PermissionType.UniquePairPerm),

            SPPID.RestrictionVisuals    => (nameof(UserGlobalPermissions.RestrictionVisuals),           PermissionType.Global),
            SPPID.ApplyRestrictions     => (nameof(UserPairPermissions.ApplyRestrictions),              PermissionType.UniquePairPerm),
            SPPID.LockRestrictions      => (nameof(UserPairPermissions.LockRestrictions),               PermissionType.UniquePairPerm),
            SPPID.MaxRestrictionTime    => (nameof(UserPairPermissions.MaxRestrictionTime),             PermissionType.UniquePairPerm),
            SPPID.UnlockRestrictions    => (nameof(UserPairPermissions.UnlockRestrictions),             PermissionType.UniquePairPerm),
            SPPID.RemoveRestrictions    => (nameof(UserPairPermissions.RemoveRestrictions),             PermissionType.UniquePairPerm),

            SPPID.RestraintSetVisuals   => (nameof(UserGlobalPermissions.RestraintSetVisuals),          PermissionType.Global),
            SPPID.ApplyRestraintSets    => (nameof(UserPairPermissions.ApplyRestraintSets),             PermissionType.UniquePairPerm),
            SPPID.LockRestraintSets     => (nameof(UserPairPermissions.LockRestraintSets),              PermissionType.UniquePairPerm),
            SPPID.MaxRestraintTime      => (nameof(UserPairPermissions.MaxRestraintTime),               PermissionType.UniquePairPerm),
            SPPID.UnlockRestraintSets   => (nameof(UserPairPermissions.UnlockRestraintSets),            PermissionType.UniquePairPerm),
            SPPID.RemoveRestraintSets   => (nameof(UserPairPermissions.RemoveRestraintSets),            PermissionType.UniquePairPerm),

            SPPID.PuppetPermSit         => (nameof(UserPairPermissions.PuppetPerms),                    PermissionType.UniquePairPerm),
            SPPID.PuppetPermEmote       => (nameof(UserPairPermissions.PuppetPerms),                    PermissionType.UniquePairPerm),
            SPPID.PuppetPermAlias       => (nameof(UserPairPermissions.PuppetPerms),                    PermissionType.UniquePairPerm),
            SPPID.PuppetPermAll         => (nameof(UserPairPermissions.PuppetPerms),                    PermissionType.UniquePairPerm),

            SPPID.ApplyPositive         => (nameof(UserPairPermissions.MoodlePerms),                    PermissionType.UniquePairPerm),
            SPPID.ApplyNegative         => (nameof(UserPairPermissions.MoodlePerms),                    PermissionType.UniquePairPerm),
            SPPID.ApplySpecial          => (nameof(UserPairPermissions.MoodlePerms),                    PermissionType.UniquePairPerm),
            SPPID.ApplyPairsMoodles     => (nameof(UserPairPermissions.MoodlePerms),                    PermissionType.UniquePairPerm),
            SPPID.ApplyOwnMoodles       => (nameof(UserPairPermissions.MoodlePerms),                    PermissionType.UniquePairPerm),
            SPPID.MaxMoodleTime         => (nameof(UserPairPermissions.MaxMoodleTime),                  PermissionType.UniquePairPerm),
            SPPID.RemoveMoodles         => (nameof(UserPairPermissions.MoodlePerms),                    PermissionType.UniquePairPerm),

            SPPID.ToyControl            => (nameof(UserPairPermissions.RemoteControlAccess),            PermissionType.UniquePairPerm),
            SPPID.PatternStarting       => (nameof(UserPairPermissions.ExecutePatterns),                PermissionType.UniquePairPerm),
            SPPID.PatternStopping       => (nameof(UserPairPermissions.StopPatterns),                   PermissionType.UniquePairPerm),
            SPPID.AlarmToggling         => (nameof(UserPairPermissions.ToggleAlarms),                   PermissionType.UniquePairPerm),
            SPPID.TriggerToggling       => (nameof(UserPairPermissions.ToggleTriggers),                 PermissionType.UniquePairPerm),

            SPPID.HardcoreModeState     => (nameof(UserPairPermissions.InHardcore),                     PermissionType.UniquePairPerm),
            SPPID.PairLockedStates      => (nameof(UserPairPermissions.PairLockedStates),               PermissionType.UniquePairPerm),
/*          SPPID.ForcedFollow          => (nameof(UserGlobalPermissions.ForcedFollow),                 PermissionType.Global),
            SPPID.ForcedEmoteState      => (nameof(UserGlobalPermissions.ForcedEmoteState),             PermissionType.Global),
            SPPID.ForcedStay            => (nameof(UserGlobalPermissions.ForcedStay),                   PermissionType.Global),
            SPPID.ChatBoxesHidden       => (nameof(UserGlobalPermissions.ChatBoxesHidden),              PermissionType.Global),
            SPPID.ChatInputHidden       => (nameof(UserGlobalPermissions.ChatInputHidden),              PermissionType.Global),
            SPPID.ChatInputBlocked      => (nameof(UserGlobalPermissions.ChatInputBlocked),             PermissionType.Global),
            SPPID.GarbleChannelEditing  => (nameof(UserGlobalPermissions.ChatGarblerChannelsBitfield),  PermissionType.Global),*/
            SPPID.PiShockShareCode      => (nameof(UserPairPermissions.PiShockShareCode),               PermissionType.UniquePairPerm),
            SPPID.MaxVibrateDuration    => (nameof(UserPairPermissions.MaxVibrateDuration),             PermissionType.UniquePairPerm),

            _ => (string.Empty, PermissionType.Global)
        };

        public static string ToPermAccessValue(this SPPID perm, bool isAllEmote = false)
        => perm switch
        {
            SPPID.ChatGarblerActive     => nameof(UserEditAccessPermissions.ChatGarblerActiveAllowed),
            SPPID.ChatGarblerLocked     => nameof(UserEditAccessPermissions.ChatGarblerLockedAllowed),
            SPPID.LockToyboxUI          => nameof(UserEditAccessPermissions.LockToyboxUIAllowed),
            SPPID.PermanentLocks        => nameof(UserEditAccessPermissions.PermanentLocksAllowed),
            SPPID.OwnerLocks            => nameof(UserEditAccessPermissions.OwnerLocksAllowed),
            SPPID.DevotionalLocks       => nameof(UserEditAccessPermissions.DevotionalLocksAllowed),
            SPPID.GagVisuals            => nameof(UserEditAccessPermissions.GagVisualsAllowed),
            SPPID.ApplyGags             => nameof(UserEditAccessPermissions.ApplyGagsAllowed),
            SPPID.LockGags              => nameof(UserEditAccessPermissions.LockGagsAllowed),
            SPPID.MaxGagTime            => nameof(UserEditAccessPermissions.MaxGagTimeAllowed),
            SPPID.UnlockGags            => nameof(UserEditAccessPermissions.UnlockGagsAllowed),
            SPPID.RemoveGags            => nameof(UserEditAccessPermissions.RemoveGagsAllowed),
            SPPID.RestrictionVisuals    => nameof(UserEditAccessPermissions.RestrictionVisualsAllowed),
            SPPID.ApplyRestrictions     => nameof(UserEditAccessPermissions.ApplyRestrictionsAllowed),
            SPPID.LockRestrictions      => nameof(UserEditAccessPermissions.LockRestrictionsAllowed),
            SPPID.MaxRestrictionTime    => nameof(UserEditAccessPermissions.MaxRestrictionTimeAllowed),
            SPPID.UnlockRestrictions    => nameof(UserEditAccessPermissions.UnlockRestrictionsAllowed),
            SPPID.RemoveRestrictions    => nameof(UserEditAccessPermissions.RemoveRestrictionsAllowed),
            SPPID.RestraintSetVisuals   => nameof(UserEditAccessPermissions.RestraintSetVisualsAllowed),
            SPPID.ApplyRestraintSets    => nameof(UserEditAccessPermissions.ApplyRestraintSetsAllowed),
            SPPID.LockRestraintSets     => nameof(UserEditAccessPermissions.LockRestraintSetsAllowed),
            SPPID.MaxRestraintTime      => nameof(UserEditAccessPermissions.MaxRestraintTimeAllowed),
            SPPID.UnlockRestraintSets   => nameof(UserEditAccessPermissions.UnlockRestraintSetsAllowed),
            SPPID.RemoveRestraintSets   => nameof(UserEditAccessPermissions.RemoveRestraintSetsAllowed),
            SPPID.PuppetPermSit         => nameof(UserEditAccessPermissions.PuppetPermsAllowed),
            SPPID.PuppetPermEmote       => nameof(UserEditAccessPermissions.PuppetPermsAllowed),
            SPPID.PuppetPermAlias       => nameof(UserEditAccessPermissions.PuppetPermsAllowed),
            SPPID.PuppetPermAll         => nameof(UserEditAccessPermissions.PuppetPermsAllowed),
            SPPID.ApplyPositive         => nameof(UserEditAccessPermissions.MoodlePermsAllowed),
            SPPID.ApplyNegative         => nameof(UserEditAccessPermissions.MoodlePermsAllowed),
            SPPID.ApplySpecial          => nameof(UserEditAccessPermissions.MoodlePermsAllowed),
            SPPID.ApplyPairsMoodles     => nameof(UserEditAccessPermissions.MoodlePermsAllowed),
            SPPID.ApplyOwnMoodles       => nameof(UserEditAccessPermissions.MoodlePermsAllowed),
            SPPID.MaxMoodleTime         => nameof(UserEditAccessPermissions.MaxMoodleTimeAllowed),
            SPPID.PermanentMoodles      => nameof(UserEditAccessPermissions.MoodlePermsAllowed),
            SPPID.RemoveMoodles         => nameof(UserEditAccessPermissions.MoodlePermsAllowed),
            SPPID.ToyControl            => nameof(UserEditAccessPermissions.RemoteControlAccessAllowed),
            SPPID.PatternStarting       => nameof(UserEditAccessPermissions.ExecutePatternsAllowed),
            SPPID.PatternStopping       => nameof(UserEditAccessPermissions.StopPatternsAllowed),
            SPPID.AlarmToggling         => nameof(UserEditAccessPermissions.ToggleAlarmsAllowed),
            SPPID.TriggerToggling       => nameof(UserEditAccessPermissions.ToggleTriggersAllowed),

            SPPID.ForcedFollow          => nameof(UserPairPermissions.AllowForcedFollow),
            SPPID.ForcedEmoteState      => isAllEmote ? nameof(UserPairPermissions.AllowForcedEmote) : nameof(UserPairPermissions.AllowForcedEmote),
            SPPID.ForcedStay            => nameof(UserPairPermissions.AllowForcedStay),
            SPPID.ChatBoxesHidden       => nameof(UserPairPermissions.AllowHidingChatBoxes),
            SPPID.ChatInputHidden       => nameof(UserPairPermissions.AllowHidingChatInput),
            SPPID.ChatInputBlocked      => nameof(UserPairPermissions.AllowChatInputBlocking),
            SPPID.GarbleChannelEditing  => nameof(UserPairPermissions.AllowGarbleChannelEditing),
            _ => string.Empty
        };
}
