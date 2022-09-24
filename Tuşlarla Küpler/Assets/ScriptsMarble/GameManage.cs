using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public int diamond;
    public Text txt;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = diamond.ToString();
    }
    public void OpenDoor()
    {
        animator.SetBool("playAnim", true);
        Debug.Log("açıldı");
    }

    public void EndGame()
    {
        
        txt.text = "KAZANDINIZ ";
    }

}
