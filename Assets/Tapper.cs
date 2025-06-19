using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tapper : MonoBehaviour
{
    private Animator _anim;
    //[SerializeField] private GameObject _lineObj;
    //private LineRenderer _lr;

    [SerializeField] private Material _notSel;
    [SerializeField] private Material _sel;

    [SerializeField] private Renderer _sp1;
    [SerializeField] private Renderer _sp2;
    [SerializeField] private Renderer _sp3;
    [SerializeField] private Renderer _sp4;
    
    [SerializeField] private AudioController _audio;
    private int _tapCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        //_lr = _lineObj.AddComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update () 
    {
        if (Input.GetMouseButtonDown(0))
		{
            Debug.Log("InRay");
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);

            if (hits != null)
            {
                Array.Sort(hits, (x, y) => x.distance.CompareTo(y.distance));
                foreach (RaycastHit hit in hits)
                {
                    if (hit.transform.gameObject.CompareTag("ball"))
                    {
                        Debug.Log("Inball");
                        Renderer hitRenderer = hit.collider.GetComponent<Renderer>();
                        if (hitRenderer.sharedMaterial == _sel)
                        {
                            hitRenderer.material = _notSel;
                            continue;
                        }
                        else
                        {
                            _sp1.material = _notSel;       
                            _sp2.material = _notSel;       
                            _sp3.material = _notSel;       
                            _sp4.material = _notSel;   
                            hitRenderer.material = _sel;
                            break;
                        }
                    }
                }
            }
		}
	}
}
