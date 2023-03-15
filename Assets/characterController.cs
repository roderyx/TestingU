using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControler : MonoBehaviour
{

    // Properties of the character
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start(){
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void flipCharacter(){
        float value = Mathf.Sign(-1f);
    }
}
