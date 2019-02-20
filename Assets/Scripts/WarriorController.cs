using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarriorController : MonoBehaviour
{

    GameObject redKey;
    GameObject blueKey;
    GameObject greenKey;
    GameObject redDoor;
    GameObject blueDoor;
    GameObject greenDoor;

    public bool hasRedKey = false;
    public bool hasBlueKey = false;
    public bool hasGreenKey = false;

    public ParticleSystem redParticles;
    public ParticleSystem blueParticles;
    public ParticleSystem greenParticles;

    // Start is called before the first frame update
    void Start()
    {
        redKey = GameObject.Find("RedKeyCard");
        blueKey = GameObject.Find("BlueKeyCard");
        greenKey = GameObject.Find("GreenKeyCard");
        redDoor = GameObject.Find("RedDoor");
        blueDoor = GameObject.Find("BlueDoor");
        greenDoor = GameObject.Find("GreenDoor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "RedKey") {
            hasRedKey = true;
            redParticles.Play();
            Destroy(redKey);
        } else if (collision.gameObject.tag == "BlueKey") {
            hasBlueKey = true;
            blueParticles.Play();
            Destroy(blueKey);
        } else if (collision.gameObject.tag == "GreenKey") {
            hasGreenKey = true;
            greenParticles.Play();
            Destroy(greenKey);
        } else if (collision.gameObject.name == "End") {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
