using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool end= false;
    public float delay=1f;
    public GameObject doneUI;
    public void EndGame()
    {
        if(end == false)
        {
            end =true;
            Invoke("res",delay);
        }
    
    }
    void res() {
            {
                SceneManager.LoadScene("Lvl1");
                //SceneManager.GetActiveScene().name
            }
        }
    public void done()
    {
        doneUI.SetActive(true);
    }
    
}
