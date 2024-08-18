using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public int SmallStoneCountInv,BigStoneCountInv,CoalCountInv,CopperCountInv,IronCountInv,SilverCountInv,GoldCountInv,PlatinumCountInv,IridiumCountInv,UraniumCountInv;
    public TextMeshProUGUI SmallStoneCountInvText,BigStoneCountInvText,CoalCountInvText,CopperCountInvText,IronCountInvText,SilverCountInvText,GoldCountInvText,PlatinumCountInvText,IridiumCountInvText;
    public int PriceStoneP,PriceRockP,PriceCoalP,PriceCopperP,PriceIronP,PriceSilverP,PriceGoldP,PriceStoneM,PriceRockM,PriceCoalM,PriceCopperM,PriceIronM,PriceSilverM,PriceGoldM,PricePlatinumM,PriceIridiumM;
    public TextMeshProUGUI PriceStonePText,PriceRockPText,PriceCoalPText,PriceCopperPText,PriceIronPText,PriceSilverPText,PriceGoldPText,PriceStoneMText,PriceRockMText,PriceCoalMText,PriceCopperMText,PriceIronMText,PriceSilverMText,PriceGoldMText,PricePlatinumMText,PriceIridiumMText;
    public Button StonePBuyButton;
    public Button IronPBuyButton;
    public Button GoldPBuyButton;
    public Button IridiumPBuyButton;
    public Button MATKAPBuyButton;
    private bool Stonebbutton_pressed = false;
    private bool Ironbbutton_pressed = false;
    private bool Goldbbutton_pressed = false;
    private bool Iridiumbbutton_pressed = false;
    private bool matkapbbutton_pressed = false;
    public PlayerActions playeractions;
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
        if(SmallStoneCountInv >= PriceStoneP && Stonebbutton_pressed == false){
            StonePBuyButton.interactable = true;
        }
        else{
            StonePBuyButton.interactable = false;
        }

        if(BigStoneCountInv >= PriceRockP && CoalCountInv >= PriceCoalP && Ironbbutton_pressed == false){
            IronPBuyButton.interactable = true;
        }
        else
        {
            IronPBuyButton.interactable = false;
        }

        if(CopperCountInv >= PriceCopperP && IronCountInv >= PriceIronP && Goldbbutton_pressed == false){
            GoldPBuyButton.interactable = true;
        }
        else{
            GoldPBuyButton.interactable = false;
        }

        if(SilverCountInv >= PriceSilverP && GoldCountInv >= PriceGoldP && Iridiumbbutton_pressed == false){
            IridiumPBuyButton.interactable = true;
        }
        else{
            IridiumPBuyButton.interactable = false;
        }

        if(SmallStoneCountInv >= PriceStoneM && BigStoneCountInv >= PriceRockM && CoalCountInv >= PriceCoalM && CopperCountInv >= PriceCopperM && IronCountInv >= PriceIronM && SilverCountInv >= PriceSilverM && GoldCountInv >= PriceGoldM && PlatinumCountInv >= PricePlatinumM && IridiumCountInv >= PriceIridiumM && matkapbbutton_pressed == false){
            MATKAPBuyButton.interactable = true;
        }
        else{
            MATKAPBuyButton.interactable = false;
        }
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
    public void StonePickaxeBuyButton(){
        playeractions.currentPickaxeIndex = 1;
        SmallStoneCountInv = SmallStoneCountInv - PriceStoneP;
        Stonebbutton_pressed = true;
    }
    public void IronPickaxeBuyButton(){
        playeractions.currentPickaxeIndex = 2;
        BigStoneCountInv = BigStoneCountInv - PriceRockP;
        CoalCountInv = CoalCountInv - PriceCoalP;
        Ironbbutton_pressed = true;
    }
    public void GoldPickaxeBuyButton(){
        playeractions.currentPickaxeIndex = 3;
        CopperCountInv = CopperCountInv - PriceCopperP;
        IronCountInv = IronCountInv - PriceIronP;
        Goldbbutton_pressed = true;
    }
    public void IridiumPickaxeBuyButton(){
        playeractions.currentPickaxeIndex = 4;
        SilverCountInv = SilverCountInv - PriceSilverP;
        GoldCountInv = GoldCountInv - PriceGoldP;
        Iridiumbbutton_pressed = true;
    }
    public void MatkapBuyButtonF(){
        playeractions.currentPickaxeIndex = 5;
        SmallStoneCountInv = SmallStoneCountInv - PriceStoneM;
        BigStoneCountInv = BigStoneCountInv - PriceRockM;
        CoalCountInv = CoalCountInv - PriceCoalM;
        CopperCountInv = CopperCountInv - PriceCopperM;
        IronCountInv = IronCountInv - PriceIronM;
        SilverCountInv = SilverCountInv - PriceSilverM;
        GoldCountInv = GoldCountInv - PriceGoldM;
        PlatinumCountInv = PlatinumCountInv - PricePlatinumM;
        IridiumCountInv = IridiumCountInv - PriceIridiumM;
        matkapbbutton_pressed = true;
    }
}
