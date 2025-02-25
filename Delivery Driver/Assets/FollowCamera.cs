using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    void LateUpdate() //para reduzir o gargalo do processamento da câmera.
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
