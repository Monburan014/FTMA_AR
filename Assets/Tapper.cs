using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapper : MonoBehaviour
{
    private Animator _anim;          // Animatorへの参
    [SerializeField]private AudioController _audio;
    private int _tapCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update () 
    {
        if (Input.GetMouseButtonDown(0))
		{
            Debug.Log("InRay");
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("InRay2");
                if (hit.transform.gameObject.CompareTag("UniChan"))
                {
                    Debug.Log("InUni");
                    _tapCounter++;
                    switch (_tapCounter % 3)
                    {
                        case 0:
                            _anim.SetTrigger("Yatta");
                            _audio.PlayYatta();
                            break;
                        case 1:
                            _anim.SetTrigger("Yaho");
                            _audio.PlayYaho();
                            break;
                        case 2:
                            _anim.SetTrigger("Jump");
                            _audio.PlayJump();
                            break;
                    }
                }
            }
		}
	}
}
