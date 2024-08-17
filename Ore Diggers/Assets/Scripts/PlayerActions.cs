using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;
using UnityEngine.UI;
using TMPro.EditorUtilities;

public class PlayerActions : MonoBehaviour
{
    public RandomOreSpawn randomOreSpawn;
    public Inventory inventoryScripts;
    public GameManager gameManager;

    [Space]
    public int currentPickaxeIndex;
    [HideInInspector] public int currentDamage;
    public int handDamage, stonePickaxeDamage, ironPickaxeDamage, goldPickaxeDamage, iridiumPickaxeDamage, MATKAPDamage;
    [Space]
    public GameObject notificationTextObject;
    public GameObject notificationPanel;
    [Space]
    public TextMeshProUGUI oreNameText;
    [Space]
    public GameObject dontMineTextObject;
    public GameObject dontMinePanel;
    [Space]
    private string currentPickaxeName;

    private void Update()
    {
        if(currentPickaxeIndex == 0)
        {
            currentDamage = handDamage;
        }
        else if(currentPickaxeIndex == 1)
        {
            currentDamage = stonePickaxeDamage;
        }
        else if (currentPickaxeIndex == 2)
        {
            currentDamage = iridiumPickaxeDamage;
        }
        else if (currentPickaxeIndex == 3)
        {
            currentDamage = goldPickaxeDamage;
        }
        else if (currentPickaxeIndex == 4)
        {
            currentDamage = iridiumPickaxeDamage;
        }
        else if (currentPickaxeIndex == 5)
        {
            currentDamage = MATKAPDamage;
        }
        oreNameText.text = null;
        if (!gameManager.PauseMenu_Open)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);
            if (hit.collider)
            {
                if (hit.collider.gameObject.CompareTag("Ore"))
                {
                    OreScripts oreScript = hit.collider.gameObject.GetComponent<OreScripts>();
                    oreNameText.text = oreScript.oreName;
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (currentPickaxeIndex >= oreScript.oreRequiredPickaxeIndex)
                        {
                            oreScript.oreDurability -= currentDamage;

                            if (oreScript.oreDurability <= 0)
                            {
                                inventoryScripts.AddOre(oreScript.oreIndex, oreScript.oreDropCount);

                                TextMeshProUGUI notificationText = Instantiate(notificationTextObject, notificationPanel.transform.position, Quaternion.identity).GetComponent<TextMeshProUGUI>();
                                notificationText.gameObject.transform.SetParent(notificationPanel.transform);
                                notificationText.text = "+ " + oreScript.oreDropCount + " " + oreScript.oreName;
                                randomOreSpawn.OneOreSpawn(oreScript.oreIndex);
                                Destroy(hit.collider.gameObject);
                            }
                        }
                        else
                        {
                            if(oreScript.oreRequiredPickaxeIndex == 0)
                            {
                                currentPickaxeName = "Hand";
                            }
                            else if(oreScript.oreRequiredPickaxeIndex == 1)
                            {
                                currentPickaxeName = "Stone Pickaxe";
                            }
                            else if (oreScript.oreRequiredPickaxeIndex == 2)
                            {
                                currentPickaxeName = "Iron Pickaxe";
                            }
                            else if (oreScript.oreRequiredPickaxeIndex == 3)
                            {
                                currentPickaxeName = "Gold Pickaxe";
                            }
                            else if (oreScript.oreRequiredPickaxeIndex == 4)
                            {
                                currentPickaxeName = "Iridium Pickaxe";
                            }
                            else if (oreScript.oreRequiredPickaxeIndex == 5)
                            {
                                currentPickaxeName = "MATKAP";
                            }
                            TextMeshProUGUI dontMineText = Instantiate(dontMineTextObject, dontMinePanel.transform.position, Quaternion.identity).GetComponent<TextMeshProUGUI>();
                            dontMineText.gameObject.transform.SetParent(dontMinePanel.transform);
                            dontMineText.text = currentPickaxeName + " Required!";
                        }

                    }
                }
            }
        }
    }
}
