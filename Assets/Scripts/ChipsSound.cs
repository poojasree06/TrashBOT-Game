using UnityEngine;

public class ChipsSound : MonoBehaviour
{
    // Start is called before the first frame update
  public AudioSource Chips;
  public AudioClip sound;
  void Start()
  {
    Chips = GetComponent<AudioSource> ();
  }
 public void OnCollisionEnter(Collision collision){
    if(collision.gameObject.tag == "waste"){
        Chips.PlayOneShot(sound);
       // Chips.Play();
    }
  }
}
