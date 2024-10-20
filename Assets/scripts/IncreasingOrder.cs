using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Puedes introducir estos números desde el inspector o desde un método
    public float numero1;
    public float numero2;
    public float numero3;

    void Start()
    {
        VerificarOrdenCreciente();
    }

    void VerificarOrdenCreciente()
    {
        if (numero1 < numero2 && numero2 < numero3)
        {
            Debug.Log("Los números están en orden creciente.");
        }
        else
        {
            Debug.Log("Los números NO están en orden creciente.");
        }
    }
}
