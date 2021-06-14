using UnityEngine;

public class TestCameraController : MonoBehaviour
{
    public Transform player;
    public float yOffSet = 10f;
    public float zOffSet = -5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + yOffSet, player.position.z + zOffSet);
    }
}
