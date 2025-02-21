using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontosJogador1;
    public int pontosJogador2;

    public Text textoDePontuacao;
    public AudioSource somDoGol;
    public AudioSource musicaDeFundo;
    public GameObject menuDePausa;
    private bool pausa;
    public float velBolaX;
    public float velBolaY;

    [SerializeField] private string nomeCenaMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pontosJogador1 = 0;
        pontosJogador2 = 0;
        EscrevePontos();
        pausa = false;

    }

    // Update is called once per frame
    void Update()
    {
        PausaNoEsc();
    }

    public void AumentarPontosJogador(bool golDoJogador1)
    {
        if (golDoJogador1)
        {
            pontosJogador2 += 1;
        } 
        else 
        {
            pontosJogador1 += 1;
        }
        EscrevePontos();
        somDoGol.Play();
    }

    public void EscrevePontos()
    {
        textoDePontuacao.text = pontosJogador1 + "  X  " + pontosJogador2;
    }

    private void PausaNoEsc()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pausa == false)
        {
            //tira o texto de pontuação
            textoDePontuacao.text = "";

            //armazena os valores de velocidade da bola
            velBolaX = FindAnyObjectByType<bola>().oRigidbody2D.linearVelocityX;
            velBolaY = FindAnyObjectByType<bola>().oRigidbody2D.linearVelocityY;

            //para a bola
            FindAnyObjectByType<bola>().PararBola();

            //mostra o menu de pausa
            menuDePausa.SetActive(true);
        
            pausa = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pausa == true)
        {
            //reescreve os pontos na tela
            EscrevePontos();

            //move a bola com a velocidade armazenada anteriormente
            FindAnyObjectByType<bola>().MoverBola(velBolaX, velBolaY);

            //oculta o menu de pausa
            menuDePausa.SetActive(false);

            pausa = false;
        }
    }

    public void btnRetomar()
    {
        SceneManager.LoadScene(nomeCenaMenu);
    }
}
