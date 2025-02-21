using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public AudioSource musicaMenu;

    [SerializeField] private string nomeCenaJogo;
    public void btnJogar()
    {   
        SceneManager.LoadScene(nomeCenaJogo);
    }

    public void btnSair()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
