using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepsOnGras;
    public AudioClip[] footstepsOnWood;
    public AudioClip[] footstepsOnConcrete;
    public string material;

    
    public void PlayFootstepSound()
    {
        AudioSource audio = GetComponent <AudioSource>();
        audio.volume = Random.Range(.9f, 1f);
        audio.pitch = Random.Range(.9f, 1.2f);

        if (material == "Grass")
            audio.PlayOneShot(footstepsOnGras[Random.Range(0, footstepsOnGras.Length)]);
        else if (material == "Concrete")
            audio.PlayOneShot(footstepsOnConcrete[Random.Range(0, footstepsOnConcrete.Length)]);
        else if (material == "Wood")
            audio.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
    }

    private void OnCollisionEneter3d(Collision collison)
    {
        Debug.Log("Pilla colision");
        Debug.Log(collison.gameObject.tag);
        switch (collison.gameObject.tag)
        {
            case "Grass":
                material = collison.gameObject.tag;
                break;
            case "Wood":
                material = collison.gameObject.tag;
                break;
            case "Concrete":
                material = collison.gameObject.tag;
                break;
            default:
                break;
        }
    }
}
