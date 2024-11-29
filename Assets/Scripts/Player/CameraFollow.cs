using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public BoxCollider2D mapBounds;

    private float xMin, xMax, yMin, yMax;
    private float camX, camY;
    private float camOrthSize;
    private float camRatio;
    private Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        xMin = mapBounds.bounds.min.x;
        xMax = mapBounds.bounds.max.x;

        yMin = mapBounds.bounds.min.y;
        yMax = mapBounds.bounds.max.y;

        mainCam = GetComponent<Camera>();

        camOrthSize = mainCam.orthographicSize;
        
        camRatio = (xMax + camOrthSize) / 2f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        camX = Mathf.Clamp(player.position.x, xMin + camRatio, xMax - camRatio);

        camY = Mathf.Clamp(player.position.y, yMin + camOrthSize, yMax - camOrthSize);

        transform.position = new Vector3(camX, camY, transform.position.z);
    }
}
