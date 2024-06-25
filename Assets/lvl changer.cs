using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlchanger : MonoBehaviour
{
    public vectorthreescriptableobject loca;
    
    public void transitioner(string name)
    {
        
        SceneManager.LoadScene(name);

    }

    public void PlayerLocationRestartX(float X)
    {
        loca.location.x = X;
    }
    public void PlayerLocationRestartY(float Y)
    {
        loca.location.y = Y;
    }
    public void PlayerLocationRestartZ(float Z)
    {
        loca.location.z = Z;
    }
}
