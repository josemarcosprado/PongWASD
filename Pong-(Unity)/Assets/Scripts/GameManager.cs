using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontosJogador1;
    public int pontosJogador2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }
}
