using PublisherPlus.Compatibility;
using RimWorld;
using Verse;
using Verse.Steam;

namespace PublisherPlus.Patch
{
    internal static class Access
    {
        public static ModMetaData GetSelectedMod()
        {
            if (ModManager.Loaded) { return ModManager.GetSelectedMod() ?? throw new Mod.Exception("Error getting selected mod from ModManager"); }
            return Find.WindowStack.WindowOfType<Page_ModsConfig>()?.selectedMod ?? throw new Mod.Exception("Error getting selected mod");
        }
    }
}
