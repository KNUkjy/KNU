using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterExit : MonoBehaviour
{
    public GameObject Letter;

    public void letterExit()
    {
        Letter.SetActive(false);
    }
}
