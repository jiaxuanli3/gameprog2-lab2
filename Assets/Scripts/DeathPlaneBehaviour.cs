using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneBehaviour : MonoBehaviour
{
    public GameObject Player;
    Vector3 originalPlayerPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPlayerPosition = Player.transform.position;
    }

    public void RestartGame()
    {
        Player.transform.position = originalPlayerPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RestartGame();
        }
    }
}
