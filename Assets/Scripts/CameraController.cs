using UnityEngine;
using System.Collections;
namespace MachineChess
{

    public class CameraController : MonoBehaviour
    {
        public GameObject player;       //Public variable to store a reference to the player game object
                                        //public Rigidbody2D rb2D;        //stores reference to rigidbody2d
        public float smoothSpeed = 0.5f;
        private Vector3 offset;         //Private variable to store the offset distance between the player and camera

        //boardmanager calls this after creating the player object at the origin of the board, and passes in a reference to the player object
        //this allows the camera controller to know what to follow
        public void findPlayer(GameObject p)
        {
            player = p;
        }

        public void LateUpdate()
        {
            Vector3 p = player.GetComponent<Rigidbody2D>().position;
            Vector3 desiredPosition = p + new Vector3(0, 0, -10);

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = smoothedPosition;

        }
    }
}