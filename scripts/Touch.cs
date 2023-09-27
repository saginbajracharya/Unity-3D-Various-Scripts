using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private Controls player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
    }
    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveright = false;
    }
    public void Jump()
    {
        player.jump = true;
    }
    public void Sprint()
    {
        player.sprint = true;
    }
    public void ReleaseSprint()
    {
        player.sprint = false;
    }
}
