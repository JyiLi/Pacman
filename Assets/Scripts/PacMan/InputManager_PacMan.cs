using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager_PacMan : MonoBehaviour
{
    Animator anim;

    //Assignment 3 Tween
    [SerializeField] private GameObject pac;
    private Tweener tweener;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if(up() || down() || left() || right())
        {
            anim.SetTrigger("Rotate");
            if (up())
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0); //the current rotation is (0,0,90), which is the up state.
            if (down())
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
            if (left())
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
            if (right())
                gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }

    bool up()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            return true;
        else
            return false;
    }

    bool down()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            return true;
        else
            return false;
    }

    bool left()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }

    bool right()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            return true;
        else
            return false;
    }
}
