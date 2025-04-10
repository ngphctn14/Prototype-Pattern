using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public virtual Monster Clone() 
    {
        Debug.Log("This should not return");
        return new Monster();
    }
}
