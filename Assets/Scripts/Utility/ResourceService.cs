using UnityEngine;

namespace Utility
{
    public static class SpriteService 
    {
        private static SpriteReplaceSo spriteReplaceSo;
        private static void LoadSpriteReplaceSO()
        {
            spriteReplaceSo = Resources.Load<SpriteReplaceSo>(Constants.SPRITE_REPLACE_SO_PATH);
        }
        public static Sprite LoadItemNormalSprite(NormalItem.eNormalType normalType)
        {
            if (spriteReplaceSo == null)
                LoadSpriteReplaceSO();
            return spriteReplaceSo.GetNormalItemSprite(normalType);
        }
        public static Sprite LoadBonusItemSprite(BonusItem.eBonusType bonusType)
        {
            if (!spriteReplaceSo)
                LoadSpriteReplaceSO();
            return spriteReplaceSo.GetBonusItemSprite(bonusType);
        }
    }
}