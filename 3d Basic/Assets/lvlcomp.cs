using UnityEngine;
using UnityEngine.SceneManagement;
public class lvlcomp : MonoBehaviour
{
    public void Loadnxtlvl()
    {
        SceneManager.LoadScene("Lvl2");
    }
}
