using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimatorScript : MonoBehaviour
{
    public Animator anim;
    public string doorColor;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        if (doorColor == "red" && collision.gameObject.tag == "Player" && player.GetComponent<WarriorController>().hasRedKey == true) {
            anim.SetBool("isOpen", true);
        } else if (doorColor == "blue" && collision.gameObject.tag == "Player" && player.GetComponent<WarriorController>().hasBlueKey == true) {
            anim.SetBool("isOpen", true);
        } else if (doorColor == "green" && collision.gameObject.tag == "Player" && player.GetComponent<WarriorController>().hasGreenKey == true) {
            anim.SetBool("isOpen", true);
        }
    }

    void OnTriggerExit(Collider collision) {
        // if (doorColor == "red" && collision.gameObject.tag == "Player") {
        //     anim.SetBool("isOpen", false);
        // } else if (doorColor == "blue" && collision.gameObject.tag == "Player") {
        //     anim.SetBool("isOpen", false);
        // } else if (doorColor == "green" && collision.gameObject.tag == "Player") {
        //     anim.SetBool("isOpen", false);   
        // }
    }
}
