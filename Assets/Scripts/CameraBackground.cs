using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class CameraBackground : MonoBehaviour
{
    public Color defaultcolor = Color.red;
    public Color alternatecolor = Color.blue;
    public Color ppn = Color.grey;

    Camera cm;
    bool alternate = true;

    public Button previous;
    public Button play;
    public Button next;

    public Button OperatorHeader;
 
    void Start()
    {
        cm = GetComponent<Camera>();
    
        previous.GetComponent<Image>().color = defaultcolor;
        play.GetComponent<Image>().color = defaultcolor;
        next.GetComponent<Image>().color = defaultcolor;  

        OperatorHeader.GetComponent<Button>().onClick.AddListener(OperatorHeaderClick);      
    }
 
    void OperatorHeaderClick()
    {
        alternate = !alternate;
        if (alternate) {
            cm.backgroundColor = defaultcolor;
            previous.GetComponent<Image>().color = defaultcolor;
            play.GetComponent<Image>().color = defaultcolor;
            next.GetComponent<Image>().color = defaultcolor;
        }
        else {
            cm.backgroundColor = alternatecolor;
            previous.GetComponent<Image>().color = ppn;
            play.GetComponent<Image>().color = ppn;
            next.GetComponent<Image>().color = ppn;                
        }
    }
}