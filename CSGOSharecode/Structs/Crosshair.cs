using csgo_sharecode.CSGOSharecode.Enums;
using System.Text;

namespace csgo_sharecode.CSGOSharecode.Structs
{
    public class Crosshair
    {
        public Crosshair(string originalCode, int[] decoded)
        {
            CrosshairCode = originalCode;

            cl_crosshaircolor_argb = new ARGBColor() { Red = (byte)decoded[5], Green = (byte)decoded[6], Blue = (byte)decoded[7], Alpha = (byte)decoded[8] };
            cl_crosshaircolor = decoded[11] & 7;
            cl_crosshairusealpha = ((decoded[14] >> 4) & 4) != 0;

            cl_crosshair_outlinethickness = decoded[4] / 2.0f;
            cl_crosshair_drawoutline = (decoded[11] & 8) != 0;

            cl_crosshair_dynamic_splitalpha_innermod = (decoded[11] >> 4) / 10f;
            cl_crosshair_dynamic_maxdist_splitratio = (decoded[12] >> 4) / 10f;
            cl_crosshair_dynamic_splitalpha_outermod = (decoded[12] & 0xF) / 10f;
            cl_crosshair_dynamic_splitdis = decoded[9];

            cl_crosshairsize = decoded[15] / 10f;
            cl_crosshairthickness = decoded[13] / 10f;
            cl_crosshair_t = ((decoded[14] >> 4) & 8) != 0;
            cl_crosshairdot = ((decoded[14] >> 4) & 1) != 0;
            cl_crosshairstyle = (CrosshairStyle)((decoded[14] & 0xF) >> 1);

            cl_crosshairgap = ((decoded[3] << 24) >> 24) / 10f;
            cl_fixedcrosshairgap = ((decoded[10] << 24) >> 24) / 10f;
            cl_crosshairgap_useweaponvalue = ((decoded[14] >> 4) & 2) == 2;
        }
        public string CrosshairCode { get; private set; }

        public float cl_crosshairsize { get; private set; }
        public float cl_crosshairthickness { get; private set; }
        public float cl_crosshairgap { get; private set; }
        public float cl_crosshaircolor { get; private set; }
        public float cl_fixedcrosshairgap { get; private set; }
        public float cl_crosshair_outlinethickness { get; private set; }
               
        public float cl_crosshair_dynamic_splitdis { get; private set; }
        public float cl_crosshair_dynamic_maxdist_splitratio { get; private set; }
        public float cl_crosshair_dynamic_splitalpha_innermod { get; private set; }
        public float cl_crosshair_dynamic_splitalpha_outermod { get; private set; }

        public bool cl_crosshairusealpha { get; private set; }
        public bool cl_crosshair_drawoutline { get; private set; }
        public bool cl_crosshairdot { get; private set; }
        public bool cl_crosshair_t { get; private set; }
        public bool cl_crosshairgap_useweaponvalue { get; private set; }

        public ARGBColor cl_crosshaircolor_argb { get; private set; }
        public CrosshairStyle cl_crosshairstyle { get; private set; }
    }
}
