using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    // Start is called before the first frame update
    const string animationPath = "Prefabs/Events/";
    public static Event self;
    public void Awake ()
    {
        self = this;
    }
    public void animationchange() {
        Animator ReactAnimatior = GetComponent<Animator>();
        ReactAnimatior.SetBool("number", true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")) {
            //spawnelement
            GameObject eventAnima = Instantiate(Resources.Load(animationPath + "EventAnimation"), transform) as GameObject;
            Invoke("kill", 2f);
        }
    }
    public void Award() {
        GameObject award = Instantiate(Resources.Load(animationPath + "獎勵窗口"), transform) as GameObject;
    }
    private void kill() {
        Destroy(GameObject.FindWithTag("eventanimation"));
        Invoke("Btn",0.1f);
    }
    private void Btn() {
        GameObject eventAnima = Instantiate(Resources.Load(animationPath + "Button"), transform) as GameObject;

    }
}
