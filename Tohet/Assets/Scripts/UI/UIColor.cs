using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class UIColor : MonoBehaviour
{
    public TMP_Text text;
    public GlobalColor colorData;
    public GameEvent gameEvent;

    public int startIndex;
    int index;

    bool pointerHasLeftText = true;

    // Start is called before the first frame update
    void Start()
    {
        index = startIndex;
        text.color = colorData.colors[index];
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject() && pointerHasLeftText)
        {
            ChangeColor();
            pointerHasLeftText = false;
        }

        if (!EventSystem.current.IsPointerOverGameObject() && !pointerHasLeftText)
        {
            ChangeColor();
            pointerHasLeftText = true;
        }
    }

    private void ChangeColor()
    {
        index += 1;
        if (index >= colorData.colors.Count)
        {
            index = 0;
        }
        text.color = colorData.colors[index];
        gameEvent.Raise();
    }
}
