using UnityEngine;

public abstract class Controller
{

    ZeusController overlord;

    public Controller(ZeusController gc)
    {
        this.overlord = gc;
    }

    public abstract void InitModelView();

    public abstract void InitModelView(GameObject parent);

    void OnInit()
    {
        // Default is to do nothing
    }

}