using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PagUp : MonoBehaviour
{
    public string macabra; // Nome da cena para mudar

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Verifica se a tecla Espaço foi pressionada
        {
            SceneManager.LoadScene("Menu"); // Carrega a cena com o nome especificado
        }
    }
}