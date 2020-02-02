using UnityEngine;

public class FadeOutEvent : MonoBehaviour{

  private Animator _animator;

  void Awake(){
    _animator = GetComponent<Animator>();
    if(_animator==null){
      Debug.LogError("Please attatch an Animator to the Fade Out Event object");
    }
  }

  public void StartFade(){
    _animator.SetTrigger("FadeOutTrigger");
  }
}
