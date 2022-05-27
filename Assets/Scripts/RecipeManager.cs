using UnityEngine;
using System.Collections.Generic;

public class RecipeManager : MonoBehaviour
{
    public MinigameManager mgm;

    public Recipe currentRecipe;
    public Recipe Currentrecipe => currentRecipe;

    public Recipe recipePrefab;

    [SerializeField]
    private List<RecipeData> data;
    public RecipeData dataRecipe;
    
    public int rnd;
    private int temp;

    public int rndRecipe;
    public List<KeyCode> chosenRecipe;
    public void Start()
    {
        CreateRecipe();
    }

    public void CreateRecipe()
    {
        while (rnd == temp)
        {
            rnd = Random.Range(0, 3);
        }
        temp = rnd;
        var R = Instantiate(recipePrefab);
        currentRecipe = R;
        dataRecipe = data[rnd];
        randomRecipe(dataRecipe);
        R.OnCreation(dataRecipe, rnd, chosenRecipe, rndRecipe);
    }

    public void randomRecipe(RecipeData recipe)
    {
        rndRecipe = Random.Range(0, 3);
        if (rndRecipe == 0)
        {
            chosenRecipe = recipe.recette1;
            Debug.Log("recette1");
        }
        else if (rndRecipe == 1)
        {
            chosenRecipe = recipe.recette2;
            Debug.Log("recette2");
        }
        else if (rndRecipe == 2)
        {
            chosenRecipe = recipe.recette3;
            Debug.Log("recette3");
        }
    }
}
