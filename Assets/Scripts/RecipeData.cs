using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "recipe_variable", menuName = "RecipeData")]
public class RecipeData : ScriptableObject
{
    public Sprite apparence;
    public List<KeyCode> recette1 = new List<KeyCode>();
    public List<KeyCode> recette2 = new List<KeyCode>();
    public List<KeyCode> recette3 = new List<KeyCode>();
    public string foodname;
}
