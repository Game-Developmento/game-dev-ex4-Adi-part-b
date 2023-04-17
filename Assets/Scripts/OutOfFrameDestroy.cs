using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* This component is used to destroy objects when they exit the frame.
*/
public class OutOfFrameDestroy : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
