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
