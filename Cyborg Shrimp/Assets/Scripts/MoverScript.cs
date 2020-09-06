
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;

    void Start()
    {
        Debug.Log(message:"Hello World!");
    }
    
    // Update is called once per frame

    void Update()
    {
        var y = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var x = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        var z = 0;
        transform.Translate(x,y,z);
    }

    public void Up()
    {
        transform.Translate(x: 0, y:speed , z:0);
    }
    public void Down()
    {
        transform.Translate(x: 0, y:-speed , z:0);
    }
}
