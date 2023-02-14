using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    float thisIsADesimal = 3.14f;
    int thisIsAWholeNumber = -10;
    string thisIsAWordOrSentence = "Your mom";
    bool thisIsTrueOrFalse = true;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(thisIsADesimal);
       thisIsADesimal++;
       Debug.Log(thisIsADesimal);
    }

    // Update is called once per frame
   void Update()
   {
        //transform.position = new Vector3(0, 2, -10);
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += 0.5f;
        }
        


        transform.position = newPos;
   }
}
