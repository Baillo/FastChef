using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControladorDoIngrediente : MonoBehaviour , IDragHandler
{
    [Header("Controle do ingrediente")]

    [SerializeField] private Camera camera;
    [SerializeField] private Canvas myCanvas;
    private Color32 minhaCor;
    private RectTransform minhaPosicao;
    public static bool habilitado;

    public static ControladorDoIngrediente instance;

    private void Awake()
    {
        instance = this;
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

    public void AtualizarMinhaPosicao(Color32 corNova, Vector2 posicaoNova)
    {
        minhaPosicao.anchoredPosition = posicaoNova;
        minhaCor = corNova;     
    }

}
