using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    private bool gotkey = false;

    [SerializeField]private GameObject Key1, Key2, Key3;


    public void aquireKey(float level)
    {
        gotkey = true;
        switch(level)
        {
            case 1:
                Destroy(Key1);
                break;

            case 2:
                Destroy(Key2);
                break;

            case 3:
                Destroy(Key3);
                break;
        }
    }

    public void ResetKey()
    {
        gotkey = false;
    }

    public bool KeyObtained()
    {
        return gotkey;
    }
}
