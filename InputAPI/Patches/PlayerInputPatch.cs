using HarmonyLib;

namespace InputAPI.Patches
{
    [HarmonyPatch(typeof(Player.PlayerInput))]
    internal class PlayerInputPatch
    {
        [HarmonyPatch(nameof(Player.PlayerInput.SampeInput))]
        [HarmonyPostfix]
        private static void SampeInput(Player player)
        {
            foreach(var moddedInputs in Plugin._inputs) //u gly.
            {
                moddedInputs.HandleKeys(player);
            }
        }
    }
}
