using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Recipe : MonoBehaviour
{
    public MinigameManager mgm;
    public RecipeManager rm;
    public SpriteRenderer sr;
    public List<KeyCode> Controles;

    public KeyCode inputJoueur;
    public int etape;
    public List<KeyCode> recipeActuelle;

    public void Update()
    {
        if (Input.GetKeyDown(Controles[0]))
        {
            inputJoueur = Controles[0];
            minigameUpdate(recipeActuelle);
        }
        else if (Input.GetKeyDown(Controles[1]))
        {
            inputJoueur = Controles[1];
            minigameUpdate(recipeActuelle);
        }
        else if (Input.GetKeyDown(Controles[2]))
        {
            inputJoueur = Controles[2];
            minigameUpdate(recipeActuelle);
        }
        else if (Input.GetKeyDown(Controles[3]))
        {
            inputJoueur = Controles[3];
            minigameUpdate(recipeActuelle);
        }
    }

    public void OnCreation(RecipeData data, int recette, List<KeyCode> Variante, int VarianteValeur)
    {
        recipeActuelle = Variante;
        sr.sprite = data.apparence;
        etape = 0;
        mgm.createUI(recette, VarianteValeur);
    }

    public void minigameUpdate(List<KeyCode> data)
    {
        Debug.Log(data.Count);
        Debug.Log(etape);
        if (etape != data.Count)
        {
            if (inputJoueur == data[etape])
            {
                etape += 1;
                Debug.Log("Input OK");
            }
            if (etape == data.Count)
            {
                minigameDone();
            }
        }
    }

    public void minigameDone()
    {
        Destroy(gameObject);
        rm.CreateRecipe();
    }
}

