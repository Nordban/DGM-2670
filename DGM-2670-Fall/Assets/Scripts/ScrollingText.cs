using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScrollingText : MonoBehaviour
{
    public TextMeshProUGUI textMeshProComponent;
    public float scrollSpeed = .5f;
    //private TextMeshProUGUI cloneTextObject;
    public RectTransform textRectTransform;
    public float width;




    private void Awake()
    {
        textRectTransform = textMeshProComponent.GetComponent<RectTransform>();

    }

    IEnumerator Start()
    {

        width = textMeshProComponent.preferredWidth;
        Vector3 startPosition = textRectTransform.position;

        float scrollPosition = -22;
        Debug.Log("this is my starting width  " + width);
        while (true)
        {

            if (textRectTransform.transform.position.x >= -14)
            {

                textRectTransform.position = new Vector3(-scrollPosition % width, startPosition.y, startPosition.z);
                scrollPosition += scrollSpeed * 20 * Time.deltaTime;
                yield return null;
            }
            else
            {
                
                Debug.Log("this is my current width  " + width);
                textRectTransform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
                
            }
           
        }
    }


}
