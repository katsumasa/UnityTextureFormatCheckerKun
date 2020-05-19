using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UTJ
{
    public class UnityTextureFormatCheckerKun : MonoBehaviour
    {
        [SerializeField] Text text;
        TextureFormat[] textureFormats =
        {
        TextureFormat.Alpha8,
        TextureFormat.ARGB32,
        TextureFormat.ARGB4444,
        TextureFormat.ASTC_RGBA_10x10,
        TextureFormat.ASTC_RGBA_12x12,
        TextureFormat.ASTC_RGBA_4x4,
        TextureFormat.ASTC_RGBA_5x5,
        TextureFormat.ASTC_RGBA_6x6,
        TextureFormat.ASTC_RGBA_8x8,
        TextureFormat.ASTC_RGB_10x10,
        TextureFormat.ASTC_RGB_12x12,
        TextureFormat.ASTC_RGB_4x4,
        TextureFormat.ASTC_RGB_5x5,
        TextureFormat.ASTC_RGB_6x6,
        TextureFormat.ASTC_RGB_8x8,
        TextureFormat.ATC_RGB4,
        TextureFormat.ATC_RGBA8,
        TextureFormat.BC4,
        TextureFormat.BC5,
        TextureFormat.BC6H,
        TextureFormat.BC7,
        TextureFormat.BGRA32,
        TextureFormat.DXT1,
        TextureFormat.DXT1Crunched,
        TextureFormat.DXT5,
        TextureFormat.DXT5Crunched,
        TextureFormat.EAC_R,
        TextureFormat.EAC_RG,
        TextureFormat.EAC_RG_SIGNED,
        TextureFormat.EAC_R_SIGNED,
        TextureFormat.ETC2_RGB,
        TextureFormat.ETC2_RGBA1,
        TextureFormat.ETC2_RGBA8,
        TextureFormat.ETC2_RGBA8Crunched,
        TextureFormat.ETC_RGB4,
        TextureFormat.ETC_RGB4Crunched,
        TextureFormat.ETC_RGB4_3DS,
        TextureFormat.ETC_RGBA8_3DS,
        TextureFormat.PVRTC_RGB2,
        TextureFormat.PVRTC_RGB4,
        TextureFormat.PVRTC_RGBA2,
        TextureFormat.PVRTC_RGBA4,
        TextureFormat.R16,
        TextureFormat.R8,
        TextureFormat.RFloat,
        TextureFormat.RG16,
        TextureFormat.RGB24,
        TextureFormat.RGB565,
        TextureFormat.RGB9e5Float,
        TextureFormat.RGBA32,
        TextureFormat.RGBA4444,
        TextureFormat.RGBAFloat,
        TextureFormat.RGBAHalf,
        TextureFormat.RGFloat,
        TextureFormat.RGHalf,
        TextureFormat.RHalf,
        TextureFormat.YUY2,
    };

        // Use this for initialization
        void Start()
        {
            Screen.SetResolution(1080, 1920, true);
            Check();
        }

        

        private void Check()
        {
            text.text = "";
            text.text += SystemInfo.deviceModel + "\n";
            text.text += "---\n";
            
            for (var i = 0; i < textureFormats.Length; i++)
            {
                var result = SystemInfo.SupportsTextureFormat(textureFormats[i]);
                if (result)
                {
                    text.text += "<color=#20D1FFFF>";
                }
                else
                {
                    text.text += "<color=#FF0000>";
                }
                text.text += textureFormats[i].ToString() + "</color>\n";
            }
        }
    }
}
