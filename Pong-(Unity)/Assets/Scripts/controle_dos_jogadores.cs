using UnityEngine;

public class controle_dos_jogadores : MonoBehaviour
{
    public float velocidadeDoJogador;

    public bool jogador1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverJogadores(jogador1);
    }

    private void MoverJogadores(bool jogador1) 
    {
        //define limites verticais da tela
        const float yMin = -4;
        const float yMax = 4;

        //força os limites verticais ao game object
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        //checa qual é o jogador sendo controlado e move-o correspondentemente
        if (jogador1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
            }
        }
        else 
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
            }
        }
    }
}
