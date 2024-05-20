using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("JU TPS/Scene Management/Trigger Load Level")]
public class SimpleLevelTransition : MonoBehaviour
{
    public GameObject restartButton;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            restartButton.SetActive(true);
        }
    }
}
