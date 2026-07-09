using StardewModdingAPI;

namespace FashionSenseOutfitPreview;

/// <summary>
/// Thin wrapper around SMAPI's ITranslationHelper.
/// Call I18n.Init(helper.Translation) once in ModEntry.Entry(), then use the
/// static properties/methods anywhere in the mod.
/// </summary>
internal static class I18n
{
    private static ITranslationHelper _t = null!;

    public static void Init(ITranslationHelper translation) => _t = translation;

    private static string Get(string key) => _t.Get(key);
    private static string Get(string key, object tokens) => _t.Get(key, tokens);

    // UI
    public static string Title                => Get("ui.title");
    public static string Preview              => Get("ui.preview");
    public static string SearchPlaceholder    => Get("ui.search.placeholder");

    // Buttons
    public static string ButtonExpand         => Get("ui.button.expand");
    public static string ButtonClose          => Get("ui.button.close");
    public static string ButtonEquip          => Get("ui.button.equip");
    public static string ButtonAll            => Get("ui.button.all");
    public static string ButtonCategory       => Get("ui.button.category");
    public static string ButtonTags           => Get("ui.button.tags");
    public static string ButtonColors         => Get("ui.button.colors");
    public static string ButtonCreateCategory => Get("ui.button.create_category");
    public static string ButtonSelect         => Get("ui.button.select");
    public static string ButtonDeleteCategory => Get("ui.button.delete_category");
    public static string ButtonConfirm        => Get("ui.button.confirm");
    public static string ButtonCancel         => Get("ui.button.cancel");
    public static string ButtonDone           => Get("ui.button.done");
    public static string ButtonYes            => Get("ui.button.yes");
    public static string ButtonNo             => Get("ui.button.no");
    public static string ButtonRename         => Get("ui.button.rename");
    public static string ButtonEdit           => Get("ui.button.edit");
    public static string ButtonDeleteTag      => Get("ui.button.delete_tag");
    public static string ButtonDeleteColor    => Get("ui.button.delete_color");
    public static string ButtonDeleteOutfits  => Get("ui.button.delete_outfits");
    public static string ButtonNone           => Get("ui.button.none");

    // Modal
    public static string ModalNewCategory     => Get("ui.modal.new_category");
    public static string ModalDefaultCategory => Get("ui.modal.default_category");

    // Assign mode
    public static string AssignInstruction(string categoryName)
        => Get("ui.assign.instruction", new { categoryName });

    // Confirm modals
    public static string ConfirmDeleteCategoryTitle => Get("ui.confirm.delete_category.title");
    public static string ConfirmDeleteCategoryMsg   => Get("ui.confirm.delete_category.msg");
    public static string ConfirmRemoveOutfitsTitle  => Get("ui.confirm.remove_outfits.title");
    public static string ConfirmRemoveOutfitsMsg(int count)
        => Get("ui.confirm.remove_outfits.msg", new { count });
    public static string ConfirmDeleteSavedOutfitsTitle => Get("ui.confirm.delete_saved_outfits.title");
    public static string ConfirmDeleteSavedOutfitsMsg(int count)
        => Get("ui.confirm.delete_saved_outfits.msg", new { count });
    public static string ConfirmDeleteTagTitle      => Get("ui.confirm.delete_tag.title");
    public static string ConfirmDeleteTagMsg        => Get("ui.confirm.delete_tag.msg");
    public static string ConfirmDeleteColorTitle    => Get("ui.confirm.delete_color.title");
    public static string ConfirmDeleteColorMsg      => Get("ui.confirm.delete_color.msg");

    // Empty states
    public static string EmptyCategory        => Get("ui.empty.category");
    public static string EmptySearch          => Get("ui.empty.search");

    // Errors
    public static string ErrorSelectFirst     => Get("ui.error.select_first");
    public static string ErrorNameEmpty       => Get("ui.error.name_empty");
    public static string ErrorNameTaken       => Get("ui.error.name_taken");
    public static string ErrorPresetsUnsupported => Get("ui.error.presets_unsupported");

    // Config
    public static string ConfigShortcutName        => Get("config.shortcut.name");
    public static string ConfigShortcutTooltip     => Get("config.shortcut.tooltip");
    public static string ConfigExpandShortcutName  => Get("config.expand_shortcut.name");
    public static string ConfigExpandShortcutTooltip => Get("config.expand_shortcut.tooltip");
    public static string ConfigExpandDefaultName    => Get("config.expand_default.name");
    public static string ConfigExpandDefaultTooltip => Get("config.expand_default.tooltip");

    // Tags
    public static string ButtonCreate         => Get("ui.button.create");
    public static string ButtonSaveCurrentStyle => Get("ui.button.save_current_style");
    public static string ButtonNewCategory    => Get("ui.button.new_category");
    public static string ButtonNewTag         => Get("ui.button.new_tag");
    public static string ButtonNewColorTag    => Get("ui.button.new_color_tag");
    public static string ButtonExportOrganization => Get("ui.button.export_organization");
    public static string ButtonImportOrganization => Get("ui.button.import_organization");
    public static string ModalNewTag          => Get("ui.modal.new_tag");
    public static string ModalNewColorTag     => Get("ui.modal.new_color_tag");
    public static string ModalSaveCurrentStyle => Get("ui.modal.save_current_style");
    public static string ModalRenameOutfit    => Get("ui.modal.rename_outfit");
    public static string ErrorTagNameEmpty    => Get("ui.error.tag_name_empty");
    public static string ErrorTagNameTaken    => Get("ui.error.tag_name_taken");
    public static string ErrorSaveOutfitFailed => Get("ui.error.save_outfit_failed");
    public static string ErrorRenameOutfitFailed => Get("ui.error.rename_outfit_failed");
    public static string ErrorOrganizationImportMissing => Get("ui.error.organization_import_missing");
    public static string MessageOrganizationExported => Get("ui.message.organization_exported");
    public static string MessageOrganizationImported => Get("ui.message.organization_imported");
    public static string AssignTagInstruction(string tagName)
        => Get("ui.assign.tag_instruction", new { tagName });

    // Advanced filter panel
    public static string ButtonAdvanced       => Get("ui.button.advanced");
    public static string ButtonClearFilters   => Get("ui.button.clear_filters");
    public static string SectionCategory      => Get("ui.section.category");
    public static string SectionTags          => Get("ui.section.tags");
    public static string SectionColors        => Get("ui.section.colors");
}
