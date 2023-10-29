using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum EstadoDoControlador{DentroDoPote, ForaDoPote};

public class PoteIngrediente : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler

{
    public IngredientesLanche ingredienteMeu;
    private EstadoDoControlador _estadoControlador;

    private void Start()
    {
        _estadoControlador = EstadoDoControlador.ForaDoPote;
    }

    public void OnPointerClick(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        _estadoControlador = EstadoDoControlador.DentroDoPote;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _estadoControlador = EstadoDoControlador.ForaDoPote;
    }
    /*
    private void OnMouseEnter()
    {
        _estadoControlador = EstadoDoControlador.DentroDoPote;
    }

    public void OnMouseExit()
    {
        _estadoControlador = EstadoDoControlador.ForaDoPote;
    }
    */


    private void Update()
    {
        Debug.Log(_estadoControlador);
        /*
        if (Input.GetMouseButtonDown(0) && _estadoControlador == EstadoDoControlador.DentroDoPote)
        {
            Vector2 posicao = gameObject.GetComponent<RectTransform>().anchoredPosition;
            Ingredientes.ObterIngredientesInfo(ingredienteMeu, posicao);
            _estadoControlador = EstadoDoControlador.ForaDoPote;
            ControladorDoIngrediente.habilitado = true;
        }
        */
    }
}
