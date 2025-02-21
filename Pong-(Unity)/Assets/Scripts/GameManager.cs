using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontosJogador1;
    public int pontosJogador2;

    public Text textoDePontuacao;
    public AudioSource somDoGol;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pontosJogador1 = 0;
        pontosJogador2 = 0;
        EscrevePontos();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        textoDePontuacao.text = pontosJogador1 + " X " + pontosJogador2;
    }
}
