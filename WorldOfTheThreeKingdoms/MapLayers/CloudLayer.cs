using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameGlobal;
using GameObjects;
using Microsoft.Xna.Framework;
using WorldOfTheThreeKingdoms;
using Microsoft.Xna.Framework.Graphics;
using GameManager;

namespace WorldOfTheThreeKingdoms.GameScreens.ScreenLayers
{
    public class CloudLayer
    {
        //Vector2[] vecs = new Vector2[] {
        //    new Vector2(230, 150),
        //    new Vector2(90, 150),
        //    new Vector2(-90, 150),
        //    new Vector2(230, 60),
        //    new Vector2(90, 60),
        //    new Vector2(-90, 60),
        //    new Vector2(230, -90),
        //    new Vector2(90, -90),
        //    new Vector2(-90, -90) };

        Vector2[] vecs = new Vector2[] {
            new Vector2(230 + 350, 150 + 200),   //右下
            new Vector2(90 + 250, 150 + 250),    //中下
            new Vector2(-90 - 200, 150 + 250),   //左下
            new Vector2(230 + 350, 60 + 150),    //右中
            new Vector2(90 + 200, 60 + 150),     //中中
            new Vector2(-90 - 200, 60 + 150),    //左中
            new Vector2(230 + 350, -90 - 100),   //右上
            new Vector2(90 + 200, -90 - 100),    //中上
            new Vector2(-90 - 200, -90 - 100) }; //左上

        Vector2[] vecsReal = null;

        float cloudAlpha = 1f;

        float elapsedTime = 0f;

        Vector2 scale;

        public bool IsVisible = false;

        public bool IsStart = false;

        public CloudLayer()
        {
            scale = new Vector2(Convert.ToSingle(Session.ResolutionX) / 800f, Convert.ToSingle(Session.ResolutionY) / 480f);
        }

        public void Start()
        {
            cloudAlpha = 1f;
            elapsedTime = 0f;
            IsVisible = true;
            vecsReal = new Vector2[] {
            new Vector2(230 + 350, 150 + 200),   //右下
            new Vector2(90 + 250, 150 + 250),    //中下
            new Vector2(-90 - 200, 150 + 250),   //左下
            new Vector2(230 + 350, 60 + 150),    //右中
            new Vector2(90 + 200, 60 + 150),     //中中
            new Vector2(-90 - 200, 60 + 150),    //左中
            new Vector2(230 + 350, -90 - 100),   //右上
            new Vector2(90 + 200, -90 - 100),    //中上
            new Vector2(-90 - 200, -90 - 100) }; //左上
        }

        public void Update(float gameTime)
        {
            if (IsVisible && IsStart)
            {
                elapsedTime += gameTime;

                float elapsedTime2 = elapsedTime < 1f ? elapsedTime : 1f;

                cloudAlpha = 1 - elapsedTime2;

                for (int i = 0; i < vecsReal.Length; i++)
                {
                    var vec = vecs[i];

                    if (i <= 2)
                    {
                        vecsReal[i] = vec + new Vector2(0, 391f * elapsedTime2 / 2f);
                    }
                    else if (i == 3)
                    {
                        vecsReal[i] = vec + new Vector2(665f * elapsedTime2 / 2f, 0);
                    }
                    else if (i == 4)
                    {

                    }
                    else if (i == 5)
                    {
                        vecsReal[i] = vec + new Vector2(-665f * elapsedTime2 / 2f, 0);
                    }
                    else
                    {
                        vecsReal[i] = vec + new Vector2(0, -391f * elapsedTime2 / 2f);
                    }

                }
                if (cloudAlpha <= 0)
                {
                    IsStart = false;
                }
            }
        }

        public void Draw()
        {
            if (IsVisible)
            {
                float depth = 0.798f;

                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[0], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[0], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[0], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[0], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[0], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[0], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);


                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[1], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[1], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[1], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[1], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[1], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[1], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);


                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[2], null, Color.White * cloudAlpha, SpriteEffects.None, Vector2.One, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[2], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[2], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[2], null, Color.White * cloudAlpha, SpriteEffects.None, Vector2.One, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[2], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[2], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);


                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[3], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);


                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[4], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[4], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[4], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[4], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[4], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[4], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);


                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[5], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[5], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[5], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[5], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[5], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[5], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[5], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);


                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[6], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[6], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[6], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[6], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[6], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[6], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[6], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);

                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[7], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[7], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[7], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[7], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[7], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[7], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);

                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud1", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud2", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud3", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud4", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud5", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
                CacheManager.Draw(@"Content\Textures\Resources\Start\Cloud6", vecsReal[8], null, Color.White * cloudAlpha, SpriteEffects.None, scale, depth);
            }
        }

    }

}
