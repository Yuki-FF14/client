using Dalamud.Interface.Utility;
using Dalamud.Interface.Utility.Raii;
using GagSpeak.PlayerData.Data;
using GagSpeak.PlayerData.Pairs;
using GagSpeak.Services;
using GagSpeak.Services.Mediator;
using GagSpeak.CkCommons.Gui.Components;
using GagSpeak.CkCommons.Gui.MainWindow;
using GagSpeak.UpdateMonitoring;
using GagSpeak.WebAPI;
using ImGuiNET;
using OtterGui;

namespace GagSpeak.CkCommons.Gui.Permissions;

public partial class PairStickyUI : WindowMediatorSubscriberBase
{
    private readonly PermissionData _permData;
    private readonly PermissionsDrawer _drawer;
    private readonly PairCombos _pairCombos;
    private readonly PresetLogicDrawer _presets;

    private readonly MainHub _hub;
    private readonly GlobalData _globals;
    private readonly PairManager _pairs;
    private readonly ClientMonitor _monitor;

    public PairStickyUI(ILogger<PairStickyUI> logger, GagspeakMediator mediator, Pair pair,
        StickyWindowType drawType, PermissionData permData, PermissionsDrawer permDrawer,
        PairCombos combos, PresetLogicDrawer presets, MainHub hub, GlobalData globals,
        PiShockProvider shocks, PairManager pairs, ClientMonitor monitor)
        : base(logger, mediator, "PairStickyUI for " + pair.UserData.UID + "pair.")
    {
        _permData = permData;
        _drawer = permDrawer;
        _pairCombos = combos;
        _presets = presets;
        _hub = hub;
        _globals = globals;
        _pairs = pairs;
        _monitor = monitor;

        Flags = WFlags.NoCollapse | WFlags.NoTitleBar | WFlags.NoResize | WFlags.NoScrollbar;
        IsOpen = true;

        // Define the pair and window type.
        SPair = pair;
        DrawType = drawType;

        // Publish a mediator event to let us know a new pair was made for the stickyUI.
        Mediator.Publish(new StickyPairWindowCreated(pair));
        PairCombos.Opened = InteractionType.None;
    }

    public Pair SPair { get; init; }
    public StickyWindowType DrawType = StickyWindowType.None;
    private float WindowMenuWidth = -1;

    protected override void PreDrawInternal()
    {
        // Magic that makes the sticky pair window move with the main UI.
        var position = MainUI.LastPos;
        position.X += MainUI.LastSize.X;
        position.Y += ImGui.GetFrameHeightWithSpacing();
        ImGui.SetNextWindowPos(position);

        Flags |= WFlags.NoMove;

        var width = (DrawType == StickyWindowType.PairPerms) ? 160 * ImGuiHelpers.GlobalScale : 110 * ImGuiHelpers.GlobalScale;
        var size = new Vector2(7 * ImGui.GetFrameHeight() + 3 * ImGui.GetStyle().ItemInnerSpacing.X + width, MainUI.LastSize.Y - ImGui.GetFrameHeightWithSpacing() * 2);
        ImGui.SetNextWindowSize(size);
    }

    protected override void DrawInternal()
    {
        WindowMenuWidth = ImGui.GetContentRegionAvail().X;

        switch (DrawType)
        {
            case StickyWindowType.PairPerms:
                ImGuiUtil.Center(PermissionData.DispName + "'s Permissions for You");
                ImGui.Separator();
                using (ImRaii.Child("PairPermsContent", new Vector2(0, ImGui.GetContentRegionAvail().Y), false, WFlags.NoScrollbar))
                    DrawPairPermsForClient();
                break;
            case StickyWindowType.ClientPermsForPair:
                ImGuiUtil.Center("Your Permissions for " + PermissionData.DispName);
                CkGui.SetCursorXtoCenter(225f);
                _presets.DrawPresetList(SPair, 225f);

                ImGui.Separator();
                using (ImRaii.Child("ClientPermsForPairContent", new Vector2(0, ImGui.GetContentRegionAvail().Y), false, WFlags.NoScrollbar))
                    DrawClientPermsForPair();
                break;
            case StickyWindowType.PairActionFunctions:
                using (ImRaii.Child("##StickyWinActs", new Vector2(0, ImGui.GetContentRegionAvail().Y), false, WFlags.NoScrollbar))
                    DrawPairActionFunctions();
                break;
        }
    }

    protected override void PostDrawInternal() { }

    public override void OnClose()
    {
        Mediator.Publish(new RemoveWindowMessage(this));

    }
}
