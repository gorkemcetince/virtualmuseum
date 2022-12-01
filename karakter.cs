using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
    public AudioClip domna, kyebele, lahit, mezarsteli, mezartasi, tapra, yazitlar;
    public AudioSource aso;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            aso.Play();
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag.Equals("domna"))
        {
            aso.clip = domna; 
        }
        if (collision.gameObject.tag.Equals("kyebele"))
        {
            aso.clip = kyebele;
        }
        if (collision.gameObject.tag.Equals("lahit"))
        {
            aso.clip = lahit;
        }
        if (collision.gameObject.tag.Equals("mezarsteli"))
        {
            aso.clip = mezarsteli;
        }
        if (collision.gameObject.tag.Equals("mezartasi"))
        {
            aso.clip = mezartasi;
        }
        if (collision.gameObject.tag.Equals("tapra"))
        {
            aso.clip = tapra;
        }
        if (collision.gameObject.tag.Equals("yazitlar"))
        {
            aso.clip = yazitlar;
        }

    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag.Equals("domna"))
        {
            aso.clip = null;
        }
        if (collision.gameObject.tag.Equals("kyebele"))
        {
            aso.clip = null;
        }
        if (collision.gameObject.tag.Equals("lahit"))
        {
            aso.clip = null;
        }
        if (collision.gameObject.tag.Equals("mezarsteli"))
        {
            aso.clip = null;
        }
        if (collision.gameObject.tag.Equals("mezartasi"))
        {
            aso.clip = null;
        }
        if (collision.gameObject.tag.Equals("tapra"))
        {
            aso.clip = null;
        }
        if (collision.gameObject.tag.Equals("yazitlar"))
        {
            aso.clip = null;
        }
    }
}
