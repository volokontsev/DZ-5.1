using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AlarmSystem : MonoBehaviour
{
    [SerializeField] private float _timeForMaxVolume;

    private AudioSource _audioSource;
    private bool _robberInHouse;
    private float _stopwatch;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Robber>(out Robber robber))
        {
            _audioSource.Play();
            _robberInHouse = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _robberInHouse = false;
        _stopwatch = _audioSource.volume*_timeForMaxVolume;
    }

    private void Update()
    {
        if (_robberInHouse == true && _audioSource.volume!=1)
        {
            _audioSource.volume = _stopwatch/_timeForMaxVolume;
            _stopwatch += Time.deltaTime;
        }
        if(_robberInHouse == false && _audioSource.volume != 0)
        {
            _audioSource.volume = _stopwatch / _timeForMaxVolume;
            _stopwatch -= Time.deltaTime;
        }
    }
}
