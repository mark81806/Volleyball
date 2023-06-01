using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaractorMove : MonoBehaviour
{
    public Animator ReactAnimatior;
    // Start is called before the first frame update
    void Start()
    {
        ReactAnimatior = GetComponent<Animator>();
    }
    public void ClickToMove()
    {
        Debug.Log("clock");
        StartCoroutine(Angry());
        /*
        int i = UnityEngine.Random.Range(0, 3);
        switch (i)
        {
            case 0:
                StartCoroutine(Angry());
                break;
            case 1:
                StartCoroutine(Smile());
                break;
            case 2:
                StartCoroutine(Shy());
                break;
            default:
                break;
        }*/
    }
    public IEnumerator Angry()
    {
            //Audio("謀");
            ReactAnimatior.SetBool("Angry", true);
            yield return new WaitForSeconds(1f);
            ReactAnimatior.SetBool("Angry", false);
    }
}
