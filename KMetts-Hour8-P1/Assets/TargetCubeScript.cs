using UnityEngine;

public class TargetCubeScript : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Cube clicked!");
        gameObject.SetActive(false);
    }
}
