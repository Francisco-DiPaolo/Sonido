using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTriggerPiano : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //audioSource.PlayOneShot(audioClip);

            /*AudioSource.PlayClipAtPoint(audioClip, transform.position);
            GetComponent<Collider>().enabled = false;*/

            audioSource.Play();
        }
    }
}
