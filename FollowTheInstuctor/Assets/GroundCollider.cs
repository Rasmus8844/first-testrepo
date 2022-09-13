using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer; 

   private void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material.color = GetRandomColor();

    }
    private Color GetRandomColor()
    {
        Color colour = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        return colour;
    }

}
