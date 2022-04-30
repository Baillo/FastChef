using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PoteIngrediente : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerEnterHandler
{
    public IngredientesLanche ingredienteMeu;
    private bool dentro;
   
    public void OnPointerClick(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        dentro = true;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && dentro)
        {
            Vector2 posicao = gameObject.GetComponent<RectTransform>().anchoredPosition;
            Ingredientes.ObterIngredientesInfo(ingredienteMeu, posicao);
            dentro = false;
            ControladorDoIngrediente.habilitado = true;
        }
    }
}
