using Unity.VisualScripting;
using UnityEngine;

public class CreatButton : MonoBehaviour
{
    public Transform Spawner;
    public GameObject KnightPrefab;

    [SerializeField] private float _minRangeSpawn = 0f;
    [SerializeField] private float _maxRangeSpawn = 1f;

    public void TryBuy()
    {
        int price = KnightPrefab.GetComponent<Knight>().Prace;

        if (FindObjectOfType<Resourses>().Money >= price)
        {
            FindObjectOfType<Resourses>().Money -= price;

            GameObject Knight = Instantiate(KnightPrefab, Spawner);

            Knight.transform.parent = null;
        }
        else
        {
            Debug.Log("Low money");
        }
    }
}
