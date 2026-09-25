using UnityEngine;

public class Enemy : MonoBehaviour
{
   public bool isAlive = true;
   public float Speed = 2.0f;
   public int attackImpact = 10;
   public string name = "Placeholder";
   private int coins = 0;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("enemy spawned");
       Debug.Log("script loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
