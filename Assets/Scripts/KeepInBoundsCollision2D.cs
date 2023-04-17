using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInBoundsCollision2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private float Xmin, Xmax, Ymin, Ymax;

    private void Awake() {
        AddColliderOnCamera();
    }

    public void AddColliderOnCamera() {
        if (Camera.main == null)
        {
            Debug.LogError("No camera found make sure you have tagged your camera with 'MainCamera'");
            return;
        }

        Camera cam = Camera.main;

        if (!cam.orthographic) {
            Debug.LogError("Make sure your camera is set to orthographic");
            return;
        }

        // Get or Add Edge Collider 2D component
        var edgeCollider = gameObject.GetComponent<EdgeCollider2D>() == null ? gameObject.AddComponent<EdgeCollider2D>() : gameObject.GetComponent<EdgeCollider2D>();

        // Making camera bounds
        var leftBottom = (Vector2) cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
        var leftTop = (Vector2) cam.ScreenToWorldPoint(new Vector3(0, cam.pixelHeight, cam.nearClipPlane));
        var rightTop = (Vector2) cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, cam.nearClipPlane));
        var rightBottom = (Vector2) cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, cam.nearClipPlane));

        var edgePoints = new[] { leftBottom, leftTop, rightTop, rightBottom, leftBottom };

        Xmin = leftBottom.x;
        Xmax = rightBottom.x;
        Ymin = leftBottom.y;
        Ymax = leftTop.y;

        // Adding edge points
        edgeCollider.points = edgePoints;
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            Vector3 curr_pos = other.transform.position;
            if(curr_pos.x <= Xmin) {
                curr_pos.x = Xmin;
            } else if(curr_pos.x >= Xmax) {
                curr_pos.x = Xmax;
            } else if(curr_pos.y <= Ymin) {
                curr_pos.y = Ymin;
            } else if(curr_pos.y >= Ymax) {
                curr_pos.y = Ymax;
            }
            other.transform.position = curr_pos;
    }
}

private void Update() {
    /* Just to show the enabled checkbox in Editor */
}

}
