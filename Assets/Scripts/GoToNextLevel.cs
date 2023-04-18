using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour {
    [SerializeField] string sceneName;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            other.transform.position = Vector3.zero;
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
        }
    }

    private void Update() {
    /* Just to show the enabled checkbox in Editor */
    }

}
