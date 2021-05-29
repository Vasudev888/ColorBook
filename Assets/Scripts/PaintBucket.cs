using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintBucket : MonoBehaviour
{

    public Color[] colorList;
    public Color curColor;
    [SerializeField]
    int colorCount;

    void Start()
    {
        
    }

    
    void Update()
    {
        curColor = colorList[colorCount];
        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);

        if(Input.GetMouseButton(0))
        {
            if(hit.collider != null)
            {
                SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                Debug.Log(hit.collider.name);

                sp.color = curColor;

            }


      /*      if (hit.collider == null)
            {
                Camera.main.backgroundColor = curColor;
            }
*/
        }


        
    }

    public void Paint(int colorCode)
    {
        colorCount = colorCode;
    }
}
 