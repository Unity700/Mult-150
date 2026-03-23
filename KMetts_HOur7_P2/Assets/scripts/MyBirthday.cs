using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        int daysInMonth = 31;   // July has 31 days
        int myBirthday = 14;    // Assignment birthday day

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day == myBirthday)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }
}
