using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private ParticleSystem particles;

    public void PlayParticlesAnimation()
    {
        animator.SetBool("isPulsing", false);
        particles.Play();
    }
}
