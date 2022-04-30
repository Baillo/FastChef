using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Descobre se tem o enum enviado entro do enum
//bool success = IngredientesLanche.IsDefined(typeof(int), escolhido);


public enum IngredientesLanche { PaoCima, Alface, Tomate, Queijo, Hamburguer, PaoBaixo };


public class Ingredientes 
{
    private static Color32 cor;

    /// <summary>
    /// EnviarPosicao e a cor do ingrediente para o controlador do ingrediente
    /// </summary>
    public static void ObterIngredientesInfo(IngredientesLanche escolhido, Vector2 posicao)
    {
        switch (escolhido)
        {      
            case IngredientesLanche.PaoCima:
                cor = new Color32(64, 128, 192, 255);
                break;

            case IngredientesLanche.Alface:
                cor = new Color32(152, 255, 143, 255);
                break;

            case IngredientesLanche.Tomate:
                cor = new Color32(231, 10, 27, 255);
                break;

            case IngredientesLanche.Queijo:
                cor = new Color32(227, 231, 10, 255);
                break;

            case IngredientesLanche.Hamburguer:
                cor = new Color32(70, 17, 11, 255);
                break;

            case IngredientesLanche.PaoBaixo:
                cor = new Color32(253, 138, 125, 255);
                break;
        }
        ControladorDoIngrediente.AtualizarMinhaPosicao(cor, posicao);

    }



}
