using UnityEngine;

public class CameraRunner : MonoBehaviour
{
    public GameObject ObjectToFollow;

    // Update is called once per frame
    void Update()
    {
        float interpolation = 2.0f;

        Vector3 position = this.transform.position;

        position.y = Mathf.Lerp(this.transform.position.y, ObjectToFollow.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, ObjectToFollow.transform.position.x, interpolation);

        this.transform.position = position;
    }
}
