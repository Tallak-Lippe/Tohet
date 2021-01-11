using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    public List<TutorialLine> lines;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeliverLines());
    }

    IEnumerator DeliverLines()
    {
        foreach (TutorialLine line in lines)
        {
            text.text = line.text;
            line.action?.Raise();
            yield return new WaitForSeconds(line.time);
        }
    }
}
