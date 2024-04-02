using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]private GameObject player;
    [SerializeField]private float camSpeed;
    

    void Update()
    {
        
        camMovement();
    }

    void camMovement()
    {
        Vector3 newPosition = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
        this.transform.position = Vector3.Lerp(this.transform.position, newPosition, camSpeed * Time.deltaTime);
    }
}
