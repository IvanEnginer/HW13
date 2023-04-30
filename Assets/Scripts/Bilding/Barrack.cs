using UnityEngine;

public class Barrack : Bilding
{
    public  Canvas Canvas;
    public override void WhenClickOnBuilding()
    {
        base.WhenClickOnBuilding();

        Canvas.gameObject.SetActive(true);
    }

    public override void HideMenu()
    {
        Canvas.gameObject.SetActive(false);
    }
}
