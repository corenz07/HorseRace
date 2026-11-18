using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement PlayerMovementScript;
    [SerializeField] private Transform transformPlayer;
    public void CompleteLevel()
    {
        Debug.Log("félicitation tu as gagné la course!\nScore :" + transformPlayer.position.z.ToString("0"));
        PlayerMovementScript.enabled = false;
    }
}
