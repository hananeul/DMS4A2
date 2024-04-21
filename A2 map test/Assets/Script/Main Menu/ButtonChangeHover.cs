using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonChangeHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite normalSprite;
    public Sprite hoverSprite;

    private Image buttonImage;

    void Start()
    {
        // Get the Image component of the button
        buttonImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Change the sprite to the hover sprite when the mouse hovers over the button
        if (hoverSprite != null)
        {
            buttonImage.sprite = hoverSprite;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Change the sprite back to the normal sprite when the mouse exits the button
        if (normalSprite != null)
        {
            buttonImage.sprite = normalSprite;
        }
    }
}
