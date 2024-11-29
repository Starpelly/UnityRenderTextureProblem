using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    private RenderTexture _renderTexture;
    
    [SerializeField]
    private Camera _renderTextureCam;

    [SerializeField]
    private RawImage _renderImage;
    
    private void Awake()
    {
        _renderTexture = new RenderTexture(Screen.width, Screen.height, 0, RenderTextureFormat.ARGB32);
        _renderTextureCam.targetTexture = _renderTexture;
        _renderImage.texture = _renderTexture;
        _renderImage.color = Color.white;
    }
}
