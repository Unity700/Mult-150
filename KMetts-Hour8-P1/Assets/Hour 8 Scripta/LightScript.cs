using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light bulb;

    void Start()
    {
        bulb = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            bulb.enabled = !bulb.enabled;
        }
    }
}
