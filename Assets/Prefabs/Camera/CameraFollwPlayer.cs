using UnityEngine;

public class CameraFollwPlayer : MonoBehaviour
{
    private Vector3 offSet;
    private PlayerMovement playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offSet = new Vector3(0,1,-5);
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void LateUpdate()
    {
        if (playerMovement != null)
        {
            gameObject.transform.position = playerMovement.transform.position + offSet;
        }
    }

}
