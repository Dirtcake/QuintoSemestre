using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puller : MonoBehaviour
{
    public bool positivo;
    public PushStatues status;


    public void Move()
    {
        if (positivo == true)
        {
            status.MoreMove();
        }
        else
        {
            status.LessMove();
        }
    }
}
