using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;

public class PlayerActions : MonoBehaviour
{
    public Inventory inventoryScripts;
    public int currentPickaxeIndex;
    [HideInInspector] public int currentDamage;
    public int handDamage, stonePickaxeDamage, ironPickaxeDamage, goldPickaxeDamage, iridiumPickaxeDamage, MATKAPDamage;

    public GameObject notificationTextObject;
    public GameObject notificationPanel;

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


        //LeftMouseButton
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);
            if (hit.collider)
            {
                if (hit.collider.gameObject.CompareTag("Ore"))
                {
                    OreScripts oreScript = hit.collider.gameObject.GetComponent<OreScripts>();
                    if (currentPickaxeIndex >= oreScript.oreRequiredPickaxeIndex)
                    {
                        oreScript.oreDurability -= currentDamage;

                        if(oreScript.oreDurability <= 0)
                        {
                            inventoryScripts.AddOre(oreScript.oreIndex, oreScript.oreDropCount);
                            Destroy(hit.collider.gameObject);

                            TextMeshProUGUI notificationText = Instantiate(notificationTextObject, notificationPanel.transform.position, Quaternion.identity).GetComponent<TextMeshProUGUI>();
                            notificationText.gameObject.transform.SetParent(notificationPanel.transform);
                            notificationText.text = "+ " + oreScript.oreDropCount + " " + oreScript.oreName;
                        }
                    }
                }
            }
        }
        
    }
}
