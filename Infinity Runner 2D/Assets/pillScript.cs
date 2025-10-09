using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Platformer;

public class pillScript : MonoBehaviour
{
    public Animator animator;
    public GameObject placar;
    void Start()
    {
                animator = GetComponent<Animator>();
                placar = GameObject.Find("Placar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            animator.SetBool("alive", false);
            placar.GetComponent<Placar>().placar += 35;
            if(other.gameObject.TryGetComponent<PlayerController>(out PlayerController pcs)) {
                pcs.tempoIma += 10;
                
            }
            Destroy(this.gameObject);

    }

}
