using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        float time = (x != 0 || y != 0) ? 1f : .03f;
        float lerpTime = (x != 0 || y != 0) ? .05f : .5f;

        Time.timeScale = Mathf.Lerp(Time.timeScale, time, lerpTime);
    }
}
