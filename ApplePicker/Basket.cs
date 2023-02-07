using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
      GameObject scoreGO = GameObject.Find("ScoreCounter");
      scoreCounter = scoreGO.GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current screen positon of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = Camera.main.transform.position.z;


        // Convert from 2D to 3D Space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);


        // Move the x position of the basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        // Find out what hit this basket
        GameObject collideWidth = coll.gameObject;
        if (collideWidth.CompareTag("Apple"))
        {
            Destroy(collideWidth);
            scoreCounter.add100();
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
        }

    }
}
