using UnityEngine;

public class BuildingButton : MonoBehaviour
{
    public BildingPlacer BildingPlacer;
    public GameObject BuildingPrefab;

    public void TryBuy()
    {
        int price = BuildingPrefab.GetComponent<Bilding>().Price;

        if (FindObjectOfType<Resourses>().Money >= price)
        {
            FindObjectOfType<Resourses>().Money -= price;

            BildingPlacer.CreatBuilding(BuildingPrefab);
        }
        else
        {
            Debug.Log("Low money");
        }
    }
}
