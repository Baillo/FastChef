using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ControladorDoIngrediente : MonoBehaviour , IDragHandler
{
    [Header("Controle do ingrediente")]
    public Camera camera;
    public Canvas myCanvas;
    public GameObject teste;
    private static Color32 minhaCor;
    private static RectTransform minhaPosicao;
    public static bool habilitado;

    public void Start()
    {
        minhaCor = GetComponent<Image>().color;
        minhaPosicao = GetComponent<RectTransform>();
    }

    /// <summary>
    /// Movimentacao Do ingrediente
    /// </summary>
    public void OnDrag(PointerEventData eventData)
    {
        // obter posicao mouse e coloco no objeto
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
        transform.position = myCanvas.transform.TransformPoint(pos);
    }

    public void Update()
    {
        if (habilitado)
        {
            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
            transform.position = myCanvas.transform.TransformPoint(pos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            habilitado = false;
        }
    }

    public static void AtualizarMinhaPosicao(Color32 corNova, Vector2 posicaoNova)
    {
        Debug.Log(minhaCor);
        Debug.Log(corNova);
        minhaPosicao.anchoredPosition = posicaoNova;
        minhaCor = corNova;
        Debug.Log(minhaCor);
     
    }

}
