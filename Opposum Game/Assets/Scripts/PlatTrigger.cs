using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatTrigger : MonoBehaviour
{
    public PlatMovement platform;
    private void OnTriggerEnter(Collider other) {
        platform.NextPlatform();
    }
}
