using UnityEngine;

public class marca_gols : MonoBehaviour
{
    public bool golDoJogador1;

    void OnTriggerEnter2D(Collider2D other)
    {
        FindAnyObjectByType<GameManager>().AumentarPontosJogador(golDoJogador1);
        other.gameObject.transform.position = Vector2.zero;
    }
}
