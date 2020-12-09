using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 60f;
    public Rigidbody2D rb;
    private bool isPinned = false;
    void Update()
    {
        if(!isPinned)
         rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform); //çarpan nesneyi yani Rotator'ı, pin'in parent'ı yaptık. Bu sayede pin, rotator ile birlikte dönüyor
            isPinned = true;
            Score.pinCount++;
        }      
        else if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
