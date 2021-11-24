using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusControllerAnim : MonoBehaviour
{

    public Animator myAnimatorVirus;

    public void StartVirusRotate()
    {
        myAnimatorVirus.SetBool("Virus_Rotation", true);
    }
}
