using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    #region Singleton
    public static Game Instance = null;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public Camera cam; // Reference to the Game Camera
    public Renderer background;

    public Vector3 GetAdjustedPosition(Vector3 incomingPos)
    {
        // Calculate Half Size
        Vector3 size = background.bounds.size;
        Vector3 halfSize = size * .5f;

        // Outside Right
        if (incomingPos.x > halfSize.x)
        {
            incomingPos.x = halfSize.x;
        }
        // Outside Left
        if (incomingPos.x < -halfSize.x)
        {
            incomingPos.x = -halfSize.x;
        }
        // Outside Top
        if (incomingPos.y > halfSize.y)
        {
            incomingPos.y = halfSize.y;
        }
        // Outside Bottom
        if (incomingPos.y < -halfSize.y)
        {
            incomingPos.y = -halfSize.y;
        }
        return incomingPos;
    }
    public Vector3 GetRandomPosition()
    {
        // Get Size of Background
        Vector3 size = background.bounds.size;
        Vector3 halfSize = size * .5f;
        // Generate Random Vector and scale it by size of background
        float x = Random.Range(-1f, 1f) * halfSize.x;
        float y = Random.Range(-1f, 1f) * halfSize.y;
        return new Vector3(x, y);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
