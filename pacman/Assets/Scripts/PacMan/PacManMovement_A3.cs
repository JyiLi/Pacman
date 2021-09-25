using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManMovement_A3 : MonoBehaviour
{
    //Animation
    [SerializeField]Animator anim_pac;

    //Assignment 3 Tween
    [SerializeField] private GameObject pac;
    private Tweener tweener;

    //key position of the top corner
    Vector3 bottomRPos_PacMan = new Vector3(-8, 9, 0); //0
    Vector3 bottomLPos_PacMan = new Vector3(13, 9, 0); //1
    Vector3 TopRPos_PacMan = new Vector3(-8, 13, 0); //2
    Vector3 TopLPos_PacMan = new Vector3(-13, 13, 0); //3

    float duration; //move 1 unit every second


    // Start is called before the first frame update
    void Start()
    { 
        //anim_pac = pac.GetComponent<Animator>();
        duration = 0.1f * Time.deltaTime;

        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("PacMan Pos: " + pac.transform.position);

        //        -- Movement --

        if(tweener != null)
        {
            //from bottom right to bottom left
            if (pac.transform.position == bottomRPos_PacMan)
            {
                //Debug.Log("PacMan should move to " + bottomLPos_PacMan);
                tweener.AddTween(pac.transform, pac.transform.position, bottomLPos_PacMan, duration);
            }

            //from bottom left to top left
            if (pac.transform.position == bottomLPos_PacMan)
            {
                tweener.AddTween(pac.transform, pac.transform.position, TopLPos_PacMan, duration);
            }

            //from top left to top right
            if (pac.transform.position == TopLPos_PacMan)
            {
                tweener.AddTween(pac.transform, pac.transform.position, TopRPos_PacMan, duration);
            }

            //from top right to bottom right
            if (pac.transform.position == TopRPos_PacMan)
            {
                tweener.AddTween(pac.transform, pac.transform.position, bottomRPos_PacMan, duration);
            }
        }
    }

}
