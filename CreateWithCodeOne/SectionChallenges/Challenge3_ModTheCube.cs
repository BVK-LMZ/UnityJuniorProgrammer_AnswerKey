using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Awake()
    {
        // As soon as the cube is spawned, before Start() is called, Awake() is called.
        Material material = Renderer.material; // Get the material
        material.color = new Color(0.0f, 0.0f, 0.0f, 1f); // Set a new color of black, last value is alpha/opacity
    }

    void Start()
    {
        transform.position = Vector3.zero; // Position of the cube to default (0, 0, 0)
        SetRandomColor(); // Set a random color as the game starts
        InvokeRepeating("SetRandomColor", 1f, 2f); // Call the SetRandomColor function every 2 seconds with an initial delay of 1 second
    }

    void Update()
    {
        transform.Rotate(Vector3.one * Time.deltaTime * 50f); // The speed of rotation of the cube on all axes
    }

    public void SetRandomColor()
    {
        Color[] colors = new Color[5]; // Array of colors

        // Fill the array with your desired colors
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        colors[3] = Color.yellow;
        colors[4] = Color.cyan;

        // Generate a random index within the range of the array
        int randomIndex = Random.Range(0, colors.Length);

        Material material = Renderer.material; // Get the material
        material.color = colors[randomIndex]; // Set the color of the cube to the random color
    }
}
