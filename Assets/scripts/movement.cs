using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public TextMeshProUGUI scoretxt;
    public int score = 0;

   // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.W)){
            GetComponent<Transform>().position += new Vector3(0f, 0.1f, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Animator>().Play("playerback");
        }
        else if (Input.GetKey(KeyCode.S)){
            GetComponent<Transform>().position += new Vector3(0f, -0.1f, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Animator>().Play("playerfront");
        }
        else if (Input.GetKey(KeyCode.A)){
            GetComponent<Transform>().position += new Vector3(-0.1f, 0f, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Animator>().Play("playerleft");
        }
        else if (Input.GetKey(KeyCode.D)){
            GetComponent<Transform>().position += new Vector3(0.1f, 0f, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Animator>().Play("playerright");
        }
        else {
            GetComponent<Animator>().Play("playeridle");
        }

        scoretxt.text = score.ToString();

    }

    void OnTriggerEnter2D(Collider2D collider2D){
        if(collider2D.gameObject.name == "collectible"){
            Destroy(collider2D.gameObject);
            score++;
        }
        
        if(collider2D.gameObject.name == "escape"){
            SceneManager.LoadScene (sceneName:"end");
        }
    }

}
