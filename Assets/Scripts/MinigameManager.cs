using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class MinigameManager : MonoBehaviour
{
    public RecipeManager rm;

    public List<Image> KeyBindsAsset;

    public Image imageKeys;
    public List<Sprite> recetteKeys;

    public void createUI(int recette, int variante)
    {
        Debug.Log(recetteKeys[0]);
        if (recette == 0)
        {
            Debug.Log(recetteKeys.Count);
            KeyBindsAsset[0].enabled = true;
            KeyBindsAsset[1].enabled = true;
            KeyBindsAsset[2].enabled = true;
            KeyBindsAsset[3].enabled = true;
            if (variante == 0)
            {
                imageKeys.sprite = recetteKeys[0];
            }
            else if (variante == 1)
            {
                imageKeys.sprite = recetteKeys[1];
            }
            else if (variante == 2)
            {
                imageKeys.sprite = recetteKeys[2];
            }
        }
        else if(recette == 1)
        {
            KeyBindsAsset[0].enabled = false;
            KeyBindsAsset[1].enabled = false;
            KeyBindsAsset[2].enabled = true;
            KeyBindsAsset[3].enabled = true;
            if (variante == 0)
            {
                imageKeys.sprite = recetteKeys[3];
            }
            else if (variante == 1)
            {
                imageKeys.sprite = recetteKeys[4];
            }
            else if (variante == 2)
            {
                imageKeys.sprite = recetteKeys[5];
            }
        }
        else if (recette == 2)
        {
            KeyBindsAsset[0].enabled = false;
            KeyBindsAsset[1].enabled = true;
            KeyBindsAsset[2].enabled = false;
            KeyBindsAsset[3].enabled = true;
            if (variante == 0)
            {
                imageKeys.sprite = recetteKeys[6];
            }
            else if (variante == 1)
            {
                imageKeys.sprite = recetteKeys[7];
            }
            else if (variante == 2)
            {
                imageKeys.sprite = recetteKeys[8];
            }
        }
    }
}
