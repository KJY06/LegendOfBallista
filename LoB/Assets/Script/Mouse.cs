using System.Collections;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] private Texture2D cursortexture;
    private bool HotspotIsCenter = false;
    private Vector2 adjustHotspot = Vector2.zero;
    private Vector2 hotspot;

    void Start()
    {
        StartCoroutine(MyCursor());
    }
    IEnumerator MyCursor()
    {
        yield return new WaitForEndOfFrame();
        if (HotspotIsCenter)
        {
            hotspot.x = cursortexture.width / 2;
            hotspot.y = cursortexture.height / 2;
        }
        else
            hotspot = adjustHotspot;
        Cursor.SetCursor(cursortexture, hotspot, CursorMode.Auto);
    }
}

