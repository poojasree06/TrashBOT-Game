using UnityEngine;
/* Tried to add sounds to each waste item but couldn't do it*/
public class ChipsSound : MonoBehaviour
{
  public AudioSource Chips;
  public AudioClip sound;
  void Start()
  {
    Chips = GetComponent<AudioSource> ();              // Return component of type AudioSource
  }
 public void OnCollisionEnter(Collision collision){      // If it is collided with a material tagged as waste sounds is triggered
    if(collision.gameObject.tag == "waste"){
        Chips.PlayOneShot(sound);
    }
  }
}
