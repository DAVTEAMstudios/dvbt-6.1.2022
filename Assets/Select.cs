using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    [SerializeField] GameObject ch1,ch2,ch3;

    public void The1()
    {
        ch1.SetActive(true);
    }

    public void X()
    {
        ch1.SetActive(false);
    }

    public void The2()
    {
        ch2.SetActive(true);
    }

    public void X2()
    {
        ch2.SetActive(false);
    }

    public void The3()
    {
        ch3.SetActive(true);
    }

    public void X3()
    {
        ch3.SetActive(false);
    }

}
