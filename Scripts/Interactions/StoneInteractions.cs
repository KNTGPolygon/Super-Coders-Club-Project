using UnityEngine;

public class StoneInteractions: MonoBehaviour, Interactable
{
    public ActionCallbacker Actions { get; set; }

    public string Message1()
    {
        return "Press <color=orange><b>E</b><color=black> to pick up the stone\n";
    }

    public string Message2()
    {
        return "";
    }
    
    public void Interact()
    {
        //zwieksz liczbe kamieni
        Destroy(this);
    }
    
    public GameObject GetObject()
    {
        return this.gameObject;
    }
}
