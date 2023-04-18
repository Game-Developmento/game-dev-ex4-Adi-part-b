using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

    GameObject player;
    public void LoadScene() {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player) {
            player.transform.position = Vector3.zero;
        }
        SceneManager.LoadScene("JumperFrog");
    }

}
