using HarmonyLib;
using PublisherPlus.Data;
using Verse.Steam;

namespace PublisherPlus.Patch
{
    [HarmonyPatch(typeof(Workshop), nameof(Workshop.OnItemSubmitted))]
    internal static class Verse_Steam_Workshop_OnItemSubmitted
    {
        private static void Postfix() => WorkshopPackage.OnUploaded();
    }
}
