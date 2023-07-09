using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MailboxAI : MonoBehaviour
{
    public NavMeshAgent mailbox;
    public Transform player;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    
    void Update()
    {
        Debug.Log(mailbox.remainingDistance);
        Debug.Log(mailbox.stoppingDistance);
        mailbox.SetDestination(player.position);
        if ((mailbox.remainingDistance <= mailbox.stoppingDistance)&&(mailbox.remainingDistance > 0))
        {

            //gameOver = true;
            SceneManager.LoadScene(2);
        }

     
    }
}
