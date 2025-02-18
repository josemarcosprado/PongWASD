using UnityEngine;

public class bola : MonoBehaviour
{   
    public float VelocidadeDaBola;

    public Rigidbody2D oRigidbody2D;
    public AudioSource somDaBola;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoverBola()
    {
        oRigidbody2D.linearVelocity = new Vector2(VelocidadeDaBola, VelocidadeDaBola);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somDaBola.Play();

        //previne bug e deixa o jogo mais dificil com o tempo
        oRigidbody2D.linearVelocity += new Vector2((float)0.05, (float)0.05);
    }
}
