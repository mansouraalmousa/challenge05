using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public Transform gun;

    public GameObject bulletprefab;

    public float speed = 10f;
    public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletprefab, gun.position, gun.rotation);
            bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward*1*speed;
            audioPlayer.Play();
        }


    }
 
    }

