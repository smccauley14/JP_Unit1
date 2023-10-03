using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera cameraBehind;
    public Camera cameraFront;
    public KeyCode switchKey;
    public string playerId;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + playerId);
        forwardInput = Input.GetAxis("Vertical" + playerId);

        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchKey))
        {
            cameraBehind.enabled = !cameraBehind.enabled;
            cameraFront.enabled = !cameraFront.enabled;
        }


    }
}
