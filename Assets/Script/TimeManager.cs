using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        float time = (horizontalInput != 0 || verticalInput != 0) ? 1f : .03f;
        float lerpTime = (horizontalInput != 0 || verticalInput != 0) ? .05f : .5f;

        Time.timeScale = Mathf.Lerp(Time.timeScale, time, lerpTime);
    }
}
