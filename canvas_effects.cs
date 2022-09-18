using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_effects : MonoBehaviour
{
    public GameObject aimBorder;
    public RawImage aimBorderImage;

    public float startTime;
    public float time;
    public bool isRightMouseDown;
    // Start is called before the first frame update
    void Start()
    {
        isRightMouseDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        aimBorderAnim();
    }

    void aimBorderAnim(){
        if(Input.GetKeyDown(KeyCode.Mouse1)){
            startTime = time;
        }
        if(Input.GetKey(KeyCode.Mouse1)){
            float scaleFactor = (1f - (time - startTime));
            scaleFactor = Mathf.Clamp(scaleFactor, 0.75f, 1f);
            aimBorder.transform.localScale = new Vector3(scaleFactor,scaleFactor,scaleFactor);
        }else{
            aimBorder.transform.localScale = new Vector3(1f,1f,1f);
        }
        
    }
}
