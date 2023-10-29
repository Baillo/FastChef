using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Descobre se tem o enum enviado entro do enum
//bool success = IngredientesLanche.IsDefined(typeof(int), escolhido);


public enum IngredientesLanche { PaoCima, Alface, Tomate, Queijo, Hamburguer, PaoBaixo };
public enum Cores {PaoCimaCor, AlfaceCor, TomateCor, QueijoCor, HamburguerCor, PaoBaixoCor};


public static class Ingredientes 
{
    private static Color32 cor;
    private static List<Color32> coresIngredientes = new List<Color32>
{
            new Color32 (64, 128, 192, 255),
            new Color32(152, 255, 143, 255),
            new Color32(231, 10, 27, 255),
            new Color32(227, 231, 10, 255),
            new Color32(70, 17, 11, 255),
            new Color32(253, 138, 125, 255),
};
    /// <summary>
    /// EnviarPosicao e a cor do ingrediente para o controlador do ingrediente
    /// </summary>
    public static void ObterIngredientesInfo(IngredientesLanche escolhido, Vector2 posicao)
    {
        switch (escolhido)
        {      
            case IngredientesLanche.PaoCima:
                cor = coresIngredientes[(int)Cores.PaoCimaCor];
                break;

            case IngredientesLanche.Alface:
                cor = coresIngredientes[(int)Cores.AlfaceCor];
                break;

            case IngredientesLanche.Tomate:
                cor = coresIngredientes[(int)Cores.TomateCor];
                break;

            case IngredientesLanche.Queijo:
                cor = coresIngredientes[(int)Cores.QueijoCor];
                break;

            case IngredientesLanche.Hamburguer:
                cor = coresIngredientes[(int)Cores.HamburguerCor];
                break;

            case IngredientesLanche.PaoBaixo:
                cor = coresIngredientes[(int)Cores.PaoBaixoCor];
                break;
        }
        ControladorDoIngrediente.instance.AtualizarMinhaPosicao(cor, posicao);
    }
}
