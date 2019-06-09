using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMASH : MonoBehaviour
{
    public float life = 5.0f;
    private float timer = 0.0f;
    public bool enter = true;
    //public Text scoreText;
    //public static int score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObject.tag)
        {
            Debug.Log("entered");
            Destroy(gameObject);
            //score += 100;
            //scoreText.text = score.ToString();
        }
        //else
        //{
        //    ScoreManager.health -= 25;
        //}
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>life)
        {
            Destroy(gameObject);
        }
    }
}
