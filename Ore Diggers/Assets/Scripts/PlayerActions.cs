using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    public RandomOreSpawn randomOreSpawn;
    public Inventory inventoryScripts;
    public GameManager gameManager;
    public GameObject TheFinal;
    private CircleCollider2D circleCol;
    public float accessibleDistance;

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
    public GameObject dontBreakTextObject;
    [Space]
    private string currentPickaxeName;

    private void Start()
    {
        circleCol = GetComponent<CircleCollider2D>();
        circleCol.radius = accessibleDistance;
    }

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

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);
        if (hit.collider)
        {
            if (hit.collider.gameObject.CompareTag("Ore"))
            {
                if (!gameManager.Inventory_Open && !gameManager.Trader_Open && !gameManager.PauseMenu_Open)
                {
                    OreScripts oreScript = hit.collider.gameObject.GetComponent<OreScripts>();
                    oreNameText.text = oreScript.oreName;
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (oreScript.canBreakable)
                        {
                            if (currentPickaxeIndex >= oreScript.oreRequiredPickaxeIndex)
                            {
                                oreScript.oreDurability -= currentDamage;

                                if (oreScript.oreDurability <= 0)
                                {
                                    if (oreScript.oreIndex != 9)
                                    {
                                        inventoryScripts.AddOre(oreScript.oreIndex, oreScript.oreDropCount);
                                        TextMeshProUGUI notificationText = Instantiate(notificationTextObject, notificationPanel.transform.position, Quaternion.identity).GetComponent<TextMeshProUGUI>();
                                        notificationText.gameObject.transform.SetParent(notificationPanel.transform);
                                        notificationText.text = "+ " + oreScript.oreDropCount + " " + oreScript.oreName;
                                        randomOreSpawn.OneOreSpawn(oreScript.oreIndex);
                                        Destroy(hit.collider.gameObject);
                                    }
                                    else if (oreScript.oreIndex == 9)
                                    {
                                        //THE FINAL
                                        StartCoroutine(Final());
                                    }
                                }
                            }
                            else
                            {
                                if (oreScript.oreRequiredPickaxeIndex == 0)
                                {
                                    currentPickaxeName = "Hand";
                                }
                                else if (oreScript.oreRequiredPickaxeIndex == 1)
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
                                dontMineText.text = "I need an " + currentPickaxeName;
                            }
                        }
                        else
                        {
                            TextMeshProUGUI dontBreakText = Instantiate(dontBreakTextObject, dontMinePanel.transform.position, Quaternion.identity).GetComponent<TextMeshProUGUI>();
                            dontBreakText.gameObject.transform.SetParent(dontMinePanel.transform);
                            dontBreakText.text = "It's so far, I can't break it";
                        }
                    }
                }
            }
        }
    }

    IEnumerator Final()
    {
        TheFinal.SetActive(true);
        yield return new WaitForSeconds(22f);
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ore")
        {
            OreScripts ore = collision.gameObject.GetComponent<OreScripts>();
            ore.canBreakable = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ore")
        {
            OreScripts ore = collision.gameObject.GetComponent<OreScripts>();
            ore.canBreakable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ore")
        {
            OreScripts ore = collision.gameObject.GetComponent<OreScripts>();
            ore.canBreakable = false;
        }
    }
}
