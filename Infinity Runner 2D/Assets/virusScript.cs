using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virusScript : MonoBehaviour
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
            placar.GetComponent<Placar>().placar += 20;
            placar.GetComponent<Placar>().recorde += 20;
    }

}
