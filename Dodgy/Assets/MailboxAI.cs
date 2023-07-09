using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MailboxAI : MonoBehaviour
{
    public NavMeshAgent mailbox;
    public Transform player;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mailbox.SetDestination(player.position);
        if (mailbox.remainingDistance <= mailbox.stoppingDistance)
        {
            gameOver = true;
        }
     
    }
}
