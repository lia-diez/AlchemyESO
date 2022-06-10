namespace Alchemy;

public class Ingredient
{
    public readonly string Reagent;
    public readonly string[] Effects;
    public readonly string ComesFrom;

    public Ingredient(TemporaryIngredient temporaryIngredient)
    {
        Reagent = temporaryIngredient.Reagent;
        Effects = new[]
        {
            temporaryIngredient.PrimaryEffect, 
            temporaryIngredient.SecondaryEffect, 
            temporaryIngredient.TertiaryEffect,
            temporaryIngredient.QuaternaryEffect
        };
        ComesFrom = temporaryIngredient.Comesfrom;
    }
}