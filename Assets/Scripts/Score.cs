using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform[] copies;
    public Text scoreText;
    public Text message;


    private bool hasPlayer = false;

    void Update()
    {
        int scorePlayer = 0;
        message.gameObject.SetActive(false);

        foreach (Transform copy in copies)
        {
            //distance entre joueur et la copie du foreach
            float dist = Vector3.Distance(gameObject.transform.position, copy.position);

            //si le joueur est proche
            if (dist <= 1.9f)
            {
                //change l'�tat du joueur (joueur proche)
                hasPlayer = true;
            }
            //si le joueur est loin
            else
            {   
                //change l'�tat du joueur (joueur loin)
                hasPlayer = false;
            }

            //Si joueur proche et appuie sur E
            if (hasPlayer && Input.GetKey(KeyCode.E))
            {
                //D�sactivation de la copie
                copy.gameObject.SetActive(false);
            }

            //Si objet d�sactiv�
            if (!copy.gameObject.activeSelf)
            {
                scorePlayer += 1;
            }

            if (dist <= 1.9f && copy.gameObject.activeSelf)
            {
                //affiche l'instruction pour r�cup�r� la copie
                message.gameObject.SetActive(true);
            }

            //Affichage du score
            scoreText.text = scorePlayer.ToString() + " / 4";

        }
    }
}


