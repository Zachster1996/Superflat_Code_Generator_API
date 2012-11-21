using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperflatCodeGeneratorAPI
{
    public class Code
    {
        public static String Generate(String[] layers, int biome, Boolean enableVillages, int villageSize, int villageDistance, Boolean enableMineshafts, double mineshaftChance, Boolean enableStrongholds, int strongholdCount, Boolean enableStructures, Boolean enableDungeons, Boolean enableDecorations, Boolean enableLakes, Boolean enableLavaLakes)
        {
            String code = "2;";
            for (int i = 0; i < layers.Length - 1; i++)
            {
                code += layers[i] + ",";
            }
            code += layers[layers.Length - 1] + ";";
            code += biome + ";";
            if (enableVillages)
            {
                code += "village(size=" + villageSize + " distance=" + villageDistance + "),";
            }
            if (enableMineshafts)
            {
                code += "mineshaft(chance=" + mineshaftChance + "),";
            }
            if (enableStrongholds)
            {
                code += "stronghold(count=" + strongholdCount + "),";
            }
            if (enableStructures)
            {
                code += "biome_1,";
            }
            if (enableDungeons)
            {
                code += "dungeon";
            }
            if (enableDecorations)
            {
                code += "decoration,";
            }
            if (enableLakes)
            {
                code += "lake,";
            }
            if (enableLavaLakes)
            {
                code += "lava_lake,";
            }
            return code;
        }
    }
}
