using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class ColorSourceView : MonoBehaviour
{
    public GameObject ColorSourceManager;
    private ColorSourceManager _ColorManager;

    float ScaleY = -1;
    float ScaleX = 1;
    public bool IsMirror = true;

    void Start ()
    {
        gameObject.renderer.material.SetTextureScale("_MainTex", new Vector2(-1, 1));
    }
    
    void Update()
    {
        if (ColorSourceManager == null)
        {
            return;
        }
        
        _ColorManager = ColorSourceManager.GetComponent<ColorSourceManager>();
        if (_ColorManager == null)
        {
            return;
        }

        ScaleX = IsMirror ? 1 : -1;

        gameObject.renderer.material.SetTextureScale( "_MainTex", new Vector2( ScaleX, ScaleY ) );
        gameObject.renderer.material.mainTexture = _ColorManager.GetColorTexture();
    }
}
