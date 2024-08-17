using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditorInternal;

public class Inventory : MonoBehaviour
{

    public int SmallStoneCountInv,BigStoneCountInv,CoalCountInv,CopperCountInv,IronCountInv,SilverCountInv,GoldCountInv,PlatinumCountInv,IridiumCountInv,UraniumCountInv;
    public TextMeshProUGUI SmallStoneCountInvText,BigStoneCountInvText,CoalCountInvText,CopperCountInvText,IronCountInvText,SilverCountInvText,GoldCountInvText,PlatinumCountInvText,IridiumCountInvText;
    public int PriceStoneP,PriceRockP,PriceCoalP,PriceCopperP,PriceIronP,PriceSilverP,PriceGoldP,PriceStoneM,PriceRockM,PriceCoalM,PriceCopperM,PriceIronM,PriceSilverM,PriceGoldM,PricePlatinumM,PriceIridiumM;
    public TextMeshProUGUI PriceStonePText,PriceRockPText,PriceCoalPText,PriceCopperPText,PriceIronPText,PriceSilverPText,PriceGoldPText,PriceStoneMText,PriceRockMText,PriceCoalMText,PriceCopperMText,PriceIronMText,PriceSilverMText,PriceGoldMText,PricePlatinumMText,PriceIridiumMText;
    public void Update(){
        SmallStoneCountInvText.text = SmallStoneCountInv.ToString();
        BigStoneCountInvText.text = BigStoneCountInv.ToString();
        CoalCountInvText.text = CoalCountInv.ToString();
        CopperCountInvText.text = CopperCountInv.ToString();
        IronCountInvText.text = IronCountInv.ToString();
        SilverCountInvText.text = SilverCountInv.ToString();
        GoldCountInvText.text = GoldCountInv.ToString();
        PlatinumCountInvText.text = PlatinumCountInv.ToString();
        IridiumCountInvText.text = IridiumCountInv.ToString();
        PriceStonePText.text = PriceStoneP.ToString();
        PriceRockPText.text = PriceRockP.ToString();
        PriceCoalPText.text = PriceCoalP.ToString();
        PriceCopperPText.text = PriceCopperP.ToString();
        PriceIronPText.text = PriceIronP.ToString();
        PriceSilverPText.text = PriceSilverP.ToString();
        PriceGoldPText.text = PriceGoldP.ToString();
        PriceStoneMText.text = PriceStoneM.ToString();
        PriceRockMText.text = PriceRockM.ToString();
        PriceCoalMText.text = PriceCoalM.ToString();
        PriceCopperMText.text = PriceCopperM.ToString();
        PriceIronMText.text = PriceIronM.ToString();
        PriceSilverMText.text = PriceSilverM.ToString();
        PriceGoldMText.text = PriceGoldM.ToString();
        PricePlatinumMText.text = PricePlatinumM.ToString();
        PriceIridiumMText.text = PriceIridiumM.ToString();
    }

    public void AddOre(int OreIndex, int OreCount){
        if(OreIndex==0){
            SmallStoneCountInv = SmallStoneCountInv + OreCount;
        }
        if(OreIndex==1){
            BigStoneCountInv = BigStoneCountInv + OreCount;
        }
        if(OreIndex==2){
            CoalCountInv = CoalCountInv + OreCount;
        }
        if(OreIndex==3){
            CopperCountInv = CopperCountInv + OreCount;
        }
        if(OreIndex==4){
            IronCountInv = IronCountInv + OreCount;
        }
        if(OreIndex==5){
            SilverCountInv = SilverCountInv + OreCount;
        }
        if(OreIndex==6){
            GoldCountInv = GoldCountInv + OreCount;
        }
        if(OreIndex==7){
            PlatinumCountInv = PlatinumCountInv + OreCount;
        }
        if(OreIndex==8){
            IridiumCountInv = IridiumCountInv + OreCount;
        }
        if(OreIndex==9){
            UraniumCountInv = UraniumCountInv + OreCount;
        }
    }
}
