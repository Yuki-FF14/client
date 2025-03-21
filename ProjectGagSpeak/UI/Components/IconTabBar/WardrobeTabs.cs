using Dalamud.Interface;
using Dalamud.Interface.Utility;
using Dalamud.Interface.Utility.Raii;
using ImGuiNET;

namespace GagSpeak.UI.Components;

public class WardrobeTabs : IconTabBarBase<WardrobeTabs.SelectedTab>
{
    public enum SelectedTab
    {
        MyRestraints,
        MyRestrictions,
        MyGags,
        MyCursedLoot,
        MyModPresets,
    }

    public WardrobeTabs()
    {
        AddDrawButton(FontAwesomeIcon.DoorOpen, SelectedTab.MyRestraints, "Restraints" +
            "--SEP--Apply, Lock, Unlock, Remove, or Configure your various Restraints");

        AddDrawButton(FontAwesomeIcon.Ring, SelectedTab.MyRestrictions, "Restrictions" +
            "--SEP--Apply, Lock, Unlock, Remove, or Configure your various Restrictions");

        AddDrawButton(FontAwesomeIcon.CommentDots, SelectedTab.MyGags, "Gags" +
            "--SEP--Apply, Lock, Unlock, Remove, or Configure your various Gags");

        AddDrawButton(FontAwesomeIcon.Gem, SelectedTab.MyCursedLoot, "Cursed Loot" +
            "--SEP--Configure your Cursed Items, or manage the active Loot Pool.");

        AddDrawButton(FontAwesomeIcon.FileArchive, SelectedTab.MyModPresets, "Mod Presets" +
            "--SEP--Create configured Mod Presets for use in application as presets.");
    }

    public override void Draw(float availableWidth)
    {
        if (_tabButtons.Count == 0)
            return;
        
        using var btncolor = ImRaii.PushColor(ImGuiCol.Button, ImGui.ColorConvertFloat4ToU32(new(0, 0, 0, 0)));
        var spacing = ImGui.GetStyle().ItemSpacing;
        var buttonX = (availableWidth - (spacing.X * (_tabButtons.Count - 1))) / _tabButtons.Count;
        var buttonY = CkGui.IconButtonSize(FontAwesomeIcon.Pause).Y;
        var buttonSize = new Vector2(buttonX, buttonY);
        var drawList = ImGui.GetWindowDrawList();

        ImGuiHelpers.ScaledDummy(spacing.Y / 2f);

        foreach (var tab in _tabButtons)
            DrawTabButton(tab, buttonSize, spacing, drawList);

        // advance to the new line and dispose of the button color.
        ImGui.NewLine();
        btncolor.Dispose();

        ImGuiHelpers.ScaledDummy(3f);
        ImGui.Separator();
    }

}
