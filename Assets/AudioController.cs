using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource _source;//AudioSource型の変数aを宣言
    [SerializeField] private AudioClip _yaho;//AudioClip型の変数bを宣言
    [SerializeField] private AudioClip _yatta;//AudioClip型の変数bを宣言
    [SerializeField] private AudioClip _jump;//AudioClip型の変数bを宣言

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayYaho()
    {
        _source.Stop();
        _source.PlayOneShot(_yaho);
    }

    public void PlayYatta()
    {
        _source.Stop();
        _source.PlayOneShot(_yatta);
    }

    public void PlayJump()
    {
        _source.Stop();
        _source.PlayOneShot(_jump);
    }
}
